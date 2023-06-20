using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace InterfacePlataforma
{
    class DataMatrix
    {
        public string[] adq_matrices = null;    // On test
        public List<int[,]> listOfMatrices = new List<int[,]>();

        public const int matrix_rows = 48;
        public const int matrix_cols = 24;
        public const int sample_rate = 25;
        public const int time_seconds = 3;
        public const float adc_resolution = 1023;

        public Color color = new Color();

        // Data Aquisition
        // -------------------------------------------------------------
        // This method communnicates with the firmware and imports the sensors reads
        // -------------------------------------------------------------
        public void setMatrixesValues()
        {

            // Set variables
            StringBuilder sb_adq_data = new StringBuilder(string.Empty);   // On test
            //StringBuilder sb_adq_data = new StringBuilder(null,matrix_cols*matrix_rows*time_seconds*sample_rate);   // On test
            //string[,,] matrix_read = new string[time_seconds*sample_rate, matrix_rows, matrix_cols];
            string teste = string.Empty;
            string read = string.Empty;
            

            // Creates a serialPort at COM5
            SerialPort sp = new SerialPort("COM5");
            try
            {
                // Sets a 115200 BaudRate
                sp.BaudRate = 115200;

                // Open the SerialPort
                sp.Open();

                // Sends "s" message, indicating that is read for start reading
                sp.Write("s");

                // On test
                // Reads all the lines while the line result won't get "d" of done
                read = sp.ReadLine().Replace("\r", string.Empty);
                while (read != "d")
                {
                    sb_adq_data.Append(read);
                    read = sp.ReadLine().Replace("\r", string.Empty);
                }
             
                // Closes the serial port after all of it.
                sp.Close();

                // Saves separated matrices by '&'
                adq_matrices = sb_adq_data.ToString().Replace('l','\n').Split('&');


               
                    // Removes empty item from the array
                    adq_matrices = adq_matrices.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                
               

                // Message out that data were imported successfully
                MessageBox.Show("Registers made successfully!");

            }
            catch
            {
                MessageBox.Show("ERROR: Could not open the serial port!");
            }



        }

        //// ESSENCIAL PART ENDS HERE ////

        // Gets the pressure value (kiloPascal) based on an a/d value

        public double getPressure(double advalue)
        {
            double pressure;                            //  Where the resulting pressure will be saved
            double exponent;                            //  Exponential for Euler value, is part of the reverse formula to convert ad value into mass (kg)
            double mass;                                //  Resultant mass value (kg) obtained by the full formula
            double area;                                //  Area of a single node (5mmx5mm) in m²
            const double gravity = 9.89;                //  Gravity value, used with the mass to find the force

            
            exponent = (advalue - 524.38) / 160.06;     //  A ln() represents the behavior of the sensor, ADvalue(mass), this is part of the inverted part of this formula (Mass(Advalue))

            mass = Math.Pow(Math.E, exponent);          //  The full inverted formula, to find the correspondent mass

            area = 5*5;             //  Divided each side of the square node by 1000 to obtain the area in m²

            pressure = (mass * gravity*1000000) / area;         //  Calculates the pressure value in Pascal

            pressure = pressure / 1000;                 //  Divides by 1000 to convert the value to kPa.

            if (pressure < 0)
                pressure = 0;                           // Prevents incoherent values

            return pressure;                            //  Returns the value of pressure in kPa
        }


   /*     // Converts Data into Pressure (KiloPascal)
        // -------------------------------------------------------------
        // -------------------------------------------------------------
        public float getKiloPascal(int adv, int advmax, int advmin)
        {
            float p;
            const int calib_ref_pressure = 31;

            p = ((calib_ref_pressure * adv) / (advmax - advmin)) - ((calib_ref_pressure * advmin) / (advmax - advmin));
            if (p < 0)
                p = 0;
            return p;
        }*/

        // Converts value into Color
        // -------------------------------------------------------------
        // To create a heatmap gets the int data and converts to the correspondent color
        // -------------------------------------------------------------
        public Color getColorByValue(int value)
        {
            float result = (float)value / adc_resolution;
            double R, G, B;
            if (result < 0.25)
            {
                R = 0;
                B = 255 - (255 / 0.25) * result;
                G = (255 / 0.25)*result;
            }
            else if(result < 0.5)
            {
                R = (255 / 0.25) * (result - 0.25);
                B = 0;
                G = 255;
            }
            else
            {
                R = 255;
                B = 0;
                G = 255 - ((255/0.5)*(result-0.5));
            }

            return Color.FromArgb((int)Math.Round(R), (int)Math.Round(G), (int)Math.Round(B));
        }

        // Converts Color into Value
        // -------------------------------------------------------------
        // Gets the KiloPascal Value based on the Received Color
        // -------------------------------------------------------------
        public double getValueByColor(Color c)
        {
            double value = 0;
            int r, g, b;

            r = c.R;
            g = c.G;
            b = c.B;

            if (r == 0)
            {
                value = 0.25 * g / 255.0;
            }
            else if ((b == 0) && (g == 255))
            {
                value = (r + 255) * 0.25 / 255;
            }
            else
            {
                value = (510 - g) * 0.5 / 255;
            }

            value = value * adc_resolution;

            value = getPressure(value);

           // value = getKiloPascal((int)value, admax, admin);

            return value;
        }

        // Fill The Heatmap Image
        // -------------------------------------------------------------
        // Gets a full matrix and fill the image of the heatmap with correspondent colors
        // -------------------------------------------------------------
        public Bitmap fillHeatMap(int Width, int Height,int[,] matrix)
        {
            Bitmap bmp = new Bitmap(Width, Height);
            for(int i=0; i < matrix_rows; i++)
            {
                for(int j=0; j < matrix_cols; j++)
                {
                    for(int x=i*10; x < i * 10 + 10; x++)
                    {
                        for (int y=j*10; y < j*10 + 10; y++)
                        {
                            bmp.SetPixel(y, x, getColorByValue(matrix[i,j]));
                        }
                    }
                }
            }
            return bmp;
        }

        // Fill the image scale
        // -------------------------------------------------------------
        // Fills the reference scale with the full range of colors
        // -------------------------------------------------------------
        public Bitmap fillScale(int Width, int Height)
        {
            Bitmap bmp = new Bitmap(Width, Height);
            int fall = 1023 / Height + 1;
            int scale = 1023;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                   bmp.SetPixel(j, i, getColorByValue(scale));
                }
                if (scale > 0)
                    scale = scale - fall;
                else
                    scale = 0;
            }
            return bmp;
        }

       
    }
}
