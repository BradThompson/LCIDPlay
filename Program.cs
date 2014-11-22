using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

// Taken from http://msdn.microsoft.com/en-us/library/cc233965.aspx

namespace BenchTest
{
    public class Example
    {
        public static void Main()
        {
            string fileName = @"c:\src\CSharp\LCID\MSLCID.txt";
            string[] cLines = File.ReadAllLines(fileName);
            int lineCount = 0;
            string csvLine = "";
            string comma = "";
            foreach (string cl in cLines)
            {
                lineCount++;
                if (lineCount % 2 == 1)
                {
                    csvLine += comma + cl;
                    comma = ",";
                }
                if (lineCount % 10 == 0)
                {
                    Console.WriteLine(csvLine);
                    csvLine = "";
                    comma = "";
                }
            }
        }
    }
}