using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYMBIOSIS_Assignment2
{
    class Person : IComparable<Person>
    {
       
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public int CompareTo(Person other)
        {
            if (other == null) return 0 ;
            if (this.Age > other.Age) return 1;
            if (this.Age < other.Age) return -1;
            else return 0;
        }

        public static void Main(string[] args)
        {
         
            Person[] people = new Person[3];
            people[0] = new Person("Ravindra", 20);
            people[1] = new Person("Ajay", 35);
            people[2] = new Person("Shubham", 10);
            people[3] = new Person("Akash", 23);
            Console.WriteLine("Before sorting:");
            foreach (var person in people)
            {
                person.PrintDetails();
            }
            Array.Sort(people);

            Console.WriteLine("\nAfter sorting:");
            foreach (var person in people)
            {
                person.PrintDetails();
            }
            
        }
    }
}
