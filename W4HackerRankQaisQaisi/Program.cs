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
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
            string Draw = "";
            for(int x = 1; x <= n; x++)
            {
                for (int i = n - x; i > 0; i--)
                    Draw =Draw+  " ";
                    for (int j = 1; j <= x; j++)
                        Draw = Draw+"#";
                    Draw = Draw+ "\n";
            }
            Console.WriteLine(Draw);
        
      
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
