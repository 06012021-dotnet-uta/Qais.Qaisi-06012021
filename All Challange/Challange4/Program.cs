﻿using System.CodeDom.Compiler;
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
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int hourglassSum(List<List<int>> arr)
    {
        int sumNum=0;
        int highest=0;
        for (int i=0; i<4; i++)
        {
            for (int j=0; j<4; j++)
            {
                sumNum=0;
                for (int x=i; x<=i+2; x++)
                {
                    for (int y=j; y<=j+2; y++)
                    {
                        if (x!=i+1)
                        sumNum=sumNum+arr[x][y];
                        else if (y!=j && y!=j+2)
                        sumNum=sumNum+arr[x][y];
                    }
                   
                    
                }
                 if (sumNum>highest)
                     highest=sumNum;
                 Console.WriteLine(sumNum);
            }
         
        }
        
           sumNum=highest;    
           return sumNum;
           
           
    }
    

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

