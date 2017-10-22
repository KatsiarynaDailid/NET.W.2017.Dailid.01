using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library.Tests
{
    [TestClass]
    public class SortTests
    {
        [DataRow(new[] { 3, 2, 1, 5, 4 }, new[] { 1, 2, 3, 4, 5 })]
        [DataRow(new[] { 3, 58, 6, 35, 4, 58 }, new[] { 3, 4, 6, 35, 58, 58 })]
        [DataRow(new[] {3}, new[] {3})]
        [DataRow(new[] { 2, 4, -8, 9, 6, -3}, new[] { -8,-3, 2, 4, 6, 9})]
        [DataTestMethod]
        public void QuickSort_UnsortedArray_SortedArray(int[] unsortedArray, int[] sortedArray)
        {
            Sort.QuickSort(unsortedArray);
            CollectionAssert.AreEqual(unsortedArray, sortedArray, $"Failed to sort array.");
        }

        [DataRow(new[] { 3, 2, 1, 5, 4 }, new[] { 1, 2, 3, 4, 5 })]
        [DataRow(new[] { 3, 58, 6, 35, 4, 58 }, new[] { 3, 4, 6, 35, 58, 58 })]
        [DataRow(new[] { 3 }, new[] { 3 })]
        [DataRow(new[] { 2, 4, -8, 9, 6, -3 }, new[] { -8, -3, 2, 4, 6, 9 })]
        [DataTestMethod]
        public void MergeSort_UnsortedArray_SortedArray(int[] unsortedArray, int[] sortedArray)
        {
            Sort.MergeSort(unsortedArray);
            CollectionAssert.AreEqual(unsortedArray, sortedArray, $"Failed to sort array.");
        }

    }
}
