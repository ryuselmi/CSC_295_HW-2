namespace CSC_295_HW_2
{
    internal class Program
    {
        public static int findSingle(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                // Check mid is even, if it's odd, decrement by 1 to make it even
                if (mid % 2 == 1)
                {
                    mid--;
                }

                // Check if the pair is broken
                if (arr[mid] != arr[mid + 1])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 2;
                }
            }

            return arr[left];
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2, 2, 5, 5, 6, 6, 7, 8, 8, 9, 9 };
            int soloElement = findSingle(arr);
            Console.WriteLine($"The element {soloElement} appears only once.");

            Console.ReadKey();
        }
    }
}