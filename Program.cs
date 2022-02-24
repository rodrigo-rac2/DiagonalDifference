using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(int size, List<List<int>> arr)
    {
        int columnDecreaseCount = size, rightDiagSum = 0, leftDiagSum = 0;
        if (size == 0)
            return 0;
        for (int i = 0; i < size; i++)
        {
            --columnDecreaseCount;
            for (int j = 0; j < size; j++)
            {
                if (i == j)
                    rightDiagSum += arr[i][j];
                if (j == columnDecreaseCount)
                    leftDiagSum += arr[i][j];
            }
        }
        return Math.Abs(rightDiagSum - leftDiagSum);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(n, arr);

        Console.WriteLine(result);
    }
}
