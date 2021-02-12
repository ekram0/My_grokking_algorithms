using My_Implement.IntroductionToAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GrokkinAlgorithemsTest
{
    public class BinarySearchTest
    {
        [Fact]
        public void IsEqual_ValueInRange_returnTrue()
        {
            //Act
            var data = Enumerable.Range(0,10).ToArray();
            var item = 3;
            //Arrange
            var result = BinarySearch.binarySearch(data, item);
            var Expected = Array.FindIndex(data, x => x == item);
            //Assert
            Assert.Equal(Expected, result);
        }
        [Fact]
        public void IsEqual_ValueOutRange_returnTrue()
        {
            //Act
            var data = Enumerable.Range(5, 100).ToArray();
            var item = 804;
            //Arrange
            var Actual = BinarySearch.binarySearch(data, item);
            var Expected = Array.FindIndex(data, x => x == item);
            //Assert
            Assert.Equal(Expected, Actual);
        }




    }
}
