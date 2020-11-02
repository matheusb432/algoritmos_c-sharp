using System;

namespace AlgoritmosPesquisa
{
    public static class BinarySearch
    {
        /// <summary>
        /// Observação; Binary Search é um algoritmo de pesquisa que é funcional apenas se a coleção atual
        /// já estiver ordenada, logo, o algoritmo abaixo assume que a coleção já esteja ordenada em ordem
        /// crescente para que a sua lógica seja funcional.
        /// </summary>
        /// <param name="arr">Array ordenado que será percorrido até achar num</param>
        /// <param name="num">Valor a ser buscado</param>
        /// <param name="inicio">Início do subarray atual, valor padrão é 0 para o array original</param>
        /// <param name="fim">Fim do subarray atual, valor padrão é null e será convertido para arr.Length para o array original</param>
        /// <returns></returns>
        public static bool Search(int[] arr, int num, int inicio = 0, int? fim = null)
        {
            if (fim is null)
            {
                fim = arr.Length;
            }

            if (fim - inicio < 2)
            {
                return arr[inicio] == num;
            }
            int meio = (int)((inicio + fim) / 2);
            Console.WriteLine($"arr[meio] = {arr[meio]} em {num}");
            if (num == arr[meio])
            {
                return true;
            }
            else if (num < arr[meio])
            {
                return Search(arr, num, inicio, meio - 1);
            }
            else
            {
                return Search(arr, num, meio + 1, fim);
            }
        }

        /* --------------------------Versão explicada-----------------------------
        public static bool Search(int[] arr, int num, int inicio=0, int? fim=null)
        {
            if (fim is null)
            {
                fim = arr.Length;
            }

            if (fim - inicio < 2)
            {
                return arr[inicio] == num;
            }
            // Todo elemento à esquerda do índice meio será < arr[meio] e todo elemento à direita será > arr[meio]
            int meio = (int)((inicio + fim) / 2);
            Console.WriteLine($"arr[meio] = {arr[meio]} em {num}");
            // Se num for igual ao valor no meio do array atual, retornar true pois o valor está presente na coleção
            if (num == arr[meio])
            {
                return true;
            }
            // Se num for menor que o valor no meio do array, buscar no subarray da esquerda
            else if (num < arr[meio])
            {
                return Search(arr, num, inicio, meio - 1);
            }
            // Se num for maior que o valor no meio do array, buscar no subarray da direita
            else
            {
                return Search(arr, num, meio + 1, fim);
            }
        }
        */
    }
}