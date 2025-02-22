using System;

namespace shell_sort
{
    
    public static class Sort
    {
        public static int[] GenerateRandomArray(int size)
        {
            int[] arr = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(1, 10000000);
            }
            return arr;
        }

        public static int[] GenerateSortedArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = i;
            }
            return arr;
        }
        public static int[] GenerateResersedSortedArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = size - i - 1;
            }
            return arr;
        }
        
        public static void PrintArray(int[] arr, string message)
        {
            Console.WriteLine("\n" + message);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + (i == arr.Length - 1 ? " " : ", "));
            }
        }
        
        public static void ShellSort(int[] arr)
        {
            long compares = 0;
            long swaps = 0;
            int[] gaps = { 701, 301, 132, 57, 23, 10, 4, 1 };
            foreach (var gap in gaps)
            {
                for (int i = gap; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    int j = i;
                    compares++;
                    while (j >= gap && arr[j - gap] > temp)
                    {
                        compares++;
                        swaps++;
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }
                    arr[j] = temp;
                    if(j != i)  
                        swaps++;
                }
            }

            Console.WriteLine("Shell sort compares: " + compares);
            Console.WriteLine("Shell sort swaps: " + swaps);
        }
        public static void BubbleSort(int[] arr)
        {
            long compares = 0;
            long swaps = 0;
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    compares++;
                    if (arr[j] > arr[j + 1])
                    {
                        swaps++;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Default bubble sort compares: " + compares);
            Console.WriteLine("Default bubble sort swaps: " + swaps);
        }

        public static void ModifiedBubbleSort(int[] arr)
        {
            int temp;
            bool swapped;
            long compares = 0;
            long swaps = 0;
            for (int i = 0; i < arr.Length - 1; i++) {
                swapped = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    compares++;
                    if (arr[j] > arr[j + 1])
                    {
                        swaps++;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
            Console.WriteLine("Modified bubble sort compares: " + compares);
            Console.WriteLine("Modified bubble sort swaps: " + swaps);
        }
        public static void Main(string[] args)
        {
            
        }
    }
}
