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
            var quick = new QuickSort();

            Console.Write("Digite o tamanho da lista aleatória que deverá ser gerada: ");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            int[] listaAleatoria = ListaAleatoria(tamanho);

            bubble.arr = listaAleatoria;
            insertion.arr = listaAleatoria;
            selection.arr = listaAleatoria;
            counting.arr = listaAleatoria;
            quick.arr = listaAleatoria;

            bubble.Sort();
            insertion.Sort();
            selection.Sort();
            counting.Sort(tamanho);
            quick.Sort(0, quick.arr.Length - 1);

            bubble.printArray();
            insertion.printArray();
            selection.printArray();
            counting.printArray();
            quick.printArray();

            Console.ReadLine();
        }

        static int[] ListaAleatoria(int tamanho)
        {
            Random random = new Random();
            int randInt;
            int[] ListaAleatoria = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                randInt = random.Next(1, tamanho);

                ListaAleatoria[i] = randInt;
            }

            return ListaAleatoria;
        }

    }
}
