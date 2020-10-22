using System;

namespace AlgoritmosOrdenacao
{
    public abstract class Algoritmo
    {
        public int[] arr;
        public int temp;

        public void PrintArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}\t", arr[i]);
            }
            Console.WriteLine("");
        }

        public void Swap(int index1, int index2)
        {
            temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}