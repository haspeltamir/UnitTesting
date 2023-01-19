using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace IndentCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileList = { "C:\\Users\\lenovo\\Desktop\\מכללה\\עתירות תוכנה יזיד\\checkIndents\\indention\\indention\\hello.txt",
                                    "C:\\Users\\lenovo\\Desktop\\מכללה\\עתירות תוכנה יזיד\\checkIndents\\indention\\indention\\java.txt",
                                    "C:\\Users\\lenovo\\Desktop\\מכללה\\עתירות תוכנה יזיד\\checkIndents\\indention\\indention\\c.txt" };
            Results(fileList);



        }

        static void Results(string[] files)
        {
            foreach (string file in files)
            {

                string filePath = file;

                // Read the file and check the indentation
                List<(string, bool)> lines = CheckIndentation(filePath);

                // Count the number of true and false values
                int trueCount = lines.Count(x => x.Item2 == true);
                int falseCount = lines.Count(x => x.Item2 == false);

                // Calculate the ratio of true to false values
                double ratio = (double)trueCount / (trueCount + falseCount);

                // Print the results
                foreach ((string line, bool isCorrect) in lines)
                {
                    Console.WriteLine($"{line}: {isCorrect}");
                }

                Console.WriteLine($" your grade is : {ratio.ToString("0.00")}\n");
                Console.WriteLine("**********************************************************");
            }
        }

        static List<(string, bool)> CheckIndentation(string filePath)
        {

            // Read the file
            List<string> lines = new List<string>(File.ReadAllLines(filePath));

            // Keep track of the current indent level
            int indentLevel = 0;


            lines.RemoveAll(string.IsNullOrWhiteSpace);

            // Store the results in a list of tuples
            List<(string, bool)> results = new List<(string, bool)>();


            // Check the indentation of each line
            foreach (string line in lines)
            {



                // Count the number of leading spaces
                int indent = 0;
                while (indent < line.Length && line[indent] == ' ')
                {
                    indent++;
                }


                // Check if the line is a block opener or closer
                bool isOpener = line.Trim().EndsWith("{");
                bool isCloser = line.Trim().EndsWith("}");
                bool parentheses = line.Contains("(") && !(line.Contains(")")) || line.Contains(")") && !(line.Contains("("));



                // Check if the indentation is correct
                bool isCorrect = false;


                if (isOpener)
                {
                    // If this is a block opener, the indentation should be one level deeper than the previous line
                    isCorrect = indent == indentLevel * 4 + 4;
                    indentLevel++;
                }
                else if (isCloser)
                {
                    // If this is a block closer, the indentation should be one level shallower than the previous line
                    isCorrect = indent == indentLevel * 4;
                    indentLevel--;
                }
                else
                {
                    // Otherwise, the indentation should be the same as the previous line
                    isCorrect = indent == indentLevel * 4;

                    if (parentheses)
                    {
                        isCorrect = false;
                    }
                }

                // Add the result to the list
                results.Add((line, isCorrect));
            }

            return results;
        }

    
}
}
