using System.Linq;

namespace AlgoritmosOrdenacao
{
    public class RadixSort : NoParameters
    {
        public override void Sort()
        {
            // Definindo o maior numero do array em maior para identificar a ordem de magnitude do maior valor do array
            int maior = arr.Max();

            int exp = 1;
            while (maior / exp > 0) // Enquanto o maior valor dividido pelo expoente é maior do que zero
            {
                CountingSort(exp);
                exp *= 10;  // Quando a ordem de magnitude de exp for maior que a ordem de magnitude de maior, o loop encerra
            }
        }

        private void CountingSort(int exp)
        {
            int n = arr.Length;
            // Inicializando count e output como dois arrays com 0 em todos seus indices
            int[] count = new int[10];
            int[] output = new int[n];
            int indice;

            for (int i = 0; i < n; i++)
            {
                // Para acessar o indice desejado na ordem de magnitude em questão do valor no índice, é necessário
                // dividir o valor pelo expoente atual e então pegar o seu módulo de 10.
                // Ex; Quando exp = 10 e arr[i] = 612 --> 612 / 10 = 61 .:. 61 % 10 = 1, logo, indice 1.
                indice = (arr[i] / exp) % 10;
                // Contabilizando o valor em count
                count[indice]++;
            }
            for (int i = 1; i < count.Length; i++)
            {
                // Definindo as posições literais de cada valor em count
                count[i] += count[i - 1];
            }
            for (int i = n - 1; i >= 0; i--)
            {
                // Novamente definindo indice para poder acessar o indice valido de count
                indice = (arr[i] / exp) % 10;
                // Decrementando count[indice] e entao acessando seu valor, para acessar seu indice valido
                output[--count[indice]] = arr[i];
            }
            // Copiando output para arr
            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }
    }
}