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
     * Complete the 'isBalanced' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isBalanced(string s)
    {
        var brackets = "{{}}[]()";
        var openBrackets = "{{[(";
        var closeBrackets = "}}])";
        for(int i = 0; i <4; i++)
        {
            int freqOpen = s.Count(f => (f == openBrackets.ElementAt(i)));
            int freqClose = s.Count(f => (f == closeBrackets.ElementAt(i)));
            if(freqOpen != freqClose) return $"NO";
            
        }
        
        int cursor = 0;
        foreach(var ch in s.ToArray())
        {
            if(openBrackets.Contains(ch))
                cursor++;
            else
            {
                if(s.ElementAt(cursor - 1) != openBrackets.ElementAt(closeBrackets.IndexOf(ch)))
                {
                    
                    return $"NO";
                }
                else
                {
                   s = s.Remove(cursor-1,2);
                   cursor--;
                }
            }
        }
         return "YES";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = Result.isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}

