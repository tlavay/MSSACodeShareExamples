using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace CodeShare.Examples
{
    internal sealed class Example
    {
        //1. Questions
        //2. What is a reference type?
        //3. What is a value type?
        //4. What is the difference
        //5. Anagram Problem

        public void ExecuteExamples()
        {
            ////Stack and Queue Examples
            //StackExample();
            //QueueExample();

            ////Value type examples
            //var value = 5;
            //value = MultiplyBy23(value);
            //Console.WriteLine($"Pass by value: {value}");
            //Console.ReadLine();
            //PassValueTypeByReference(ref value);
            //Console.WriteLine($"Pass value type by reference: {value}");
            //Console.ReadLine();

            ////Reference Type
            //var person = new Person();
            //person.Name = "Tyler La Vay";
            //person = PopulatePerson(person);
            //Console.WriteLine(person);
            //Console.ReadLine();

            ////String example
            var exampleString = "Tyler is ";
            //PassReferenceTypeStringExample(exampleString);
            //Console.WriteLine(exampleString);
            //Console.ReadLine();

            //////Return reference types
            exampleString = StringExample(exampleString);
            Console.WriteLine(exampleString);
            Console.ReadLine();
        }

        #region Stack and Queue
        private void StackExample()
        {
            //LIFO
            var items = new Stack<string>();
            items.Push("Item 1");
            items.Push("Item 2");
            items.Push("Item 3");
            items.Push("Item 4");
            items.Push("Item 5");

            Console.WriteLine("Stack Example");
            Console.WriteLine("What is going to happen?");
            Console.ReadLine();
            while (items.Count > 0)
            {
                Console.WriteLine(items.Pop());
                Console.WriteLine(items.Count);
                Console.ReadLine();
            }
        }

        private void QueueExample()
        {
            //FIFO
            var items = new Queue<string>();
            items.Enqueue("Item 1");
            items.Enqueue("Item 2");
            items.Enqueue("Item 3");
            items.Enqueue("Item 4");
            items.Enqueue("Item 5");

            Console.Clear();
            Console.WriteLine("Queue Example");
            Console.WriteLine("What is going to happen?");
            Console.ReadLine();
            while (items.Count > 0)
            {
                Console.WriteLine(items.Dequeue());
                Console.WriteLine(items.Count);
                Console.ReadLine();
            }
        }

        #endregion

        #region Pass Example

        private int MultiplyBy23(int value)
        {
            return value * 23;
        }
        private void PassValueTypeByReference(ref int value)
        {
            value = value * 2;
        }
        private Person PopulatePerson(Person person)
        {
            person.Age = 30;
            person.Job = "Microsoft Dev";
            return person;
        }

        private void PassReferenceTypeStringExample(string exampleString)
        {
            exampleString = exampleString + "30 years old.";
        }

        private string StringExample(string exampleString)
        {
            return exampleString + "30 years old.";
        }


        #endregion
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Job: {Job}";
        }
    }
}
