// LINK: https://www.hackerrank.com/challenges/staircase/problem 

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

class Solution {

    // Complete the staircase function below.
    static void staircase(int n) {
        StringBuilder strBldr = new StringBuilder();
        
        for(int i=0; i<n; i++) {
            strBldr.Append(" ");
        }
        
        for(int i=n-1; i>=0; i--) {
            strBldr.Replace(" ","#",i,1);
            Console.WriteLine(strBldr.ToString());
        }
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
