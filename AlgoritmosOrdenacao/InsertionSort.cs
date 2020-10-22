namespace AlgoritmosOrdenacao
{
    public class InsertionSort : NoParameters
    {
        public override void Sort()
        {
            int j;
            for (int i = 1; i < arr.Length; i++)
            {
                j = i;
                while (arr[j - 1] > arr[j])
                {
                    Swap(j, j - 1);
                    if (j > 1)
                        j--;
                }
            }
        }
    }
}