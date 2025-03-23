/*
 * Custom IEnumerable
 */

using System.Collections;

namespace PracticeApp11
{
    class Program
    {
        class FruitCollection : IEnumerable<string>
        {
            private List<string> fruits = new List<string>();

            public void Add(string fruit) 
            {
                fruits.Add(fruit);
            }

            public IEnumerator<string> GetEnumerator()
            {
                foreach (string fruit in fruits) 
                { 
                    yield return fruit; 
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
        static void Main()
        {
            FruitCollection fruits = new FruitCollection();

            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Peach");
            fruits.Add("Orange");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

        }
    }
}
