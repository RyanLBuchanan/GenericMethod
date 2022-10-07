namespace GenericMethod
{
    internal class GenericMethodTest
    {
        static void Main(string[] args)
        {
            // Create arrays of int, double and char
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O', };

            Console.WriteLine("Array intArray contains:");
            DisplayArray(intArray);
            Console.WriteLine("Array doubleArray contains:");
            DisplayArray(doubleArray);
            Console.WriteLine("Array charArray contains:");
            DisplayArray(charArray);
        }

        // Output array of all types
        private static void DisplayArray<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
    }
}