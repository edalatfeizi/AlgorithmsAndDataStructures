using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.BinarySearch
{
    public class BinarySearch
    {
        
        public int BinarySearchArray(int[] array,int value)
        {
            int start = 0;
            int end = array.Length;

            while (start < end)
            {
                int mid = (start + end) / 2;
                if (array[mid] == value)
                    return mid;
                else if (array[mid] < value)
                    start = mid + 1;
                else
                    end = mid;
            }
            return -1;
        }
    }
}
