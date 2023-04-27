using System;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer { Id = 1, LastName = "Hilal", Age = 25 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();


        }
        [ToTable("Customers")]
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
            [Obsolete("Don't use Add method,insteade use add method")]
            public void Add(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }
            public void AddNew(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }
        }
        [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field,AllowMultiple =true)]
        class RequiredPropertyAttribute:Attribute
        {

        }
        [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)]
        class ToTableAttribute : Attribute//Attributelere parametre de yollanır. Ama onu constructor ile set ederiz
        {
            private string _tableName;

            public ToTableAttribute(string tableName)
            {
                _tableName = tableName; 
            }
        }
    }
}
