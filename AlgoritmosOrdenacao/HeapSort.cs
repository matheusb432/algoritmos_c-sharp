namespace AlgoritmosOrdenacao
{
    public class HeapSort : Algoritmo
    {
        public void Sort()
        {
            int n = arr.Length;

            // Criando a max heap com o array, uma max heap é uma árvore binária onde a raiz sempre é maior que seus nós filhos
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(n, i);
            }
            // A cada loop a raiz (indice 0) é trocada pelo valor mais na direita o possível do array, ordenando o array.
            for (int i = n - 1; i >= 1; i--)
            {
                Swap(i, 0);
                Heapify(i, 0);
            }
        }

        private int Heapify(int tamanho, int i)
        {
            int largest = i;    // Definindo o maior elemento como a raiz
            int left = i * 2 + 1;    // i*2 + 1 representa o nodo-filho da esquerda
            int right = i * 2 + 2;   // i*2 + 2 representa o nodo-filho da direita

            // Esses dois if's tratam o caso de algum nodo filho ser o maior, caso sim, o novo indice do maior valor será redefinido
            if (left < tamanho && arr[largest] < arr[left])
                largest = left;
            if (right < tamanho && arr[largest] < arr[right])
                largest = right;

            // Caso necessário, trocar os valores do nodo filho e da raiz para a raiz posuir o maior valor, e então chamar Heapify() recursivamente ao nodo filho.
            if (largest != i)
            {
                Swap(largest, i);
                Heapify(tamanho, largest);
            }

            return tamanho;
        }
    }
}