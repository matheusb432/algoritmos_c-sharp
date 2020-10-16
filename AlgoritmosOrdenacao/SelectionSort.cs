using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosOrdenacao
{
    public class SelectionSort : Comparison
    {
        public override void Sort()
        {
            int min;                  // - 1
            for (int i = 0; i < arr.Length; i++)
            {
                min = arr[i];
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        temp = min;
                        min = arr[j];
                        arr[j] = temp;
                    }
                }
                arr[i] = min;
            }
        }
    }
}
