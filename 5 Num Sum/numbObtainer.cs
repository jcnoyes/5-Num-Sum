/********************************************************************
 * numbObtainer.cs, obtains the numbers from the dataEntryBox and   *
 * ensures that they are usable.                                    *
 *******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Num_Sum
{
    class numbObtainer
    {
        //Does a general parse of the string to see if it is valid
        //String should only contian numbers, spaces, and commas
        public bool checkNumbers(string numberString)
        {
            bool ok = true;
            foreach (char c in numberString)
            {
                //if char is not a number, or if it is not a ,
                //or whitespace, it is invalid, set ok to false
                if(Char.IsDigit(c) == false)
                {
                    if (c == ',' || c == ' ' || c == '\n' || c == '.' || c == '-') //if valid non-digit entries
                    {
                    }
                    else ok = false;
                }
            }
            return ok;
        }

        //puts numbers into a list
        public List<float> generateList(string numberString)
        {
            string temp = "";
            List<float> dataSet = new List<float>();

            numberString += " "; //add a space in numbString to be the last character
            foreach(char c in numberString)
            {
                if(Char.IsDigit(c) == true || c == '.' || c == '-')
                {
                    temp += c;
                }
                else
                {
                    if(temp != "")
                    {
                        float f = float.Parse(temp);
                        dataSet.Add(f);
                    }
                    temp = "";
                }
            }
            return dataSet;
        }
    }
}
