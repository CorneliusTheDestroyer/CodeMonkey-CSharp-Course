/*
 * Generics with Interfaces *Done
 */

namespace PracticeApp09
{
    // Define an interface that all entities must implement
    public interface IEntity
    {
        int Id { get; set; }
    }

    // A generic repository class that only works with types implementing IEntity
    public class Repository<T> where T : IEntity
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
            Console.WriteLine($"Item added with ID of {item.Id}");
        }

        public T GetById(int id) 
        {
            return _items.Find(item => item.Id == id);
        }
    }

    // Example entity implementing IEntity
    public class Product : IEntity 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // Example another entity implementing IEntity
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Create a repository for Product entities
            Repository<Product> productRepository = new Repository<Product>();

            Product product01 = new Product { Id = 1, Name = "Laptop" };
            Product product02 = new Product { Id = 2, Name = "Desktop" };

            productRepository.Add(product01);
            productRepository.Add(product02);

            Product foundProduct = productRepository.GetById(2);
            Console.WriteLine($"Found product: {foundProduct.Name}");

            // Create a repository for Customer entities
            Repository<Customer> customerRepository = new Repository<Customer>();

            Customer customer1 = new Customer { Id = 1, Name = "Steven" };
            Customer customer2 = new Customer { Id = 2, Name = "Bill" };

            customerRepository.Add(customer1);
            customerRepository.Add(customer2);

            Customer foundCustomer = customerRepository.GetById(1);
            Console.WriteLine($"Found customer: {foundCustomer.Name}");
        }
    }
}
