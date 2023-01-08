using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Queue
{
    public class Queue
    {
        public int MaxSize { get; set; } //Sets the number of elements because this is an array
        public int[] QueueArray { get; set; } //Actual array because we will store elements in
        private int Front { get; set; } //Index to keep track of front
        public int Rear { get; set; } //Index to keep track of adds
        public int NItems { get; set; } //This will keep track of lenght

        public Queue(int size)
        {
            this.MaxSize = size;
            this.QueueArray = new int[size];
            Front= 0;
            Rear = -1;
        }

        public void Enqueue(int item)
        {
            Rear++; //Increment out pointer
            
            QueueArray[Rear] = item; //Insert into where rear was incremented
            
            NItems++; //Increment
            
        }

        public int Dequeue()
        {
            int temp = QueueArray[Front];
            Front++;
            
            if(Front == MaxSize)
            {
                Front = 0;
            }

            NItems--;
            return temp;
        }

        public int Peek() =>  QueueArray[Front];

    }
}



//Queue queue = new Queue(10);

//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);
//queue.Enqueue(4);

//queue.Dequeue();
//queue.Dequeue();

//queue.Peek();
