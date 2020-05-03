using CodeShare.Examples;
using CodeShare.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeShare
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashExample = new HashTableExample();
            hashExample.Hashing();
        }
    }
}
