/*
To implement and practice:
--Beginner------------------
* Variables *done
* Data types *done
* If statements *done
* Switch *done
* functions *done
* Arrays *done
* Lists *done
* Loops *done
* Class *done
* Static *done
* Access modifiers *done
* --Intermediate--------------------
* Enums *done
* Properties *done
* Multidimensional arrays *done
* Nested loops *done
*/

namespace PracticeApp02
{
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    enum MonthsOfYear
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class Program
    {
        private class Customer
        {
            //public string name;
            public string Name { get; set; }

            private string email;
            public string Email
            {
                get
                {
                    return email;
                }
                set
                {
                    if (value.Contains("@"))
                        email = value;
                    else
                    {
                        email = "Invalid email";
                        Console.WriteLine("Email is invalid");
                    }
                }
            }

            private int age;
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    if (value > 0)
                    {
                        age = value;
                    }
                    else
                    {
                        age = 0;
                        Console.WriteLine("Age cannot be zero or negative");
                    }
                }
            }
            public string City { get; set; }

            public string WorkInOfficeDay { get; set; }
            public string WorkInOfficeMonth { get; set; }

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
            customer.Name = Console.ReadLine();

            Console.WriteLine("Please enter Email address: ");
            customer.Email = Console.ReadLine();

            Console.WriteLine("Please enter Age: ");
            customer.Age = int.Parse(Console.ReadLine());

            if (customer.Age < 18)
                isMinor = true;
            else
                isMinor = false;

            Console.WriteLine("Please enter City: ");
            customer.City = Console.ReadLine();

            //This is not working as expected
            foreach (string city in cities)
            {
                if (customer.City == city)
                    isCity = true;
                else
                    isCity = false;
            }

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    if (customer.City == cities[i])
            //        isCity = true;
            //    else
            //        isCity = false;
            //}

            switch (customer.City)
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

            Console.WriteLine("Please enter the day you work in the office: ");
            customer.WorkInOfficeDay = Console.ReadLine();

            Console.WriteLine("Please enter the month you work in the office: ");
            customer.WorkInOfficeMonth = Console.ReadLine();

            customer.HeaderDisplay();

            Console.WriteLine($"Customer name: {customer.Name}");
            Console.WriteLine($"Email address: {customer.Email}");
            Console.Write($"Age: {customer.Age}, ");
            Console.WriteLine(isMinor ? "Customer is a minor" : "Customer is an adult");
            Console.Write($"City: {customer.City}, {country} - (");
            Console.WriteLine(isCity ? "City is valid)" : "City is invalid)");

            foreach (string day in Enum.GetNames(typeof(DaysOfWeek)))
            {
                //Console.WriteLine(day);
                if (day == customer.WorkInOfficeDay)
                {
                    Console.WriteLine($"Customer works in the office on {day}");
                }
            }

            foreach (string month in Enum.GetNames(typeof(MonthsOfYear)))
            {
                //Console.WriteLine(month);
                if (month == customer.WorkInOfficeMonth)
                {
                    Console.WriteLine($"Customer works in the office in {month}");
                }
            }

            //Two dimensional array with workinoffice day and month using nested loops
            string[,] workInOffice = new string[7, 12];

            Console.WriteLine("Work in office days and months");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    workInOffice[i, j] = $"{(DaysOfWeek)i} - {(MonthsOfYear)j}";
                    Console.WriteLine(workInOffice[i, j]);
                }
            }
        }
    }
}
