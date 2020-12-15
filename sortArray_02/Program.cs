using System;

namespace sortArray_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int num = 0;

            Console.WriteLine("Elements: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        num = array[i];
                        array[i] = array[j];
                        array[j] = num;
                    }
                }
            }

            Console.WriteLine();

            //DESC  
            Console.WriteLine("Elements in DESC order: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
