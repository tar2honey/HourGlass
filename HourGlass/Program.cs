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

namespace HourGlass
{
    class Program
    {
        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            int retVal = -99;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int sum = (arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]);
                    string sumString = i + "," + j + "= " + arr[i][j] +
                                        ", " + (i + 0) + "," + (j + 1) + "= " + arr[i][j + 0] +
                                        ", " + (i + 0) + "," + (j + 2) + "= " + arr[i][j + 2] +
                                        ", " + (i + 1) + "," + (j + 1) + "= " + arr[i + 1][j + 1] +
                                        ", " + (i + 2) + "," + (j + 0) + "= " + arr[i + 2][j + 0] +
                                        ", " + (i + 2) + "," + (j + 1) + "=  " + arr[i + 2][j + 1] +
                                        ", " + (i + 2) + "," + (j + 2) + "= " + arr[i + 2][j + 2];
                    Console.WriteLine(sumString);

                    if (retVal < sum)
                        retVal = sum;
                }
            }

            return retVal;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                string[] input = new string[6] { "1 1 1 0 0 0", "0 1 0 0 0 0", "1 1 1 0 0 0", "0 0 2 4 4 0", "0 0 0 2 0 0", "0 0 1 2 4 0" };
                arr[i] = Array.ConvertAll(input[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            //textWriter.WriteLine(arr[5][5]);
            //Console.Write(arr[5][5]);

            int result = hourglassSum(arr);
            //for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(result);
                //textWriter.WriteLine(result[i]);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
