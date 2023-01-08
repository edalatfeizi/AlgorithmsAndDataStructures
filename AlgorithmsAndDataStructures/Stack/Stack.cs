using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Stack
{
    public class Stack
    {
        public int MaxSize { get; } //with array stacks you need a maxsize to init array

        //this holds our array
        public string[] StackArray { get; }

        //this keeps track of the top
        public int Top { get; set; }

        public Stack(int size) {
            this.MaxSize = size;
            //create array with size
            this.StackArray = new string[MaxSize];
            
            //we give the top -1 because array is zero index, if we don't it will skip the first element
            this.Top = -1; 
        }

        public void Push(string item)
        {
            Top++;
            StackArray[Top] = item;
        }

        public string Pop()
        {
            //Think placeholder
            int old_top = Top;
            //decrement top
            Top--;
            return StackArray[old_top];

        }

        public string Peek() => StackArray[Top];

        public bool isEmpty() => Top == -1;

        public bool isFull() => (MaxSize -1 == Top);

    }
}
//Stack stack = new Stack(10);

//for (int i = 0; i < 3; i++)
//{
//    stack.Push("Snap");
//    stack.Push("Pixie");
//    stack.Push("Luxy");
//}

//var top = stack.Pop();
//var peek = stack.Peek();

//while (!stack.isEmpty())
//{
//    Console.WriteLine(stack.Pop());
//}

