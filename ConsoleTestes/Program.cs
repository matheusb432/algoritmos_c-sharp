using AlgoritmosOrdenacao;
using System;
using System.Collections.Generic;

namespace ConsoleTestes
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.Write("Digite o tamanho do array aleatório que deverá ser gerado: ");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            #region Criando os objetos para cada algoritmo
            var bubble = new BubbleSort();
            var insertion = new InsertionSort();
            var selection = new SelectionSort();
            var shell = new ShellSort();
            var counting = new CountingSort();
            var quick = new QuickSort();
            var merge = new MergeSort();
            var bucket = new BucketSort(ListaFloatAleatoria(tamanho));
            var radix = new RadixSort();
            var heap = new HeapSort();
            #endregion




            #region Instanciando um array especifico ( ou seja, com seu próprio endereço na memória ) para cada objeto
            bubble.arr = ArrayAleatorio(tamanho);
            insertion.arr = ArrayAleatorio(tamanho);
            selection.arr = ArrayAleatorio(tamanho);
            shell.arr = ArrayAleatorio(tamanho);
            counting.arr = ArrayAleatorio(tamanho);
            quick.arr = ArrayAleatorio(tamanho);
            merge.arr = ArrayAleatorio(tamanho);
            radix.arr = ArrayAleatorio(tamanho);
            heap.arr = ArrayAleatorio(tamanho);
            #endregion

            #region Chamando o método de ordenação para cada um dos arrays
            bubble.Sort();
            insertion.Sort();
            selection.Sort();
            shell.Sort();
            counting.Sort(tamanho);

            quick.Sort(0, quick.arr.Length - 1);
            merge.Sort(0, merge.arr.Length - 1);
            bucket.Sort();
            radix.Sort();
            heap.Sort();
            #endregion

            #region Display dos arrays ordenados
            bubble.PrintArray();
            insertion.PrintArray();
            selection.PrintArray();
            shell.PrintArray();
            counting.PrintArray();
            quick.PrintArray();
            merge.PrintArray();
            bucket.PrintList();
            radix.PrintArray();
            heap.PrintArray();
            #endregion

            Console.ReadLine();
        }

        private static int[] ArrayAleatorio(int tamanho)
        {
            Random random = new Random();
            int randInt;
            int[] arrayAleatorio = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                randInt = random.Next(1, tamanho);

                arrayAleatorio[i] = randInt;
            }

            return arrayAleatorio;
        }

        private static float[] ArrayFloatAleatorio(int tamanho)
        {
            Random random = new Random();
            float randFloat;
            float[] arrayAleatorio = new float[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                // Arredondando o float ate o segundo décimo
                randFloat = (float) Math.Round( random.NextDouble(), 2 );
                arrayAleatorio[i] = randFloat;
            }

            return arrayAleatorio;
        }

        private static List<float> ListaFloatAleatoria(int tamanho)
        {
            Random random = new Random();
            float randFloat;
            List<float> lista = new List<float>();

            for (int i = 0; i < tamanho; i++)
            {
                randFloat = (float)Math.Round(random.NextDouble(), 2);
                lista.Add(randFloat);
            }

            return lista;
        }
    }
}