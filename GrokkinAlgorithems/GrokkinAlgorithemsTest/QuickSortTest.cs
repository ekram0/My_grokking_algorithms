using My_Implement.QuickSort;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GrokkinAlgorithemsTest
{
    public class QuickSortTest
    {
        [Fact]
        public void IsEqual_SumByRecursion_returnTrue()
        {
            //Act
            var index = new Random();
            var lst = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                lst.Add(index.Next(100));
            }
            //Arrange
            var result = QuickSort.SumByRecursion(lst);
            var Expected = lst.Sum();
            //Assert
            Assert.Equal(Expected, result);
        }

        [Fact]
        public void IsEqual_MaxValueByRecursion_returnTrue()
        {
            //Act
            var index = new Random();
            var lst = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                lst.Add(index.Next(100));
            }
            //Arrange
            var result = QuickSort.MaxValueByRecursion(lst);
            var Expected = lst.Max();
            //Assert
            Assert.Equal(Expected, result);
        }

        [Fact]
        public void IsEqual_CountByRecursion_returnTrue()
        {
            //Act
            var index = new Random();
            var lst = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                lst.Add(index.Next(100));
            }
            //Arrange
            var Result = QuickSort.CountByRecursion(lst);
            var Expected = lst.Count;
            //Assert
            Assert.Equal(Expected, Result);
        }

        [Fact]
        public void IsEqual_GetGCD_returnTrue()
        {
            var Result = QuickSort.GetGCD(1680, 640);
            Assert.Equal(80, Result);
        }

        [Fact]
        public void IsEqual_quickSort_returnTrue()
        {
            //Act
            var index = new Random();
            var lst = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                lst.Add(index.Next(100));
            }
            //Arrange
            var Result = QuickSort.quickSort(lst).ToList();
            var Expected = lst;
            Expected.Sort();
            //Assert
            Assert.Equal(Expected, Result);
        }



    }
}
