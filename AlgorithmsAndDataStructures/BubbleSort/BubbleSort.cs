using AlgorithmsAndDataStructures.BubbleSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.BubbleSort
{
    public class BubbleSort
    {
        public int[] Sort(int[] array)
        {
            //hold temporary swap variable, Think state
            int temp;
            //Iterates over the array
            for (int i = 0; i < array.Length; i++)
            {
                
                for (int sort = 0; sort < array.Length -1; sort++)
                {
                    //This checks to see if left side is larger than the right side
                    if (array[sort] > array[sort + 1])
                    {
                        //Swap
                        //We store variable as temp so we don't overwrite it when we swap 
                        temp = array[sort];
                        //Put left variable in the right
                        array[sort] = array[sort + 1];
                        //Put the right variable in the left
                        array[sort + 1] = temp;
                    }
                }
            }

            return array;
        }
    }
}

//var bubbleSort = new BubbleSort();
//int[] array = { 3, 13, 1, 5, 0, 7, 8 };

//var sortedArray = bubbleSort.Sort(array);

//Console.WriteLine(sortedArray);
