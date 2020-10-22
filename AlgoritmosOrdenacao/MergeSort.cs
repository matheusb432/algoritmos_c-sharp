namespace AlgoritmosOrdenacao
{
    public class MergeSort : DivideAndConquer
    {
        public override void Sort(int inicio, int fim)
        {
            if (inicio < fim)
            {
                int meio = inicio + (fim - inicio) / 2;

                Sort(inicio, meio);
                // meio+1 para nao repetir elementos nas sublistas
                Sort(meio + 1, fim);

                Merge(inicio, meio, fim);
            }
        }

        private void Merge(int inicio, int meio, int fim)
        {
            int tamanhoEsq = meio - inicio + 1;
            int tamanhoDir = fim - meio;
            int tamanhoTemp = fim - inicio;

            //if (arr.Length % 2 == 0)
            //{
            //    tamanhoEsq = meio - inicio;
            //    tamanhoDir = fim - meio;
            //}
            //else
            //{
            //    tamanhoEsq = meio - inicio;
            //    tamanhoDir = fim - meio + 1;
            //}

            int[] esquerda = new int[tamanhoEsq];
            int[] direita = new int[tamanhoDir];

            int i, j, k;

            for (i = 0; i < tamanhoEsq; i++)
            {
                esquerda[i] = arr[inicio + i]; // localizando dinamicamente o indice do subarray da esq
            }
            for (i = 0; i < tamanhoDir; i++)
            {
                direita[i] = arr[i + meio + 1]; // localizando dinamicamente o indice do subarray da dir
            }
            //Console.WriteLine("\n   Lista esquerda:");
            //for (i = 0; i < esquerda.Length; i++)
            //{
            //    Console.Write("{0}\t", esquerda[i]);
            //}
            //Console.WriteLine("\n   Lista direita:");
            //for (i = 0; i < direita.Length; i++)
            //{
            //    Console.Write("{0}\t", direita[i]);
            //}
            //Console.WriteLine("");

            i = 0; j = 0; k = inicio;
            // Enquanto ambos tem indice valido
            while (i < tamanhoEsq && j < tamanhoDir)
            {
                // Coloca o menor valor entre eles na lista em cada iteração do loop
                if (esquerda[i] <= direita[j])
                {
                    arr[k] = esquerda[i];
                    i++;
                }
                else
                {
                    arr[k] = direita[j];
                    j++;
                }
                k++;
            }

            // Caso ainda sobrar elementos em alguma das listas, colocar eles no array
            while (i < tamanhoEsq)
            {
                arr[k] = esquerda[i];
                i++;
                k++;
            }
            while (j < tamanhoDir)
            {
                arr[k] = direita[j];
                j++;
                k++;
            }

            //for (int k = inicio; k < fim; k++)
            //{
            //    if (i >= esquerda.Length)
            //    {
            //        arr[k] = direita[j];
            //        j++;
            //    }
            //    else if (j >= direita.Length)
            //    {
            //        arr[k] = esquerda[i];
            //        i++;
            //    }
            //    else if (esquerda[i] < direita[j])
            //    {
            //        arr[k] = esquerda[i];
            //        i++;
            //    }
            //    else
            //    {
            //        arr[k] = direita[j];
            //        j++;
            //    }
            //}
        }
    }
}