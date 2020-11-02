namespace AlgoritmosOrdenacao
{
    public class SelectionSort : NoParameters
    {
        public override void Sort()
        {
            int min;                
            for (int i = 0; i < arr.Length; i++)
            {
                min = arr[i];
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        temp = min;
                        min = arr[j];
                        arr[j] = temp;
                    }
                }
                arr[i] = min;
            }
        }
    }
}