using CodeShare.Examples.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace CodeShare.Examples
{
    public static class ArrayHelper
    {
        //var unsortedInts = new int[] { 751, 751, 684, 15, 355, 17, 768, 7, 47, 927, 889, 140, 175, 767, 344, 623, 135, 152, 803, 865, 859, 768,
        //        993, 465, 511, 50, 812, 534, 954, 54, 462, 843, 680, 94, 290, 256, 507, 1, 211, 471, 28, 245, 36, 636, 437, 784, 646, 938, 765, 494,
        //        754, 39, 919, 171, 415, 242, 758, 218, 504, 304, 205, 233, 52, 992, 464, 46, 460, 80, 476, 13, 115, 134, 940, 332, 836, 613, 425,
        //        356, 27, 726, 404, 874, 769, 460, 299, 423, 924, 509, 678, 47, 498, 288, 496, 907, 265, 795, 192, 43, 172, 391, 324, 566, 461, 676,
        //        378, 620, 98, 587, 334, 802, 817, 401, 191, 778, 900, 331, 464, 592, 692, 40, 122, 950, 402, 428, 590, 827, 637, 33, 66, 41, 420,
        //        381, 183, 635, 401, 768, 412, 92, 81, 679, 325, 336, 13, 876, 230, 96, 96, 718, 7, 933, 330, 600, 350, 131, 269, 373, 164, 32, 86,
        //        551, 982, 64, 520, 292, 381, 435, 218, 555, 376, 62, 919, 372, 511, 13, 715, 785, 776, 525, 198, 493, 730, 919, 25, 13, 711, 820,
        //        30, 768, 366, 27, 673, 379, 5, 530, 768, 260, 816, 882, 495, 794, 878 };
        public static IEnumerable<int> RemoveDuplicates(int[] unsortedInts)
        {
            var sortedInts = new List<int>();
            foreach (var unsortedInt in unsortedInts)
            {
                if (Contains(sortedInts, unsortedInt))
                {
                    sortedInts.Add(unsortedInt);
                }
            }

            return sortedInts;
        }

        private static bool Contains(IEnumerable<int> ints, int input)
        {
            foreach (var item in ints)
            {
                if (item == input)
                {
                    return true;
                }
            }

            return false;
        }

        //private static int[] Sort(int[] unsortedInts)
        //{
        //    // Todo: sort
        //    return new int[0];
        //}

        private static int[] RemoveDups(int[] ints)
        {
            // Todo: Remove duplicates
            return new int[0];
        }

        public static void HitBoss(WeaponBase weapon)
        {
            var random = new Random();
            var damage = weapon.DoSomeDamage(random.Next(0, 100));
        }
    }
}
