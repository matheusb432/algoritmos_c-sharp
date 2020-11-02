using AlgoritmosOrdenacao;
using AlgoritmosPesquisa;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTestes
{
    internal class Program
    {
        private static Random random = new Random();

        private static void Main(string[] args)
        {

            #region Testes Algoritmos de Ordenação
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
            var bucket = new BucketSort(ListaDoubleAleatoria(tamanho));
            var radix = new RadixSort();
            var heap = new HeapSort();

            #endregion Criando os objetos para cada algoritmo

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

            #endregion Instanciando um array especifico ( ou seja, com seu próprio endereço na memória ) para cada objeto

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

            #endregion Chamando o método de ordenação para cada um dos arrays

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

            #endregion Display dos arrays ordenados
            #endregion 


            #region Teste Algoritmos de Pesquisa

            int[] arrayTeste = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 15, 17, 18 };
            int num = 3;
            Console.WriteLine($"valor {num} presente = {BinarySearch.Search(arrayTeste, num)}");

            Node tree = null;

            tree = BinarySearchTree.InsertNode(tree, 6, 7, 4, 2, 9, 8, 1, 5, 10, 0, 3);

            BinarySearchTree.InOrder(tree);

            Dictionary<int, bool> boolDictionary = BinarySearchTree.Search(tree, 1, 2, 7, 4, 0, 20, 15, 11, 10);
            Console.WriteLine();

            foreach (int key in boolDictionary.Keys)
            {
                Console.WriteLine($"Valor {key} na árvore = {boolDictionary[key]}");
            }

            #endregion Teste de algoritmos de pesquisa

            Console.ReadLine();
        }

        private static int[] ArrayAleatorio(int tamanho)
        {
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
            float randFloat;
            float[] arrayAleatorio = new float[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                // Arredondando o float ate o segundo décimo
                randFloat = (float)Math.Round(random.NextDouble(), 2);
                arrayAleatorio[i] = randFloat;
            }

            return arrayAleatorio;
        }

        private static List<int> ListaAleatoria(int tamanho)
        {
            int randInt;
            List<int> lista = new List<int>();

            for (int i = 0; i < tamanho; i++)
            {
                randInt = random.Next(1, tamanho);

                lista.Add(randInt);
            }

            return lista;
        }

        private static List<double> ListaDoubleAleatoria(int tamanho)
        {
            double randDouble;
            List<double> lista = new List<double>();

            for (int i = 0; i < tamanho; i++)
            {
                randDouble = Math.Round(random.NextDouble(), 2);
                lista.Add(randDouble);
            }

            return lista;
        }
    }
}