using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----->  GENERICS  <-----\n");

            List<string> cities1 = new List<string>();
            cities1.Add("Ankara");
            cities1.Add("İstanbul");
            cities1.Add("Kastamonu");
            Console.WriteLine("Default number of elements in the list = " + cities1.Count);

            MyList<string> cities2 = new MyList<string>();
            cities2.Add("Ankara");
            cities2.Add("İstanbul");
            cities2.Add("Kastamonu");
            Console.WriteLine("Number of elements in our own list = " + cities2.Count);

            Console.ReadLine();
        }
    }

    // Generic class
    class MyList<T> 
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }
    }
}