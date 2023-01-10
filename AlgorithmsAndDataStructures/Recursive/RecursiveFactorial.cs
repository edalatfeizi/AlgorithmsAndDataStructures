using AlgorithmsAndDataStructures.Recursive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Recursive
{
    public class RecursiveFactorial
    {
        //Factorial Formula:
        // 1 * 2 * 3 * 4 * 5 * ...
        //Example 5! => 5 * 4 * 3 * 2 * 1 = 120
        public int GetFactorial(int num)
        {
            if (num == 0)
                return 1;
            return num * GetFactorial(num - 1);
        }
    }
}
////Program.cs
//var factorial = new RecursiveFactorial();
//var factorialNum = factorial.GetFactorial(5);
//Console.WriteLine(factorialNum.ToString());