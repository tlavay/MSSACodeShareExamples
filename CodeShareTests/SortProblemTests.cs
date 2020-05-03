using CodeShare.Examples;
using System;
using System.Linq;
using Xunit;

namespace CodeShareTests
{
    public class SortProblemTests
    {
        [Fact]
        public void ArrayHelper_RemoveDuplicates_WithACollectionOfIntsContainingDuplicate_ShouldRemoveAllDuplicates()
        {
            //Arrange

            //Act
            var nonDuplicates = ArrayHelper.RemoveDuplicates(unsortedInts);

            //Assert
            var temp = 0;
            foreach (var item in nonDuplicates)
            {
                Assert.True(item <= temp);
                temp = item;
            }
        }
    }
}
