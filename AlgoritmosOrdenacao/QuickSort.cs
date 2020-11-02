namespace AlgoritmosOrdenacao
{
    public class QuickSort : DivideAndConquer
    {
        public override void Sort(int inicio, int fim)
        {
            if (inicio < fim)
            {
                int pivotIndex = Partition(inicio, fim);

                Sort(inicio, pivotIndex - 1);
                Sort(pivotIndex + 1, fim);
            }
        }

        private int Partition(int inicio, int fim)
        {
            int pivot = arr[fim];
            int i = inicio;

            for (int j = inicio; j < fim; j++)
            {
                if (arr[j] < pivot)
                {
                    Swap(i, j);
                    i++;
                }
            }

            int pivotIndex = i;
            Swap(pivotIndex, fim);
            return pivotIndex;
        }

        private int PartitionAlt(int inicio, int fim)
        {
            int pivot = arr[fim];
            int i = inicio;
            for (int j = inicio; j < fim; j++)
            {
                if (arr[j] >= pivot) 
                {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    i++;
                }
            }

            int pivotIndex = i;
            Swap(pivotIndex, fim);
            return pivotIndex;
        }

        /* --------------Versão Explicada--------------
        public override void Sort(int inicio, int fim)
        {
            // se o inicio é o menor que o fim, entao a sublista tem mais de 1 elemento, e é necessário operar nela
            if (inicio < fim)
            {
                // Chamando Partition() para definir o indice do pivot atual
                int pivotIndex = Partition(inicio, fim);

                // Utilizando recursividade para ordenar as sublistas da esquerda e então da direita
                Sort(inicio, pivotIndex - 1);
                Sort(pivotIndex + 1, fim);
            }
        }

        private int Partition(int inicio, int fim)
        {
            int pivot = arr[fim];
            int i = inicio;

            for (int j = inicio; j < fim; j++)
            {
                if (arr[j] < pivot) // Se o elemento é menor que o pivo, posicionar ele na sublista da esquerda
                {
                    // Trocando os elementos para realizar a operacao de ordenacao
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    // Percorrendo a sublista da esquerda apos a operacao de troca
                    i++;
                }
            }

            int pivotIndex = i;
            // Posicionando o pivo entre a sublista da esquerda e da direita
            Swap(pivotIndex, fim);
            // Retornando o indice do pivo
            return pivotIndex;
        }

        // PartitionAlt() ordena o array em ordem decrescente
        private int PartitionAlt(int inicio, int fim)
        {
            int pivot = arr[fim];
            int i = inicio;
            for (int j = inicio; j < fim; j++)
            {
                if (arr[j] >= pivot) // Se o elemento é maior ou igual ao pivo, ordenar ele na sublista da esquerda
                {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    i++;
                }
            }

            int pivotIndex = i;
            Swap(pivotIndex, fim);
            return pivotIndex;
        } 
         */
    }
}