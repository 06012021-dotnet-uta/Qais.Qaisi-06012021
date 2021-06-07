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

    public static int diagonalDifference(List<List<int>> arr)
    {
        int leftSumNum=0;
        int rightSumNum=0;
        int maxRow =arr.Count-1;
        int maxCol =arr[arr.Count-1].Count-1;
       
       for (int i=0; i<=arr.Count-1 ; i++)
       {
           for (int j=0; j<=arr[i].Count-1; j++)
           {    
                    if (i==j)
                    {
                       leftSumNum=leftSumNum + arr[i][j];
                       Console.WriteLine(arr[i][j]);
                    }
                
           }
       }
      
      
      for (int i=0; i<=arr.Count-1 ; i++)
       {
     
           for (int j=arr[i].Count-1; j>=0; j--)
           {    
           if (j==maxRow)
                    {
                        
                        rightSumNum=rightSumNum + arr[i][j];
                        Console.WriteLine(arr[i][j]);
                    }
           
           }
           maxRow=maxRow-1;
       }
      
      
      
     
       
    return Math.Abs(leftSumNum-rightSumNum);  
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
