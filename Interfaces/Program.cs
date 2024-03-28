using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->  INTERFACES  <-----\n");

            // IPersonManager personManager = new IPersonManager();  --->  (False) = Interface'ler new yapılamazlar.
            IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();
            IPersonManager internManager = new InternManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Add(employeeManager);
            projectManager.Add(internManager);
            // projectManager.Add(new CustomerManager());  --->  Yukarıdaki new yapma işlemlerini yapmadan bu şekilde de yapılabilir.

            Console.ReadLine();
        }
    }

    interface IPersonManager
    {
        // Unimplemented operation
        void Add();
        void Update();
    }

    /*
        Classes    --->  Inherits
        Interface  --->  Implements
    */
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // Müşteri ekleme kodları
            Console.WriteLine("Customer added!");
        }

        public void Update()
        {
            // Müşteri güncelleme kodları
            Console.WriteLine("Customer updated!");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // Personel ekleme kodları
            Console.WriteLine("Employee added!");
        }

        public void Update()
        {
            // Personel güncelleme kodları
            Console.WriteLine("Employee updated!");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            // Stajyer ekleme kodları
            Console.WriteLine("Intern added!");
        }

        public void Update()
        {
            // Stajyer güncelleme kodları
            Console.WriteLine("Intern updated!");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}