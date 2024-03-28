using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->  REFERNCE TYPES  <-----\n");

            ValueTypes();
            ReferenceTypes();
            RefernceTypesWithClasses();

            Console.ReadLine();
        }

        private static void ValueTypes()
        {
            // Value Types ---> int, decimal, float, enum, boolean...
            int number1 = 10;
            int number2 = 20;

            number1 = number2;

            number2 = 100;

            Console.WriteLine("number1 = " + number1 + "\n");
        }

        private static void ReferenceTypes()
        {
            // Reference Types ---> Arrays, Classes, Interfaces... 
            int[] numbers1 = new int[] { 1, 2, 3 };
            int[] numbers2 = new int[] { 10, 20, 30 };

            numbers1 = numbers2;

            numbers1[0] = 100;

            Console.WriteLine("numbers1[0] = " + numbers1[0]);
        }

        private static void RefernceTypesWithClasses()
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Enes";
            person2 = person1;
            person1.FirstName = "Sena Betül";
            Console.WriteLine("\nperson2.FirstName = " + person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Sıla";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Muhittin";

            // customer = employee;  --->  (False) = Farklı tipler olduğu için birbirlerine atanamazlar.
            Person person3 = customer;
            customer.FirstName = "Elif";
            Console.WriteLine("person2.FirstName = " + person3.FirstName);

            Console.WriteLine("(Customer)person3.CreditCardNumber = " + ((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(person1);
            personManager.Add(customer);
            personManager.Add(employee);
        }
    }

    // Base Class : Person
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public string EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName + " user added!");
        }
    }
}