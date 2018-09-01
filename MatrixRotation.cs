// Source: https://www.hackerrank.com/challenges/matrix-rotation-algo/problem
// Function Description

// Complete the matrixRotation function in the editor below. It should print the resultant 2D integer array and return nothing.

// matrixRotation has the following parameter(s):

// matrix: a 2D array of integers
// r: an integer that represents the rotation factor

// Sample
/**
Start         First           Second
 1 2 3 4        2  3  4  5      3  4  5  6
12 1 2 5  ->   1  2  3  6 ->   2  3  4  7
11 4 3 6      12  1  4  7       1  2  1  8
10 9 8 7      11 10  9  8     12 11 10  9
**/

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

class MatrixRotation {

    // Complete the matrixRotation function below.
    static void matrixRotation(List<List<int>> matrix, int r) {
        int mz = matrix.Count();
        int nz = matrix.First().Count();
        int maxSize = mz * nz;
        List<List<int>> matrixEvo = new List<List<int>>();
        
        int cls = -1;
        List<int> matrixLayer = new List<int>();
        int x = cls;
        int y = cls;
        mz--;
        nz--;
        for(int i = 0; i<maxSize; i++) {
            if(x == cls && y == cls) {
                cls++;
                x = cls;
                y = cls;
                Console.WriteLine("--{0}--", cls);
            }
            
            Console.WriteLine("{0}, {1}", x, y);
            
            // left side
            if(x < (mz-cls) && y == cls) {
                x++;
            }
            // bottom side
            else if(y < (nz-cls) && x == (mz-cls)) {
                y++;
            }
            // right side
            else if(x > cls && y == (nz-cls)) {
                x--;
            }
            // top side
            else if(y > cls && x == cls) {
                y--;
            }
            
        }
    }
    
    static void Main(string[] args) {
        string[] mnr = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(mnr[0]);

        int n = Convert.ToInt32(mnr[1]);

        int r = Convert.ToInt32(mnr[2]);

        List<List<int>> matrix = new List<List<int>>();

        for (int i = 0; i < m; i++) {
            matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
        }

        matrixRotation(matrix, r);
    }
}
