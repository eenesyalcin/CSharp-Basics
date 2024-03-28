using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->  CONSTRUCTORS  <-----\n");

            Customer customer1 = new Customer() { Id = 1, FirstName = "Enes", LastName = "YALÇIN", City = "Karabük" };
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Sena Betül";
            customer2.LastName = "YAZICIOĞLU";
            customer2.City = "İstanbul";

            Customer customer3 = new Customer(3, "Muhittin", "YALÇIN", "Kastamonu");

            Console.ReadLine();
        }
    }

    class Customer
    {
        // Default constructor
        public Customer()
        {
            Console.WriteLine("Default constructor worked!");
        }

        // Constructor with parameters
        public Customer(int id, string firstName, string lastName, string city)
        {
            City = city;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Console.WriteLine("\nParameterized constructor worked!");
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}