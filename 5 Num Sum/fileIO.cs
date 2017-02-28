/********************************************************************
 * fileIO.cs - reads and writes to a file.  Reads and writes data   *
 * that is used for the 5 Num Sum calculator.                       *
 *******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _5_Num_Sum
{
    class fileIO
    {
        //file reader, obtains the data used for calculations
        public string readFile(string fileName)
        {
            string readData = "";
            string fileline = "";
            StreamReader readStreamer = new StreamReader(fileName);
            
            //use the stream reader to read each line in a .txt file
            using(readStreamer)
            {
                while((fileline = readStreamer.ReadLine()) != null)
                {
                    //uses * as a comment, ignore
                    if(fileline.Contains("*"))
                    {
                    
                    }
                    else
                    {
                        readData += fileline + ','; //add the fileline to readData
                    }
                }
            }

            return readData;
        }

        public bool writeFile(string fileName, string title, float mean, float var, float sd, float med, float fq, float tq, List<float> nums,
            float max, float min)
        {
            bool writeOk = false;
            StreamWriter writer = new StreamWriter(fileName);
            string stars = "*************************************************************";
            int count = nums.Count();

            //write the intro to the file
            writer.WriteLine(stars);
            writer.WriteLine("* " + title + "*");
            writer.WriteLine("* Summary *");
            writer.WriteLine(stars + "\n");

            //write the data list to the file
            writer.WriteLine("* data set *");
            for (int i = 0; i < count; i++ )
            {
                writer.WriteLine(nums[i]);
            }

            //Summary of calculations
            writer.WriteLine("\n" + stars);
            writer.WriteLine("* Mean: " + mean + " *");
            writer.WriteLine("* Sample Variance: " + var + " *");
            writer.WriteLine("* Standard Deviation: " + sd + " *");
            writer.WriteLine(stars);

            //5 number summary
            writer.WriteLine("* 5 Number Summay *");
            writer.WriteLine(stars);
            writer.WriteLine("* Minimum: " + min + " *");
            writer.WriteLine("* 1st Quartile: " + fq + " *");
            writer.WriteLine("* Median: " + med + " *");
            writer.WriteLine("* 3rd Quartile: " + tq + " *");
            writer.WriteLine("* Maximum: " + max + " *");
            writer.WriteLine(stars);

            writer.Close();
            return writeOk;
        }
    }
}
