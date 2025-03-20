/*

* Delegates *Done
* Lambda / annonoumous fucntion *Done
* multi - cast Delegates and Lambda *Done
* Action / Func *Done

*/

namespace PracticeApp03
{
    class Program
    {
        delegate void MyMessage(string str1);
        delegate void MyMessages(string str1, string str2);

        //static void MyTextMessages(string str) 
        //{
        //    Console.WriteLine($"My text messages: {str}");
        //}

        //static void MyWAMessages(string str) 
        //{
        //    Console.WriteLine($"My WA messages: {str}");
        //}
        static void Main()
        {
            MyMessage myMessage = str1 => {
                Console.WriteLine($"My WA messages: {str1}");
            };

            myMessage += str1 => Console.WriteLine($"My second WA messages: {str1}");

            MyMessages myMessages = (str1, str2) => {
                Console.WriteLine($"My text messages: {str1}, {str2}");
            };

            Action<int, int> action = (number01, number02) => Console.WriteLine($"Numbers one: {number01} and two: {number02}");

            Func<int, int> func = num => num*2;

            //MyMessages myMessages = MyTextMessages;

            myMessage("Hello, my first test");
            myMessages("Hello, testing", "....for the last time");

            Console.WriteLine("-------------------------------");

            action(32, 12);

            Console.WriteLine($"New number: {func(2)}");
            

            //myMessages += MyWAMessages;

            //myMessages("Hello, testing again...");

        }
    }
}
