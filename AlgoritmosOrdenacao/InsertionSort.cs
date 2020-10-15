using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosOrdenacao
{
    public class InsertionSort : Algoritmo
    {
        public override void Sort()
        {
            int j;
            for (int i = 1; i < arr.Length; i++)
            {
                j = i;
                while(arr[j-1] > arr[j])
                {
                    temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;
                    if (j > 1)
                        j--;
                }
            }
        }
    }
}
