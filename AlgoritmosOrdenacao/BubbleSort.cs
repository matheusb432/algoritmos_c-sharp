namespace AlgoritmosOrdenacao
{
    public class BubbleSort : NoParameters
    {
        public override void Sort()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(j, j + 1);
                    }
                }
            }
        }
    }
}