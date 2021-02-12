using My_Implement.IntroductionToAlgorithms;
using My_Implement.SelectionSort;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GrokkinAlgorithemsTest
{
    public class SelectionSortTest
    {
        [Fact]
        public void IsEqual_GenericSelectionSort_returnTrue()
        {
            //Act
            var index = new Random();
            var lst = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                lst.Add(index.Next(100));
            }
            //Arrange
            var result = SelectionSort.GenericSelectionSort(lst);
            var Expected = lst.OrderBy(x=>x).ToList();
            //Assert
            Assert.Equal(Expected, result);
        }

        [Fact]
        public void IsEqual_GenericSelectionSortTypeOfString_returnTrue()
        {
            //Act
            var lst = new List<string>();
            var guid = new Guid();
            for (int i = 0; i < 20; i++)
            {
                lst.Add(guid.ToString());
            }
            //Arrange
            var result = SelectionSort.GenericSelectionSort(lst);
            var Expected = lst.OrderBy(x => x).ToList();
            //Assert
            Assert.Equal(Expected, result);
        }

        [Fact]
        public void IsEqual_selectionSort_returnTrue()
        {
            //Act
            var index = new Random();
            var lst = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                lst.Add(index.Next(100));
            }
            //Arrange
            var Result = SelectionSort.selectionSort(lst);
            var Expected = lst.OrderBy(x => x).ToArray();
            //Assert
            Assert.Equal(Expected, Result);
        }




    }
}
