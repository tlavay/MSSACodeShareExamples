using CodeShare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace CodeShare.Examples
{
    internal static class LinqExamples
    {
        //Delegates
        //  Can be thought of as ways to pass methods as parameters
        //  Docs.com "Delegates are used to pass methods as arguments to other methods."
        //  Link: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/

        //Defined delegates
        //Funcs
        //  It has zero or more input parameters and one out parameter. The last parameter is considered as an out parameter.
        //Actions
        //  Action delegate doesn't return a value
        //Predicates
        //  A predicate delegate methods must take one input parameter and return a boolean - true or false

        //public static bool Any2<T>(this List<T> tInputs, Predicate<T> predicate)
        //{
        //    foreach (var tInput in tInputs)
        //    {
        //        if (predicate(tInput))
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}

        //public static IEnumerable<CityInfo> Where2(this IEnumerable<CityInfo> cityInfos, Predicate<CityInfo> predicate)
        //{
        //    foreach (var cityInfo in cityInfos)
        //    {
        //        if (predicate(cityInfo))
        //        {
        //            yield return cityInfo;
        //        }
        //    }
        //}
    }
}
