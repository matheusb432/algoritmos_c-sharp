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
                Sort(meio + 1, fim);

                Merge(inicio, meio, fim);
            }
        }

        private void Merge(int inicio, int meio, int fim)
        {
            int tamanhoEsq = meio - inicio + 1;
            int tamanhoDir = fim - meio;

            int[] esquerda = new int[tamanhoEsq];
            int[] direita = new int[tamanhoDir];

            int i, j, k;

            for (i = 0; i < tamanhoEsq; i++)
            {
                esquerda[i] = arr[inicio + i]; 
            }
            for (i = 0; i < tamanhoDir; i++)
            {
                direita[i] = arr[i + meio + 1]; 
            }

            i = 0; j = 0; k = inicio;
            while (i < tamanhoEsq && j < tamanhoDir)
            {
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
        }

        /* -------------Versão Explicada----------------
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
        }
        */
    }
}