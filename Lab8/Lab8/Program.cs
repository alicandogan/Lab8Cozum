using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            OzelKuyruk x = new OzelKuyruk();
            x.Enqueue(1);
            x.Enqueue(5);
            x.Enqueue(7);           
            x.Enqueue(10);
            x.Dequeue();
            x.Enqueue(13);
            x.Enqueue(16);
            x.Enqueue(24);
            x.Dequeue();
            x.Enqueue(7);
            x.Enqueue(8);

            x.ElemanlariGoruntule();

            Queue y = new Queue();
            y.Enqueue(1);
            y.Enqueue(5);
            y.Enqueue(7);
            y.Enqueue(10);
            y.Dequeue();
            y.Enqueue(13);
            y.Enqueue(16);
            y.Enqueue(24);
            y.Dequeue();
            y.Enqueue(7);
            y.Enqueue(8);

            for (int i = 0; i < y.Count; i++)
            {
                Console.WriteLine(y.Dequeue());
            }



        }
    }
}
