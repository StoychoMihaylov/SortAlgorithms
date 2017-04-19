namespace QuickSort2
{
    class QuickSort2
    {
        static void Main()
        {
            int[] a = { 5, 3, 6, 4, 2, 9, 1, 8, 7 };
            QuickSort(a);
        }

        static void QuickSort(int[] a)
        {
            QuickSort(a, 0, a.Length - 1);
        }

        static void QuickSort(int[] a, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int num = a[start];

            int i = start, j = end;

            while (i < j)
            {
                while (i < j && a[j] > num)
                {
                    j--;
                }

                a[i] = a[j];

                while (i < j && a[i] < num)
                {
                    i++;
                }

                a[j] = a[i];
            }

            a[i] = num;
            QuickSort(a, start, i - 1);
            QuickSort(a, i + 1, end);
        }
    }
}
