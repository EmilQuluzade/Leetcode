namespace Leetcode_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] front = { 1, 2, 3, 4 };
            int[] back = { 5, 6, 7, 8 };
            int[] combined = front.Concat(back).ToArray();
            Quicksort(combined, 0, combined.Length - 1);

            Console.WriteLine("Sorted array:");
            foreach (var num in combined)
            {
                Console.Write(num + " ");
            }
        }

        static void Quicksort(int[] combined, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(combined, left, right);
                Quicksort(combined, left, pivotIndex - 1);
                Quicksort(combined, pivotIndex + 1, right);
            }
        }

        static int Partition(int[] combined, int left, int right)
        {
            int pivot = combined[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (combined[j] < pivot)
                {
                    i++;
                    Swap(combined, i, j);
                }
            }

            Swap(combined, i + 1, right);
            return i + 1;
        }

        static void Swap(int[] combined, int i, int j)
        {
            int temp = combined[i];
            combined[i] = combined[j];  
            combined[j] = temp;
        }
    }
}
