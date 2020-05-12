using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CodeShare.Examples
{
    public static class GenericExample
    {
        public static bool Any2<TInput>(this IEnumerable<TInput> collection, Predicate<TInput> predicate)
        {
            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
