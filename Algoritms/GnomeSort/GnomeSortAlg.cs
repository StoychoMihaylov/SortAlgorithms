namespace GnomeSort
{
    class GnomeSortAlg
    {
        static void Main()
        {
            int[] array = new int[] { 100, 2, 56, 200, -52, 3, 99, 33, 177, -199 };
            GnomeSort(array);
        }

        public static void GnomeSort(int[] array)
        {
            int i = 1;
            int j = 2;

            while (i < array.Length)
            {
                if (array[i - 1] <= array[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    int tmp = array[i - 1];
                    array[i - 1] = array[i];
                    array[i] = tmp;
                    i -= 1;
                    if (i == 0)
                    {
                        i = 1;
                        j = 2;
                    }
                }
            }
        }
    }
}
