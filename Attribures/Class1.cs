using System;

namespace Attribures
{
    public class Class1
    {
        Customer customer = new Customer { Id = 1, LastName = "Hilal", Age = 25 };
        CustomerDal customerDal = new CustomerDal();
        customerDal.Add(customer);
        Console.ReadLine();


    }
    class Customer
    {
        public int Id { get; set; }
        // [RequiredProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


    }
    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
}
