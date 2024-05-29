using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Labs_6
{
    internal class Program
    {

        public void PrintResult(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.Write('\n');
        }

        public void selectionsort(int[] array)
        {
            Console.Write("Selection Sort: ");
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];

                int j;
                for (j = i - 1; j >= 0 && array[j] > key; j--)
                    array[j + 1] = array[j];
                array[j + 1] = key;
            }

            PrintResult(array);
        }

        public void insertionSort(int[] array) {
            Console.Write("Insertion Sort: ");

            for (int i = 1;i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (key < array[j] && j >= 0)
                {
                    array[j + 1] = array[j];
                    --j;
                }
                array[j + 1] = key;
            }

            PrintResult(array);

        }

        public static int[] RandomGenerationArray(Random rnd)
        {
            int[] result_array = new int[5];
            for (int i = 0; i < result_array.Length; i++)
            {
                result_array[i] = rnd.Next(10);
            }
            return result_array;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Program program = new Program();
            int[] generatedArray = RandomGenerationArray(rnd);
            Console.Write("Array: ");
            program.PrintResult(generatedArray);
            program.selectionsort(generatedArray);
            program.insertionSort(generatedArray);
        }
    }
}
