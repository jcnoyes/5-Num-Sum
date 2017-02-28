/********************************************************************
 * calculator.cs - calculates the five numbers needed in the 5      *
 * number summary.                                                  *
 *******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Num_Sum
{
    class calculator
    {
        //get min by returning first number in sorted list
        public float getMin(List<float> numList)
        {
            return numList[0];
        }

        //get max by returning the last number in sorted list
        public float getMax(List<float> numList)
        {
            int elements = numList.Count();
            float max = numList[elements - 1];
            return max;
        }

        //obtains the median or quartiles
        public float getMedian(List<float> numList)
        {
            float count = numList.Count();
            float median = 0;
            bool even = false;

            //check if it is even
            if(count%2 == 0)
            {
                even = true;
            }

            //if even, take average of both middle numbers
            if(even == true)
            {
                float value = ((count) / 2) - 1;  //-1 because index starts at 0
                int lowValue = Convert.ToInt32(value);
                int highValue = lowValue + 1;

                median = (numList[highValue] + numList[lowValue]) / 2;
            }
            //is odd number of elements
            else
            {
                float value = (count / 2) - 1;
                double indexValue = Math.Ceiling(value);
                int iValue = Convert.ToInt32(indexValue);

                median = numList[iValue];
            }


            return median;
        }

        //calculates the quartile for each section (1st and 3rd)
        public float getQuartile(int section, List<float> numList)
        {
            float quartile = 0;
            //obtain the section based on the right quartile
            List<float> sectionList = calculator.getSection(section, numList);

            //call the getMedian function with the section list
            quartile = this.getMedian(sectionList);


            return quartile;
        }
        //returns the correct section needed to do calcuations for the quartiles
        private static List<float> getSection(int section, List<float> numList)
        {
            int numCount = numList.Count();
            bool odd = true;
            int division = numCount / 2;
            if(numCount%2 == 0) odd = false;
            List<float> sectionList = new List<float>();
            //need to obtain the first section for the 1st quartile
            if(section == 1)
            {
                for(int i = 0; i < division; i++)
                {
                    sectionList.Add(numList[i]);
                }
            }
            else //section is 3
            {
                if (odd == true) division = division + 1;
                for(int i = division; i < numCount; i++)
                {
                    sectionList.Add(numList[i]);
                }
            }

            return sectionList;
        }

        //calculates the mean of the data set
        public float calMean(List<float> numList)
        {
            float average = 0;
            int elements = numList.Count();
            float sum = 0;

            //add up each element to the sum
            for (int i = 0; i < elements; i++ )
            {
                sum += numList[i];
            }

            //divide sum by number of elements
            average = sum / elements;
            return average;
        }

        //function to calculate the variance
        public float calVariace(float mean, List<float> numbList)
        {
            float var = 0;
            float sum = 0;
            int numElements = numbList.Count();

            //add up each number squared
            for(int i = 0; i < numElements; i++)
            {
                float element = ((numbList[i] - mean));
                element = element * element;
                sum += element;
            }

            Convert.ToDouble(numElements);
            //calculate the variance
            var = sum / (numElements - 1);

            return var;
        }

        //does the square root, which is the standard deviation
        public float squareRoot(float var)
        {
            //get the square root of the variance
            double dsd = Math.Sqrt(var);
            float sd = Convert.ToSingle(dsd);
            return sd;
        }
    }
}
