using System;

namespace AlgoritmosOrdenacao
{
    public class CountingSort : Key
    {
        public override void Sort(int key)
        {
            int[] count = new int[key];
            int[] output = new int[arr.Length];

            for (int i = 0; i < output.Length; i++)
            {
                count[arr[i]]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = output.Length - 1; i >= 0; i--)
            {
                output[--count[arr[i]]] = arr[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
            }
        }

        /* ----------------Versão Explicada---------------
        public override void Sort(int key)
        {
            int[] count = new int[key];
            int[] output = new int[arr.Length];

            // Obs; essas operações não são necessárias, pois o valor padrao de arrays inicializados em C# é 0
            // porém esse método representa um modo de como definir todos os valores de um array como 0.
            Array.Clear(count, 0, count.Length);
            Array.Clear(output, 0, output.Length);

            // Contando as instancias de cada valor chave em arr
            for (int i = 0; i < output.Length; i++)
            {
                count[arr[i]]++;
            }
            // Definindo as posições literais ( 1 e 2, ao inves de 0 e 1, por exemplo ) de cada elemento em count
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }
            // Decrementando count para acessar o indice correto e entao colocando cada elemento de arr de modo ordenado
            // em output, indo de tras para frente no array.
            for (int i = output.Length - 1; i >= 0; i--)
            {
                // Decrementando antes de acessar o valor do indice.
                output[--count[arr[i]]] = arr[i];
            }
            // Definindo os valores de arr como os de output para finalizar o algoritmo
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
            }
        }  
        */
    }
}