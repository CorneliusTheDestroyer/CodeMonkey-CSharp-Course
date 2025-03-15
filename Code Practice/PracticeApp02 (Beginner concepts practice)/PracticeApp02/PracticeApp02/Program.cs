/*
To implement and practice:
--------------------------
* If statements *done
* Switch *done
* Arrays *done
* Loops *done
* Class *done
* Static *done
* Access modifiers *done
*/

namespace PracticeApp02
{
    class Program
    {
        private class Customer
        {
            public string name;
            public string email;
            public int age;
            public string city;

            public Customer()
            {
                name = "Unknown";
                email = "Unknown";
                age = 0;
                city = "Unknown";

                Console.WriteLine($"Created customer: {name}");
            }

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
            string country = "";
            bool isMinor = false;
            bool isCity = false;
            string[] cities = { "Joburg", "New York", "Sydney" };

            Customer customer = new Customer();

            Console.WriteLine("Please enter Customer name: ");
            customer.name = Console.ReadLine();

            Console.WriteLine("Please enter Email address: ");
            customer.email = Console.ReadLine();

            Console.WriteLine("Please enter Age: ");
            customer.age = int.Parse(Console.ReadLine());

            if (customer.age < 18)
                isMinor = true;
            else
                isMinor = false;

            Console.WriteLine("Please enter City: ");
            customer.city = Console.ReadLine();

            for (int i = 0; i < cities.Length; i++)
            {
                if (customer.city == cities[i])
                    isCity = true;
                else
                    isCity = false;
            }

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
                    country = "Unknown";
                    break;
            }

            customer.HeaderDisplay();

            Console.WriteLine($"Customer name: {customer.name}");
            Console.WriteLine($"Email address: {customer.email}");
            Console.Write($"Age: {customer.age}, ");
            Console.WriteLine(isMinor ? "Customer is a minor" : "Customer is an adult");
            Console.Write($"City: {customer.city}, {country} - (");
            Console.WriteLine(isCity ? "City is valid)" : "City is invalid)");
        }
    }
}
