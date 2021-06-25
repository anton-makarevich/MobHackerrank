using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TestProject1.Session3
{
    // Given a square matrix, calculate the absolute difference between the sums of its diagonals.
    //
    // For example, the square matrix  is shown below:
    //
    // 1 2 3
    // 4 5 6
    // 9 8 9
    // The left-to-right diagonal = . The right to left diagonal = . Their absolute difference is .
    //
    // Function description
    //
    // Complete the  function in the editor below.
    //
    // diagonalDifference takes the following parameter:
    //
    // int arr[n][m]: an array of integers
    // Return
    //
    // int: the absolute diagonal difference
    // Input Format
    //
    // The first line contains a single integer, , the number of rows and columns in the square matrix .
    // Each of the next  lines describes a row, , and consists of  space-separated integers .
    //
    // Constraints
    //
    // Output Format
    //
    // Return the absolute difference between the sums of the matrix's two diagonals as a single integer.


    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<List<int>> arr = new List<List<int>>
            {
                new List<int> {1, 2, 3},
                new List<int> {4, 5, 6},
                new List<int> {9, 8, 9}
            };
            var result = DiagonalDifference(arr);
            Assert.Equal(2, result);
        }

        int DiagonalDifference(List<List<int>> arr)
        {
            int d1=0;
            int d2=0;
            for (int i = 0; i < arr.Count; i++)
            {
                d1 +=  arr[i][i];
                d2 += arr[i][arr.Count - i - 1];
            }

            return Math.Abs(d1 - d2);
        }
    }
}
