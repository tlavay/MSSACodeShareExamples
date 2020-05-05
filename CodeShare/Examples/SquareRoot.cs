using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CodeShare.Examples
{
    public static class SquareRoot
    {
        public static double SqrtRoot2(double input)
        {
            for (var i = 0; i < input; i++)
            {
                if (i * i == input)
                {
                    return i;
                }

                if (i * i > input)
                {
                    //then decimals
                    //maybe a loop???
                }
            }

            throw new Exception("Math always has answers!");
        }
    }
}
