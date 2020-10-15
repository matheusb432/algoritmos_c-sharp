using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosOrdenacao
{
    public abstract class Algoritmo
    {
        public int[] arr;
        public int temp;

        public void printArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine("");
        }

        public abstract void Sort();
    }
}
