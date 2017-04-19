namespace RadixSort
{
    using System;

    class RadixSortAlg
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { -1, 25, -58964, 8547, -119, 0, 78596 };
            RadixSort(ref data);
        }

        public static void RadixSort(ref int[] data)
        {
            int i, j;
            int[] temp = new int[data.Length];

            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;

                for (i = 0; i < data.Length; ++i)
                {
                    bool move = (data[i] << shift) >= 0;

                    if (shift == 0 ? !move : move)
                        data[i - j] = data[i];
                    else
                        temp[j++] = data[i];
                }

                Array.Copy(temp, 0, data, data.Length - j, j);
            }
        }
    }
}
