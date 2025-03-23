/*
 * IEnumerable
 */

namespace PracticeApp10
{
    class Program
    {
        static void Main()
        {
            // Creating a list of strings
            IEnumerable<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

            // Using foreach to iterate over the collection
            foreach (string fruit in fruits) 
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
