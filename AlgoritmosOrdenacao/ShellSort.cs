namespace AlgoritmosOrdenacao
{
    public class ShellSort : NoParameters
    {
        public override void Sort()
        {
            int n = arr.Length; // n como tamanho para deixar o código menos verbose

            // gap representa o espaçamento padrão do shell sort, metade do tamanho do array e depois sendo igualado a sua metade.
            // gap também não deve executar caso for 0, pois, além do array já estar ordenado, 0 / 2 = 0, o que resultará em um loop infinito.
            for (int gap = n / 2; gap >= 1; gap /= 2)
            {
                // for loop j junto ao for loop i irá possibilitar as comparações entre os elementos espaçados por gap até o indice 'n-1'
                for (int j = gap; j < n; j++)
                {
                    // No for loop de i acontece a comparação do loop, se os elementos espaçados por 'gap' precisarem ser ordenados,
                    // seus valores serão trocados, i é decrementado por gap no fim para as comparações serem feitas com base nessa variável.
                    for (int i = j - gap; i >= 0; i -= gap)
                    {
                        if (arr[i + gap] > arr[i]) // Se o valor mais adiante na lista for maior que o valor menos adiante, nao precisa trocar nenhum valor
                        {
                            break;
                        }
                        else  // Caso contrário, trocar os valores arr[i + gap] e arr[i]
                        {
                            Swap(i + gap, i);
                        }
                    }
                }
            }
        }
    }
}