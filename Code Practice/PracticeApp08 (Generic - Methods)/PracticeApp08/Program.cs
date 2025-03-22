/*
 * Generic Methods *Done
 */

namespace PracticeApp08
{
    class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a; 
            a = b; 
            b = temp;
        }

        static void Main()
        {
            // Example with int
            int num01 = 12;
            int num02 = 24;
            Console.WriteLine($"Before swap - Num01: {num01}, Num02: {num02}");

            Swap(ref num01, ref num02);
            Console.WriteLine($"After swap - Num01: {num01}, Num02: {num02}");

            // Example with strings
            string str1 = "Hello", str2 = "World";
            Console.WriteLine($"Before Swap: str1 = {str1}, str2 = {str2}");

            Swap(ref str1, ref str2);
            Console.WriteLine($"After Swap: str1 = {str1}, str2 = {str2}");
        }
    }
}
