﻿namespace Arrays;

public partial class Solution
{
    /// <summary>
    /// Given a two-dimensional array, find the maximum element.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns>Maximum element in arr.</returns>
    public int FindMaxElement(int[][] arr)
    {
        int maxElement = arr[0][0];

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] > maxElement )
                {
                    maxElement  = arr[i][j];
                }
            }
        }

        return maxElement ;
    }

    /// <summary>
    /// Given a matrix, calculate its transpose. The transpose of a matrix flips the matrix over its main diagonal, switching the row and column indices.
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public int[][] CalculateTranspose(int[][] matrix)
    {
        int rLength = matrix.Length;
        int cLength = matrix[0].Length;
        int[][] transpose = new int[cLength][];
        for (int i = 0; i < cLength; i++)
        {
            transpose[i] = new int[rLength];
            for (int j = 0; j < rLength; j++)
            {
                transpose[i][j] = matrix[i][j];
            }
        }

        return transpose;
    }

    /// <summary>
    /// Given a jagged array, sort its elements in ascending order.
    /// </summary>
    /// <param name="arr"></param>
    public void SortJaggedArray(int[][] arr)
    {
        foreach (var subArr in arr)
        {
            Array.Sort(subArr);
        }
    }

    /// <summary>
    /// Given a jagged array, calculate the sum of all elements.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int CalculateSumOfElements(int[][] arr)
    {
        int sumOfelems = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j< arr[i].Length; j++)
            {
                sumOfelems += arr[i][j];
            }
        }

        return sumOfelems;
    }


    /// <summary>
    /// Given a jagged array, sort its rows in ascending order based on the sum of their elements.
    /// </summary>
    /// <param name="arr"></param>
    public void SortRowsBySum(int[][] arr)
    {
        Array.Sort(arr, (a, b) => a.Sum().CompareTo(b.Sum()));
    }

    /// <summary>
    /// Given a multi-dimensional array, convert it into a jagged array.
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public int[][] ConvertToJaggedArray(int[,] array)
    {
        int rLength = array.GetLength(0);
        int cLength = array.GetLength(1);
        int[][] jaggedArray = new int[rLength][];
        for (int i = 0; i < rLength; i++)
        {
            jaggedArray[i] = new int[cLength];
            for (int j = 0; j < cLength; j++)
            {
                jaggedArray[i][j] = array[i, j];
            }
        }
        return jaggedArray;
    }

    /// <summary>
    /// Given a multi-dimensional array, reshape it into a new shape without changing its data.
    /// </summary>
    /// <param name="array"></param>
    /// <param name="rows"></param>
    /// <param name="columns"></param>
    /// <returns></returns>
    public int[,] ReshapeArray(int[,] array, int rows, int columns)
    {
        int[,] reshapedArray = new int[rows, columns];
        int k = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                reshapedArray[i, j] = array[k / columns, k % columns];
                k++;
            }
        }
        return reshapedArray;
    }

    /// <summary>
    /// Given an integer N, generate a spiral matrix of size N x N.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[,] GenerateSpiralMatrix(int n)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given a jagged array and a target element, search for the element and return its indices if found, otherwise return [-1, -1].
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="target"></param>
    /// <param name="rowIndex"></param>
    /// <param name="columnIndex"></param>
    public void SearchElement(int[][] arr, int target, out int rowIndex, out int columnIndex)
    {
        rowIndex = -1;
        columnIndex = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (target == arr[i][j])
                {
                    rowIndex = i;
                    columnIndex = j;
                    return;
                }
                    
            }
        }
        
    }

    /// <summary>
    /// Given a chain of matrices, calculate the minimum number of scalar multiplications required to multiply them.
    /// </summary>
    /// <param name="chain"></param>
    /// <returns></returns>
    public int CalculateMinScalarMultiplications(int[] chain)
    {
        int n = chain.Length;
        int[,] m = new int[n, n];

        for (int i = 1; i < n; i++)
            m[i, i] = 0;

        for (int len = 2; len < n; len++)
        {
            for (int i = 1; i < n - len + 1; i++)
            {
                int j = i + len - 1;
                m[i, j] = int.MaxValue;
                for (int k = i; k < j; k++)
                {
                    int q = m[i, k] + m[k + 1, j] + chain[i - 1] * chain[k] * chain[j];
                    if (q < m[i, j])
                        m[i, j] = q;
                }
            }
        }

        return m[1, n - 1];
    }

    /// <summary>
    /// Given a one-dimensional array, find the maximum sum of a subarray.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int FindMaxSubarraySum(int[] arr)
    {
        int maxSum = arr[0];
        int xozrgiSum = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < xozrgiSum + arr[i])
            {
                xozrgiSum = xozrgiSum + arr[i];
            }
            else
            {
                xozrgiSum = arr[i];
            }

            if (maxSum > xozrgiSum)
            {
                maxSum = maxSum;
            }
            else
            {
                maxSum = xozrgiSum;
            }
        }

        return maxSum;
    }

    /// <summary>
    /// Find the maximum value in a 2D array of integers, considering only the elements that form a square or rectangle. The square/rectangle can have any size and must be aligned with the rows and columns.
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public int FindMaxValueInRectangle(int[,] array)
    {
        throw new NotImplementedException();
    }

    /// <summary>
/// Given a jagged array of integers, sort the array in ascending order based on the sum of each row. If two rows have the same sum, maintain their relative order.
/// </summary>
/// <param name="arr">The jagged array to be sorted.</param>
public void SortJaggedArrayByRowSum(int[][] arr)
{
    Array.Sort(arr, (a, b) =>
    {
        int sumA = a.Sum();
        int sumB = b.Sum();

        if (sumA != sumB)
        {
            return sumA.CompareTo(sumB);
        }

        // If sums are equal, maintain relative order
        return Array.IndexOf(arr, a).CompareTo(Array.IndexOf(arr, b));
    });
}



    /// <summary>
    /// Given a 2D array of integers, find the subarray with the maximum sum. The subarray should have a rectangular shape.
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public int[,] FindMaxSumSubarray(int[,] array)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given a square 2D array of integers, rotate it 90 degrees clockwise in place, without using additional space.
    /// </summary>
    /// <param name="array"></param>
    public void RotateSquareArrayClockwise(int[,] array)
    {
        throw new NotImplementedException();
    }


    /// <summary>
    /// Given a jagged array of integers, find the row with the highest sum of elements. If multiple rows have the same sum, return the index of the first occurrence.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int FindRowWithHighestSum(int[][] arr)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given a 2D array of characters, count the number of occurrences of a specific character in the array.
    /// </summary>
    /// <param name="array"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int CountOccurrencesIn2DArray(char[,] array, char target)
    {
        int counter = 0;
        int lengthOfFirst = array.GetLength(0);
        int lengthOfSecond = array.GetLength(1);
        for (int i = 0; i < lengthOfFirst; i++)
        {
            for (int j = 0; j < lengthOfSecond; j++)
            {
                if (array[i,j] == target)
                {
                    counter++;
                }
            }
        }

        return counter;
    }
}