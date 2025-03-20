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
* Classes (Inheritance, Polymorphism, abstraction) *done
*/

namespace PracticeApp02
{
    
    class Program
    {
        delegate void MyMessages(string str);

        public interface IDrink 
        {
            public void DrinkCofee();
        }

        public void DrinkAlotOfCofee(IDrink drink) 
        {
            drink.DrinkCofee();
        }

        private class Person 
        {
            public int Id { get; set; }

            public virtual void Display()
            {
                Console.Clear();
                Console.WriteLine("Display Person Data");
                Console.WriteLine("-------------------");
            }

            ~Person() 
            {
                Console.WriteLine("Person Data Deconstructed");
            }

        }

        private class Customer : Person, IDrink
        {
            public int CustomerId { get; set; }

            public void DrinkCofee() 
            {
                Console.WriteLine("Customer drinking cofee");
            }
        }

        private class Employee : Person, IDrink
        {
            //public string name;
            //private int id = 0;
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

            //public void HeaderDisplay()
            //{
            //    Console.Clear();
            //    Console.WriteLine("-------------");
            //    Console.WriteLine("Employee Data");
            //    Console.WriteLine("-------------");
            //}

            public override void Display()
            {
                Console.Clear();
                Console.WriteLine("Display Employee Data");
                Console.WriteLine("---------------------");
            }

            public void DrinkCofee() 
            {
                Console.WriteLine("Employee drinking cofee");
            }
        }


        public void MyTextMessages(string str)
        {
            Console.WriteLine($"My test text: {str}");
        }

        static void Main()
        {
            string country = "";
            bool isMinor = false;
            bool isCity = false;
            string[] cities = { "Joburg", "New York", "Sydney" };

            Employee employee = new Employee();
            Person person = new Person();
            Customer customer = new Customer();

            employee.DrinkCofee();
            customer.DrinkCofee();

            Program program = new Program();
            program.DrinkAlotOfCofee(customer);
            program.DrinkAlotOfCofee(employee);

            MyMessages myMessages = MyTextMessages;
            

            ////Polymorphism test
            //employee.Id = 1;
            //person.Id = 2;
            //Console.WriteLine($"Employee ID: {employee.Id}");
            //Console.WriteLine($"Person ID: {person.Id}");
            //employee.Id = person.Id;
            //Console.WriteLine($"NEW Employee ID: {employee.Id}");

            /*
            Console.WriteLine("Please enter Employee name: ");
            employee.Name = Console.ReadLine();

            Console.WriteLine("Please enter Email address: ");
            employee.Email = Console.ReadLine();

            Console.WriteLine("Please enter Age: ");
            employee.Age = int.Parse(Console.ReadLine());

            if (employee.Age < 18)
                isMinor = true;
            else
                isMinor = false;

            Console.WriteLine("Please enter City: ");
            employee.City = Console.ReadLine();

            //This is not working as expected
            foreach (string city in cities)
            {
                if (employee.City == city)
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

            switch (employee.City)
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
            employee.WorkInOfficeDay = Console.ReadLine();

            Console.WriteLine("Please enter the month you work in the office: ");
            employee.WorkInOfficeMonth = Console.ReadLine();

            //employee.HeaderDisplay();
            //person.Display();
            employee.Display();
            Console.WriteLine($"Employee ID: {employee.Id}");
            Console.WriteLine($"Employee name: {employee.Name}");
            Console.WriteLine($"Email address: {employee.Email}");
            Console.Write($"Age: {employee.Age}, ");
            Console.WriteLine(isMinor ? "Employee is a minor" : "Employee is an adult");
            Console.Write($"City: {employee.City}, {country} - (");
            Console.WriteLine(isCity ? "City is valid)" : "City is invalid)");

            foreach (string day in Enum.GetNames(typeof(DaysOfWeek)))
            {
                //Console.WriteLine(day);
                if (day == employee.WorkInOfficeDay)
                {
                    Console.WriteLine($"Employee works in the office on {day}");
                }
            }

            foreach (string month in Enum.GetNames(typeof(MonthsOfYear)))
            {
                //Console.WriteLine(month);
                if (month == employee.WorkInOfficeMonth)
                {
                    Console.WriteLine($"Employee works in the office in {month}");
                }
            }

            ////Two dimensional array with workinoffice day and month using nested loops
            //string[,] workInOffice = new string[7, 12];

            //Console.WriteLine("Work in office days and months");
            //for (int i = 0; i < 7; i++)
            //{
            //    for (int j = 0; j < 12; j++)
            //    {
            //        workInOffice[i, j] = $"{(DaysOfWeek)i} - {(MonthsOfYear)j}";
            //        Console.WriteLine(workInOffice[i, j]);
            //    }
            //}
            */
        }
    }
}
