/********************************************************************
 * Form1.cs - the main interface for the program.                   *
 *******************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Num_Sum
{
    public partial class mainForm : Form
    {
        //initialize objects used in the program
        numbObtainer obtainer = new numbObtainer();
        sorter sort = new sorter();
        calculator cal = new calculator();

        public mainForm()
        {
            InitializeComponent();
        }

        //exits the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Clears all with the menu option
        private void clearDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.clearAll();
        }

        //Internal clear all function
        private void clearAll()
        {
            medianLabel.Text = "";
            firstQLabel.Text = "";
            thirdQLabel.Text = "";
            minLabel.Text = "";
            maxLabel.Text = "";
            varLabel.Text = "";
            meanLabel.Text = "";
            sdLabel.Text = "";
            dataEntryBox.Text = "";
        }

        //Clears all with the button
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.clearAll();
        }

        //Does the calculations for each of the 5 Numbers in the Summary
        private void calButton_Click(object sender, EventArgs e)
        {
            bool check = false;
            List<float> data = new List<float>();
            //show progress form
            var progressForm = new calculatorProgressForm();
            progressForm.Show();
            progressForm.changeLabel("Checking input...");

            //check data input
            string numbString = dataEntryBox.Text;
            check = obtainer.checkNumbers(numbString);

            //if invaild, exit function and show error
            if(check == false) 
            {
                MessageBox.Show("Invaild data entry, plese try again.");
                progressForm.Close();
                return;
            }

            //get list of floats
            data = obtainer.generateList(numbString);
            if (data.Count == 0)
            {
                MessageBox.Show("Please enter values.");
                progressForm.Close();
                return;
            }

            //sort the list
            progressForm.changeLabel("Sorting data...");
            sort.sort(data);

            //change the dataEntryBox to the sorted data for user to check
            dataEntryBox.Text = "";
            string replacementString = "";
            for (int iterator = 0; iterator < data.Count(); iterator++)
            {
                replacementString += data[iterator];
                //ensure last element does not have a , after it
                if(iterator + 1 < data.Count()) replacementString += ",";
            }

            dataEntryBox.Text = replacementString;

            //calculate results
            progressForm.changeLabel("Calculating results...");
            
            //get min, which should be the first element in the list
            float min = cal.getMin(data);
            minLabel.Text = min.ToString();

            //get max, which should be the last element in the list
            float max = cal.getMax(data);
            maxLabel.Text = max.ToString();

            //get the median
            float median = cal.getMedian(data);
            medianLabel.Text = median.ToString();

            //get 1st quartile
            float firstQuartile = cal.getQuartile(1, data);
            firstQLabel.Text = firstQuartile.ToString();

            //get 3rd quartile
            float thirdQuartile = cal.getQuartile(3, data);
            thirdQLabel.Text = thirdQuartile.ToString();

            //calculate the average
            float mean = cal.calMean(data);
            meanLabel.Text = mean.ToString();

            //calculate the variance
            float variance = cal.calVariace(mean, data);
            varLabel.Text = variance.ToString();

            //calculate standard deviation
            float sd = cal.squareRoot(variance);
            sdLabel.Text = sd.ToString();

            //Close progress form now that we are done
            progressForm.Close();

        }

        private void aboutPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutPage about = new aboutPage();
            about.Show();
        }

        private void readFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileIO fileReader = new fileIO();
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "TXT Files | *.txt";
            fileDialog.InitialDirectory = @"C:\";
            fileDialog.ShowDialog();

            //get the file name to open
            string filename = fileDialog.FileName;

            if (filename == "") return;
            
            //call the file_io read function
            string data = fileReader.readFile(filename);

            //place data that was read into dataEntryBox
            dataEntryBox.Text = data;
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HowToUse htu = new HowToUse();
            htu.Show();
        }

        //button to exit program
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //saves data to a file
        private void saveResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open fileDialog
            SaveFileDialog writeFile = new SaveFileDialog();
            writeFile.Filter = "TXT Files | *.txt";
            writeFile.InitialDirectory = @"C:\";
            writeFile.ShowDialog();

            string fileName = writeFile.FileName;

            if (fileName == "") return;

            //gets data from the textboxes and the dataEntryBox
            fileIO writeData = new fileIO();

            if (dataEntryBox.Text == null) return;  //return if nothing was in dataEntryBox
            if (meanLabel.Text == null) return;     //return if no calculation was done

            //convert needed values
            float mean = Convert.ToSingle(meanLabel.Text);
            float var = Convert.ToSingle(varLabel.Text);
            float sd = Convert.ToSingle(sdLabel.Text);

            //5 number sum
            float med = Convert.ToSingle(medianLabel.Text);
            float max = Convert.ToSingle(maxLabel.Text);
            float min = Convert.ToSingle(minLabel.Text);
            float fq = Convert.ToSingle(firstQLabel.Text);
            float tq = Convert.ToSingle(thirdQLabel.Text);

            //get data from dataEntryBox
            List<float> data = new List<float>();
            numbObtainer no = new numbObtainer();
            data = no.generateList(dataEntryBox.Text);

            //call function to write to a file
            writeData.writeFile(fileName, fileName, mean, var, sd, med, fq, tq, data, max, min);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.saveResultsToolStripMenuItem_Click(sender, e);
        }
    }
}
