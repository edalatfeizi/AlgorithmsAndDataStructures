using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Array
{
 
    public class LinearSearch
    {

        public LinearSearch()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(new LinearSearch().Search(array, 5));
        }


        //key means what value we are looking for
        public bool Search(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                    return true;
            }
            return false;
        }
    }
}
