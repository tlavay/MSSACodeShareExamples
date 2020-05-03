using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace CodeShare.Examples
{
    public class HashTableExample
    {
        public void Hashing()
        {
            var person1 = new Person("Tyler", 30);
            var person2 = new Person("Tyler", 30);
            var person3 = new Person("Dawid", 23);

            if (person1.Equals(person2))
            {
                Console.WriteLine("They're the same!");
            }

            if (person1 != person3)
            {
                Console.WriteLine("They're not the same!");
            }
        }

        private class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
        }
    }
}
