using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Doc
{
    public class Documentation
    {

        public void CheckDocOfAllClass(ref List<Student> studentlist)
        {

            foreach (Student student in studentlist)
            {
                student.setDocumentedFile(CheckFunctionDocumentationRatio(student.Path));
            }
        }

        public int CheckFunctionDocumentationRatio(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file does not exist.");
            }

            string[] lines = File.ReadAllLines(filePath);
            string extension = Path.GetExtension(filePath).ToLower();
            string pattern = @"\d{9}";
            bool isComment = false;
            

            // Keep track of the number of functions and the number of documented functions
            int functionCount = 0;
            int documentedFunctionCount = 0;
            int documents = 0;
            float grade = 0;


            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                bool isFunction = line.Contains("(") && line.Contains(")") && (!(line.Contains(";"))) && (!(line.TrimStart().StartsWith("//"))) && (!(line.Contains("while"))) && (!(line.Contains("if"))) && (!(line.Contains("main")));


                //match student ID
                Match match = Regex.Match(line, pattern);
                if (match.Success)
                {
                    string id = match.Value;
                    Console.WriteLine($"ID :{id}");
                }
                if (line.TrimStart().StartsWith("/*") && (!(line.Trim().EndsWith("*/"))))
                {
                    isComment = true;
                    documents++;
                }
                if ((!(line.Contains("/*"))) && (line.Trim().EndsWith("*/")))
                {
                    isComment = false;
                }
               

                if (extension == ".py")
                {
                    if ((line.TrimStart().StartsWith("def ")) && (line.Trim().EndsWith(":")))
                    {

                        functionCount++;

                        // Check if the previous line is a documentation string
                        if (i > 0 && lines[i - 1].TrimStart().StartsWith("#") || lines[i - 1].TrimStart().StartsWith("\"\"\"") || line.Contains("'''"))
                        {
                            documentedFunctionCount++;
                        }
                    }
                    else
                    {
                        if (line.TrimStart().StartsWith("#") || line.Contains("\"\"\"") || line.Contains("'''"))
                        {
                            documents++;
                        }

                    }
                }

                if (extension == ".c" || extension == ".java")
                {
                    if (isFunction && !isComment)
                    {
                        functionCount++;
                        // Check if the previous line is a documentation string
                        if (i > 0 && (lines[i - 1].TrimStart().StartsWith("//") || lines[i - 1].TrimStart().StartsWith("/*")))
                        {
                            //functionIsDocumented = true;
                            documentedFunctionCount++;
                        }
                    }
                    else
                    {
                        if (line.TrimStart().StartsWith("//") || (line.Contains("/*") && line.Contains("*/")))
                        {
                            documents++;
                        }
                    }
                }
                
            }
            
             grade += ((float)documentedFunctionCount / functionCount) * 100;           

            if (float.IsNaN(grade))
            {
                grade = ((float)documents / (lines.Length / 5)) * 100;
            }
            
            return (int)grade;
        }
    }
}
