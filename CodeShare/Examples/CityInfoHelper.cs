using System;
using System.Collections.Generic;
using System.Text;

namespace CodeShare.Examples
{
    public static class CityInfoHelper
    {
        public static bool CityIsMaryland(string stateName)
        {
            return stateName?.ToLower() == "maryland";
        }
    }
}
