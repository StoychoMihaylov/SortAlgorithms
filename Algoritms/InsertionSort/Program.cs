namespace InsertionSort
{
    using System;

    class Program
    {
        class CArray
        {
            private int[] arr;
            private int upper;
            private int numElements;
            public CArray(int size)
            {
                arr = new int[size];
                upper = size - 1;
                numElements = 0;

            }
            public void insert(int item)
            {
                arr[numElements] = item;
                numElements++;
            }
            public void displayElements()
            {
                for (int i = 0; i <= upper; i++)
                    Console.Write(arr[i] + " ");
                Console.ReadKey();

            }
            public void clear()
            {
                for (int i = 0; i <= upper; i++)
                    arr[i] = 0;
                numElements = 0;

            }

            public void insertionsort()
            {
                int inner, temp;
                for (int outer = 1; outer <= upper; outer++)
                {
                    temp = arr[outer];
                    inner = outer;
                    while (inner > 0 && arr[inner - 1] >= temp)
                    {
                        arr[inner] = arr[inner - 1];
                        inner -= 1;
                    }
                    arr[inner] = temp;

                }

            }
        }
        static void Main(string[] args)
        {

            CArray nums = new CArray(10);
            Random rnd = new Random(100);
            for (int i = 0; i < 10; i++)

                nums.insert((int)(rnd.NextDouble() * 100));

            Console.WriteLine("before sorting: ");
            nums.displayElements();

            Console.WriteLine("during sorting: ");
            nums.insertionsort();

            Console.WriteLine("after sorting: ");
            nums.displayElements();

        }
    }
}
