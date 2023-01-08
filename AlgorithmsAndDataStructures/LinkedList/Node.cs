using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }

        public void DisplayData()
        {
            Console.WriteLine(Data);
        }



    }
}
