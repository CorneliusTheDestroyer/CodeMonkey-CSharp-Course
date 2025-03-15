/*
To implement and practice:
--------------------------
* If statements
* Switch
* Arrays
* Loops
* Class
* Static
* Access modifiers
*/

namespace PracticeApp02
{
    class Program
    {
        private class Customer
        {
            private int id;
            public string name;
            public string email;
            public int age;
            public string city;

            public void HeaderDisplay()
            {
                Console.Clear();
                Console.WriteLine("-------------");
                Console.WriteLine("Customer Data");
                Console.WriteLine("-------------");
            }
        }
        static void Main()
        {
            string country;

            Customer customer = new Customer();

            Console.WriteLine("Please enter Customer name: ");
            customer.name = Console.ReadLine();

            Console.WriteLine("Please enter Email address: ");
            customer.email = Console.ReadLine();

            Console.WriteLine("Please enter Age: ");
            customer.age = int.Parse(Console.ReadLine());

            switch (customer.city)
            {
                case "Joburg":
                    country = "South Africa";
                    break;
                case "New York":
                    country = "America";
                    break;
                case "Sydney":
                    country = "Australia";
                    break;
                default:
                    break;
            }

            customer.HeaderDisplay();
            Console.WriteLine($"Customer name: {customer.name}");
            Console.WriteLine($"Email address: {customer.email}");
            Console.WriteLine($"Age: {customer.age}");
        }
    }
}
