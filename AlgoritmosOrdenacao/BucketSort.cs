using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoritmosOrdenacao
{
    public class BucketSort
    {
        // Como o bucket sort necessita de matrizes para ser executado, implementei este algoritmo com listas para simplificar o processo
        public List<float> lista;

        public BucketSort(List<float> _lista)
        {
            lista = _lista;
        }

        public void Sort()
        {
            // lista.Count() diz a quantidade de elementos existentes na lista
            int n = lista.Count(), indice, k = 0;
            // Criando uma lista de listas para representar uma matriz
            List<List<float>> bucketMatrix = new List<List<float>>();
            // Obs; List<float> floatList = new List<float>() não funciona, pois a partir do momento que a mesma é adicionada
            // em todos os buckets da matriz, ela possui o mesmo endereço de memória para todos os índices, ou seja, toda inserção
            // na matriz afeta todos seus indices.

            for (int i = 0; i < 10; i++)
            {
                // Instanciando um novo objeto de lista de floats para cada indice da matriz de 0 a 9, cada um tem um endereço na
                // memória diferente, logo, podem ser interagidos individualmente como o bucket sort exige
                bucketMatrix.Add(new List<float>());
            }

            for (int i = 0; i < lista.Count(); i++)
            {
                // Acessando o indice valido do valor float, 0,73 gera indice 7, 0,26 gera indice 2, etc.
                indice = (int)lista[i] * 10;
                // Adicionando o valor no seu respectivo indice para a lista de floats em indice
                bucketMatrix[indice].Add(lista[i]);
            }
            for (int i = 0; i < bucketMatrix.Count(); i++)
            {
                // Aplicando insertion sort como subrotina em cada linha da matriz
                InsertionSort(bucketMatrix[i]);
            }
      
            for (int i = 0; i < bucketMatrix.Count(); i++)
            {
                for (int j = 0; j < bucketMatrix[i].Count(); j++)
                {
                    lista[k] = bucketMatrix[i][j];
                    k++;
                }
            }
        }

        private void InsertionSort(List<float> floatList)
        {
            float key;
            int j;

            for (int i = 0; i < floatList.Count(); i++)
            {
                key = floatList[i];
                j = i - 1;
                while (j >= 0 && floatList[j] > key)
                {
                    floatList[j + 1] = floatList[j];
                    j--;
                }
                floatList[j + 1] = key;
            }
        }

        public void PrintList()
        {
            for (int i = 0; i < lista.Count(); i++)
            {
                Console.Write("{0}\t", lista[i]);
            }
            Console.WriteLine("");
        }
    }
}