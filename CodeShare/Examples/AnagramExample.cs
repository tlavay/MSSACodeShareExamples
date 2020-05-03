using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeShare.Examples
{
    class AnagramExample
    {
        //str1 = MicrosoftAzure
        //str2 = AzureMicrosoft
        public bool IsAnagram(string str1, string str2)
        {
            //Do easy check here to return false
            var ch1 = str1.ToLower().ToCharArray();
            var ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            var val1 = str1.ToString();
            var val2 = str2.ToString();

            if (val1 == val2)
            {
                return true;
            }

            return false;
        }
    }
}
