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

namespace InterfacePlataforma
{
    public partial class Form_visualizar : Form
    {
        List<int[,]> all_matrices = new List<int[,]>();
        int pos = 0;
      //  int advmax, advmin;
        string[] files_names = null;

        public Form_visualizar()
        {
            double errorValue = 0;
            DataMatrix dinit = new DataMatrix();
            InitializeComponent();

            errorValue = dinit.getPressure(50);
            lb_pressureValue.Text = "Value " + " \u00B1 " + errorValue.ToString("F");
        }

        // Import the adquired data and shows it as a heatmap
        // -------------------------------------------------------------
        // Imports from the data folder the adquired data and show them in a Image as a Heatmap
        // -------------------------------------------------------------
        private void Bt_temp_Click(object sender, EventArgs e)
        {
           
            
            /*  
             
             This part of the code is responsible for browsing for the files directory, 
             import this files as string, convert then to int matrixes and save them on a list, them display it on heatmap
             
             */



            // Defines a string variable that will receive the directory of csv files
            string visualize_path = string.Empty;

            // List of matrices
            List<int[,]> list_of_matrices = new List<int[,]>();

            // Guarantees that the list will be cleared
            list_of_matrices.Clear();
            
            // The size of each matrix
            int matrix_rows = 48;
            int matrix_cols = 24;

            // String to read read the file, names of the files, list of lines, list of cells
            string matrix_read;
           // string maxmin;
            string[] csv_files = null;
            //string[] calibration = null;
            string[] lines, cells;


            // Object datamatrix for color test
            DataMatrix datamatrix = new DataMatrix();



            // Allows the user browse through the directories for the files
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Selecione a pasta com os dados de baropodometria desejados.";

            // Since on HistoricalData is where usually data is recorded, it already starts from here
            fbd.SelectedPath =
                Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"../../../../HistoricalData"));

            // If users clicks OK button, them they already decided what folder the info is
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                // Saves the path and import all files from the directory
                visualize_path = fbd.SelectedPath;
               // MessageBox.Show(visualize_path);
                csv_files = Directory.GetFiles(visualize_path, "*.csv");
                //calibration = Directory.GetFiles(visualize_path, "*.txt");
                
                //MessageBox.Show(Path.GetFileName(visualize_path));
                files_names = csv_files;
            }

            // Uses try/catch to import files, so for whatever reason it doesn't work messages out "Could not import files"
            try
            {
                /*
                maxmin = File.ReadAllText(calibration[0]);
                cells = maxmin.Split('\n');
                cells = cells.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                // In this case is desirable to get max and min values, so they go also in the adv value respectively
                ////// cells[0] = advmax, cells[1] = advmin
                */

                lb_max.Text = ((datamatrix.getPressure((double)1023))/1000).ToString("F") + " MPa";
                lb_min.Text = (datamatrix.getPressure((double)0)).ToString("F") + " kPa";

                /*
                // Saved variables for hover values
                advmax = int.Parse(cells[0]);
                advmin = int.Parse(cells[1]);
*/

                // Through all the files
                for (int n=0; n < csv_files.Length; n++)
                {

                    // An int matrix that will receive the matrix converted
                    int[,] full_matrix = new int[matrix_rows, matrix_cols];


                    // Imports a chosen csv_file and clean it, removing the \r\n at the and of the file
                    matrix_read = File.ReadAllText(csv_files[n]);
                    matrix_read = matrix_read.Replace("\r\n", string.Empty);

                    // Splits the select file by the \n creating a list of lines
                    lines = matrix_read.Split('\n');
                    lines = lines.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                    // Through all the lines of this file
                    for (int i = 0; i < lines.Length; i++)
                    {
                        // Split each line by ',' leaving a list of cells of that line
                        cells = lines[i].Split(',');
                        cells = cells.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                        // Through all the cells of this line
                        for (int j = 0; j < cells.Length; j++)
                        {
                            // Saves at full_matrix each cell converted to int
                            full_matrix[i, j] = int.Parse(cells[j]);

                        }

                    }

                    // When its done, add the full_matrix to the list of matrices
                    list_of_matrices.Add(full_matrix);
                //    MessageBox.Show("Matrix: \n" + list_of_matrices[n].ToString());
                }


                // Guarantees that the list will be cleared when recieves a new list of matrices
                all_matrices.Clear();

                // Saves at global variable to analise all matrices in the future
                all_matrices = list_of_matrices;

                

                pb_heatmap.Image = datamatrix.fillHeatMap(pb_heatmap.Width, pb_heatmap.Height,list_of_matrices[0]);
                lb_nameFile.Text = Path.GetFileName(csv_files[0]);
                MessageBox.Show("Dados importados com sucesso");

                

            }
            catch
            {
                MessageBox.Show("Could not import the files");
            }
                
        }

        // Shows the previous matrix
        // -------------------------------------------------------------
        // Based on the current matrix showing, goes back and shows the previous matrix if there is any
        // -------------------------------------------------------------
        private void Bt_right_Click(object sender, EventArgs e)
        {
            DataMatrix datamatrix = new DataMatrix();
            if(pos < all_matrices.Count-1)
            {
                pos++;
                pb_heatmap.Image = datamatrix.fillHeatMap(pb_heatmap.Width, pb_heatmap.Height, all_matrices[pos]);
                lb_nameFile.Text = lb_nameFile.Text = Path.GetFileName(files_names[pos]);
            }
        }

        // Shows the next matrix
        // -------------------------------------------------------------
        // Based on the current matrix showing, goes foward and shows the next matrix if there is any
        // -------------------------------------------------------------
        private void Bt_left_Click(object sender, EventArgs e)
        {
            DataMatrix datamatrix = new DataMatrix();
            if (pos > 0)
            {
                pos--;
                pb_heatmap.Image = datamatrix.fillHeatMap(pb_heatmap.Width, pb_heatmap.Height, all_matrices[pos]);
                lb_nameFile.Text = lb_nameFile.Text = Path.GetFileName(files_names[pos]);

            }
        }

        // Fill the image scale
        // -------------------------------------------------------------
        // Calls the method that fills the reference scale with the full range of colors
        // -------------------------------------------------------------
        private void Form_visualizar_Load(object sender, EventArgs e)
        {
            DataMatrix d = new DataMatrix();

            pb_scale.Image = d.fillScale(pb_scale.Width, pb_scale.Height);
        }

        // Show specificy KiloPascal Pressure
        // -------------------------------------------------------------
        // Based on the mouse position over the image, gets the correspondent KiloPascal Pressure by the color
        // -------------------------------------------------------------
        private void Pb_heatmap_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(pb_heatmap.Image);
                Color c = bmp.GetPixel(e.X, e.Y);

                DataMatrix dm = new DataMatrix();

                double pressureValue = dm.getValueByColor(c);
                lb_pressureValue.Text = pressureValue.ToString("F") + " \u00B1 " + dm.getPressure((double)50).ToString("F");
            }
            catch (Exception)
            {

                
            }
        }
    }
}
