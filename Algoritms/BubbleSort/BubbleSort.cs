namespace BubbleSort
{
    class BubbleSort
    {
        static void Main()
        {
            int[] array = new int[] { 6, 9, 4, 3, 5, 1, 42, -2 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[i] > array[j + 1]) // swap the elements
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i] + " ");
            }
        }
    }
}
