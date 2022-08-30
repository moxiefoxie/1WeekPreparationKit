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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string dayOrNight = s.Substring(8,2);
        string hh = s.Substring(0,2);
        string mm = s.Substring(3,2);
        string ss = s.Substring(6,2);
        switch(dayOrNight)
        {
            case "AM": hh = hh == "12" ? "00": hh; break;
            case "PM": hh = (Convert.ToInt32(hh)%12 + 12).ToString().PadLeft(2, '0'); break;
        
        }
       return $"{hh}:{mm}:{ss}";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
