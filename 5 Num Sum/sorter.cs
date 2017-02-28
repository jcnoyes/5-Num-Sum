/********************************************************************
 * sorter.cs - used to sort the data entered by the user.           *
 *******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Num_Sum
{
    class sorter
    {
        //Function to sort the data
        public List<float> sort(List<float> elementList)
        {
            int elements = elementList.Count();

            //start of insertion sort
            //run through each element
            for (int i = 1; i <= elements - 1; i++ )
            {
                float x = elementList[i];
                int j = i - 1;

                //While j >= 0 and elementList[j] > x
                while(j >= 0 && elementList[j] > x)
                {
                    elementList[j + 1] = elementList[j];
                    j = j - 1;
                }

                elementList[j + 1] = x;
            }


            return elementList;
        }
    }
}
