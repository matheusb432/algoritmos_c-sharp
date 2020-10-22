using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosOrdenacao
{
    public class HeapSort : Algoritmo
    {
        public void Sort()
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(n, i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                Swap(i, 0);
                Heapify(i, 0);
            }
        }

        private int Heapify(int tamanho, int i)
        {
            int largest = i;
            int left = i * 2 + 1;
            int right = i * 2 + 2;

            if (left < tamanho && arr[largest] < arr[left])
                largest = left;
            if (right < tamanho && arr[largest] < arr[right])
                largest = right;

            if (largest != i)
            {
                Swap(largest, i);
                Heapify(tamanho, largest);
            }

            return tamanho;
        }
    }
}
