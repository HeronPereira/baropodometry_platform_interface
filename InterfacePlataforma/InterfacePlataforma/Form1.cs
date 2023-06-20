using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace InterfacePlataforma
{
    public partial class Form_init : Form
    {
        public Form_init()
        {
            InitializeComponent();
            

        }
        // Calibration Variables
       // public string advmax, advmin;

        // Process nº1 - Storage Site and Data Aquisition
        // -------------------------------------------------------------
        // Start the process of registering data and collecting data
        // -------------------------------------------------------------
        private void Bt_iniciar_Click(object sender, EventArgs e)
        {
            // This is a help class, that treats the aquisition data
            DataMatrix data = new DataMatrix();

            // First of verifies if any field is empty, to make sure that no information is missing
            if ((!string.IsNullOrEmpty(txbx_fullname.Text)) && (!string.IsNullOrEmpty(txbx_idade.Text)) &&
                (!string.IsNullOrEmpty(txbx_peso.Text)) && (!string.IsNullOrEmpty(txbx_numbtest.Text)) && (!string.IsNullOrEmpty(cb_testType.Text)) && (!string.IsNullOrEmpty(cb_grupo.Text)))
            {
                // Creates a variable to save the information as a name
                string fullname;

                // Saves the person's names without spaces
                fullname = txbx_fullname.Text.Replace(" ", string.Empty);

                // Adds the person's sex and saves as string to the fullname
                if (rb_masc.Checked == true)
                {
                    fullname = fullname + "_M_";
                }
                else if (rb_fem.Checked == true)
                {
                    fullname = fullname + "_F_";
                }

                // Adds the age, weight, test type (static or dinamic) and the number of the test for the fullname variable
                fullname = fullname + "_Age" + txbx_idade.Text + "_" + txbx_peso.Text + "kg_"+ cb_grupo.Text +"Group_" + cb_testType.Text +"_T" + txbx_numbtest.Text;



                // Style Change - Change the button color by click
                bt_iniciar.BackColor = Color.Crimson;
                bt_iniciar.Text = "Loading...";


                // Sets the folder path by getting the system path to the code, to de HistoricalData folder
                string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"../../../../HistoricalData"));

                // Check if the path exists
                if (Directory.Exists(path))
                {
                    // If it does, checks if a folder with fullname doesn't exist
                    if (!Directory.Exists(Path.Combine(path, fullname)))
                    {
                        // If it does not, creates this fullname folder and popup a message
                        Directory.CreateDirectory(Path.Combine(path, fullname));
                        MessageBox.Show("Directory " + fullname + " has being created at " + path);
                    }
                    // Then saves the values.
                    
                        
                    List<int[,]> list_mat = new List<int[,]>();

                    try
                    {
                        // Calls the object method responsible for comunicate with the firmware and adquire the matrices
                        data.setMatrixesValues();

                        string filepath = Path.Combine(path, fullname);
                    
                        // Saving the adquired matrices from the method as csv files
                        for (int i = 0; i < data.adq_matrices.Length; i++)
                        {
                            if (i < 10)     // checks if is below 10 just to order the values
                            {
                                using (StreamWriter exportfile = new StreamWriter(Path.Combine(filepath, fullname + "_" +"0"+ i.ToString() + ".csv")))
                                exportfile.WriteLine(data.adq_matrices[i]);
                            }
                            else
                            {
                                using (StreamWriter exportfile = new StreamWriter(Path.Combine(filepath, fullname + "_" + i.ToString() + ".csv")))
                                exportfile.WriteLine(data.adq_matrices[i]);
                            }
                        }
                    }
                    catch
                    {

                    }
                 

                    

                    // Style Change - Change back text and color.

                    bt_iniciar.BackColor = Color.LawnGreen;
                    bt_iniciar.Text = "Start";
                    
                        
                }
                // IF the folder HistoricalData Does not exists warns the user to create it
                else
                {
                    MessageBox.Show("Please create the directory HistoryData at " + 
                        Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"../../../../")) 
                        + " to save the registers");
                }
            }
            else
                MessageBox.Show("Please Fill ALL the fields to continue");
            
        }

        // Process nº2 - Data visualization
        // -------------------------------------------------------------
        // Swift to data visualization form
        // -------------------------------------------------------------
        private void Bt_visualizar_Click(object sender, EventArgs e)
        {
            // Opens a new form
            Form_visualizar f2 = new Form_visualizar();
           f2.Show();




            
        }


        ///////                     TOTALY CHANGE THIS! - REF WEIGHT WILL BE DROPPED OUT THE EQUATION
        
        /*

        // Process nº3 - Calibration Process
        // -------------------------------------------------------------
        // Calibrates the software to find out the correspondent kPa pressure to the aquisition
        // -------------------------------------------------------------
        private void Bt_calibrar_Click(object sender, EventArgs e)
        {

            // TESTING THE SERIAL PORT COMMANDS

            // DONE: 
            //      Test to ask for a string and receive the desirable string
            //      Ask for a matrix and receive a matrix
            //      Ask for a list of matrices and receive this list of matrices
            //
            // UPCOMING: Replace the process in Iniciar button
            // 
            // BACKLOG:     
            //      
            //      Command a calibration on the results on this button


            // Set variables
            int TEMPO = 4;
            int X = 40;
            int Y = 32;

            string[,,] test_matrix = new string[TEMPO,X, Y];
            string teste = string.Empty;
            string read = string.Empty;
           // int i = 0, j = 0, n=0;
            // Creates a serialPort at COM3
            SerialPort sp = new SerialPort("COM3");

            // Defines a 9600 BaudRate
            sp.BaudRate = 9600;

            
            try
            {
                // Open the SerialPort
                sp.Open();

                // Sends "c" message, indicating that is read for calibrate
                sp.Write("c");

                // Reads all the lines while the line result won't get "d" of done
                read = sp.ReadLine().Replace("\r", string.Empty);

                while( read != "d")
                {
                    advmax = read;
                    MessageBox.Show(advmax);
                    advmin = sp.ReadLine().Replace("\r", string.Empty);

                    MessageBox.Show(advmin);
                    read = sp.ReadLine().Replace("\r", string.Empty);
                    
                    

                    MessageBox.Show(read);
                    

                    
                }
                // Closes the serial port after all of it.
                sp.Close();

                MessageBox.Show("Calibration Completed.");
            }
            catch
            {
                MessageBox.Show("Error opening Serial Port");
            }






            if ((!string.IsNullOrEmpty(txbx_fullname.Text)) && (!string.IsNullOrEmpty(txbx_idade.Text)) &&
                (!string.IsNullOrEmpty(txbx_peso.Text)) && (!string.IsNullOrEmpty(txbx_numbtest.Text)) && (!string.IsNullOrEmpty(cb_testType.Text)))
            {
                string fullname;

                fullname = txbx_fullname.Text.Replace(" ", string.Empty);

                if (rb_masc.Checked == true)
                {
                    fullname = fullname + "_M_";
                }
                else if (rb_fem.Checked == true)
                {
                    fullname = fullname + "_F_";
                }

                fullname = fullname + "_Age" + txbx_idade.Text + "_" + txbx_peso.Text + "kg_" + cb_testType.Text + "_T" + txbx_numbtest.Text;

                


                // Sets the folder path by getting the system path to the code, to de HistoricalData folder
                string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"../../../../HistoricalData"));

                // Check if the path exists
                if (Directory.Exists(path))
                {
                    // If it does check if a folder with fullname exists
                    if (!Directory.Exists(Path.Combine(path, fullname)))
                    {
                        // If it does not creates this fullname folder and popup a message
                        Directory.CreateDirectory(Path.Combine(path, fullname));
                        MessageBox.Show("Directory " + fullname + " has being created at " + path);
                    }
                    // If it already exists then just saves the values.


                  


                    

                    string filepath = Path.Combine(path, fullname);

                  
                        // Saves the calibration file in
                        using (StreamWriter exportfile = new StreamWriter(Path.Combine(filepath, fullname + "_" +"Calibration"+".txt")))
                            exportfile.WriteLine(advmax + '\n' + advmin);
                    

                 
                }
                // IF the folder HistoricalData Does not exists warns the user to create it
                else
                {
                    MessageBox.Show("Please create the directory HistoryData at " +
                        Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"../../../../"))
                        + " to save the registers");
                }
            }
            else
                MessageBox.Show("Please Fill ALL the fields to continue");







        }*/
    }
}
