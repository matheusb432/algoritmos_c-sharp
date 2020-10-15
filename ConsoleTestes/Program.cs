using AlgoritmosOrdenacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            var bubble = new BubbleSort();
            var insertion = new InsertionSort();
            var selection = new SelectionSort();
            var counting = new CountingSort();

            int[] array1 = { 2, 4, 5, 6, 7, 1, 10, 9, 8, 3 };
            int[] array2 = { 3, 6, 4, 2, 1, 10, 7 };
            int[] array3 = { 2, 3, 10, 5, 1, 6, 8 };
            int[] array4 = { 5, 3, 2, 3, 5, 7, 1, 2, 9, 4, 0, 6, 8, 8, 1, 0, 9 };

            bubble.arr = array1;
            insertion.arr = array2;
            selection.arr = array3;
            counting.arr = array4;

            bubble.Sort();
            insertion.Sort();
            selection.Sort();
            counting.Sort();

            bubble.printArray();
            insertion.printArray();
            selection.printArray();
            counting.printArray();

            Console.ReadLine();
        }
    }
}
