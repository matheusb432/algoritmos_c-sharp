using System.ComponentModel;

namespace AlgoritmosOrdenacao
{
    public class InsertionSort : NoParameters
    {
        public override void Sort()
        {
            int j, key;
            for (int i = 1; i < arr.Length; i++)
            {
                // Definindo key como o valor no indice atual
                key = arr[i];
                j = i - 1;
                // Enquanto j tem índice válido e o valor anterior a key é superior a ele
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];  // Movendo o valor maior um índice a frente
                    j--;
                }
                // O índice correto de key agora é j + 1
                arr[j + 1] = key;
            }
        }
        /* -------------Versão Explicada----------------
        public override void Sort()
        {
            int j, key;
            for (int i = 1; i < arr.Length; i++)
            {
                // Definindo key como o valor no indice atual
                key = arr[i];
                j = i - 1;
                // Enquanto j tem índice válido e o valor anterior a key é superior a ele
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];  // Movendo o valor maior um índice a frente
                    j--;
                }
                // O índice correto de key agora é j + 1
                arr[j + 1] = key;
            }
        }
        */
    }
}