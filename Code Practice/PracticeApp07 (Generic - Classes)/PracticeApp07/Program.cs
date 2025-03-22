/*
 * Generic Classes *Done
 */

namespace PracticeApp07
{
    class Program
    {
        public class Box<T>
        {
            public T value;

            public void Add(T value)
            { 
                this.value = value; 
            }

            public T Get()
            {
                return value;
            }
        }

        static void Main()
        {
            // Using the generic class with an int
            Box<int> box = new Box<int>();
            box.Add(1);

            Console.WriteLine(box.Get());

            // Using the generic class with a string
            Box<String> box2 = new Box<String>();
            box2.Add("a");

            Console.WriteLine(box2.Get());
        }
    }
}
