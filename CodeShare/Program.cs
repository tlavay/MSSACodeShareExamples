using CodeShare.Examples;
using CodeShare.Examples.Exceptions;
using CodeShare.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace CodeShare
{
    class Program
    {
        static void Main(string[] args)
        {
            //var names = new List<string>()
            //{
            //    "Tyler",
            //    "Cody",
            //    "Daniel",
            //    "Denis",
            //    "Dawid"
            //};

            CountTo10(0);
        }

        private static void CountTo10(int count)
        {
            if (count == 10)
            {
                return;
            }

            Console.WriteLine(count);
            var newCount = count + 1;
            CountTo10(newCount);
        }
    }
}
