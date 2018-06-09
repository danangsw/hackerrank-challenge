// LINK: https://www.hackerrank.com/challenges/time-conversion/problem 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        /*
         * Write your code here.
         */
        DateTime dt;
        DateTime.TryParseExact(s, "hh:mm:sstt", null, System.Globalization.DateTimeStyles.None, out dt);
        return dt.ToString("HH:mm:ss");

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
