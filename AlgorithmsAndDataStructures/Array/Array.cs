using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Array
{
    public class Array
    {


        int[] intArray = new int[9];

        //make a variable to keep the length because .Length is based off capacity and does not track the actual index
        int length = 0;

        //this adds data for us
        //for (int i = 0; i<8; i++)
        //{
        //    //1 is optional
        //    intArray[length] = i +1;
        //    length++;
        //}

        //for (int i = 7; i >= 2; i--)
        //{
        //    //shift each element one position to the right
        //    intArray[i + 1] = intArray[i];
        //}

        //intArray[2] = 8;

        //for (int i = 0; i< 6; i++)
        //{
        //    intArray[i] = i;
        //    length++;
        //}

        //length--; // simplest way to delete from the array(fixed sized array) 


        //for (int i = 1; i < length; i++)
        //{
        //    intArray[i - 1] = intArray[i];
        //}

        //length--;
        //0 1 2 3 4 5 

        //for (int i = 5; i < length; i++)
        //{
        //    intArray[i - 1] = intArray[i];
        //}

        //length--;

        //for (int i = 0; i < length; i++)
        //{
        //    Console.WriteLine(intArray[i]);
        //}

    }
}
