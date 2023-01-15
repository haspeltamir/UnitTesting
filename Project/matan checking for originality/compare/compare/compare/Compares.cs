using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compare
{
    internal class Compares
    {
       
         // Private variable for passing data.
        // Stores all the names of the files.
        private List<string> files = new List<string>();

        // Stores all the lines that found include the names of the files and thier lines numbers.
        public List<string> equalslines = new List<string>();

        // Stores the names of the filse that found matched and what percentage are they matching
        public List<string> match = new List<string>();

        private string composer;
        private string fileName;
        private string fileName1;
        private decimal prervrntage = 0;
        private string[] file;
        private List<string> filesPath = new List<string>();
       

       /// <summary>
       /// This program recives File Path and opens folder in folder,serach for Code files.
       /// Presenrts files that have over 60% matched text with origins.
       /// Be aware this program can delete your System32 dir. you should avoid it as if youre life depends on it. 
       /// this program can read C/Py/C# text Files pay attention you can change the match % to see more files in line 159.
       /// </summary>
       /// <param name="filePath"></param>
                
        public bool compares(string filePath)
        {
            
            files = Directory.GetDirectories(filePath).ToList();
           
            string[] fileContenrstep = new string[files.Count];
            for (int i = 0 ; i < files.Count; i++)
            {
                fileContenrstep[i] = files.ElementAt(i);
            }
            
            for (int i = 0; i < fileContenrstep.Length; i++)
            {
                
                file = Directory.GetFiles(fileContenrstep[i]);
                
              
                for(int j = 0 ; j< file.Length; j++)
                {
                    DirectoryInfo directory = new DirectoryInfo(file[j]);
                    string temp = directory.Name;
                    if (temp.Contains(".java") || temp.Contains(".txt")|| temp.Contains(".c") ||temp.Contains(".py") && !temp.Contains(".class"))
                    {
                        filesPath.Add(file[j]);
                    }
                    
                }
                
            }

            for (int k = 0; k < filesPath.Count; k++)
            {
                int length = 0;
                StringBuilder stringBuilder = new StringBuilder();
                for (int x = k + 1; x < filesPath.Count; x++)
                {
                    int matchCount = 0;
                    int holder = 0;
                    DirectoryInfo dire = new DirectoryInfo(filesPath[k]);
                    DirectoryInfo dire1 = new DirectoryInfo(filesPath[x]);
                    string folderName = dire.Parent.ToString();
                    string folderName1 = dire1.Parent.ToString();

                    if (!folderName.Equals(folderName1))
                     { 
                      string[] fileA = System.IO.File.ReadAllLines(Path.Combine(filesPath[k]));
                      string[] fileB = System.IO.File.ReadAllLines(Path.Combine(filesPath[x]));
                      int count = 0;
                        for (int i = 0; i < fileA.Length; i++)
                        {
                            holder = fileA.Length;
                            for (int j = 0; j < fileB.Length; j++)
                            {
                                if (fileA[i] != "" && fileB[j] != "")
                                {
                                    int similarity = string.Compare(fileA[i], fileB[j]);
                                    if (!(fileA[i].Contains("}") || fileA[i].Contains("*") || fileA[i].Contains("{") || fileA[i].Contains("/")))
                                    {
                                        if (similarity == 0)
                                        {
                                            FileInfo fileInfo = new FileInfo(filesPath[k]);
                                            FileInfo fileInfo1 = new FileInfo(filesPath[x]);
                                            string line = "Line number :";
                                            string text1 = folderName.Replace("_assignsubmission_file_", " ") + fileInfo.Name;
                                            string text2 = folderName1.Replace("_assignsubmission_file_", " ") + fileInfo1.Name;
                                            fileName = text1;
                                            fileName1 = text2;

                                            stringBuilder.Insert(length, text1);
                                            length += text1.Length;
                                            stringBuilder.Insert(length, " ");
                                            length++;
                                            stringBuilder.Insert(length, line);
                                            length += line.Length;
                                            stringBuilder.Insert(length, " ");
                                            length++;
                                            stringBuilder.Insert(length, i.ToString());
                                            length++;
                                            stringBuilder.Insert(length, " ");
                                            length++;
                                            stringBuilder.Insert(length, "=");
                                            length++;
                                            stringBuilder.Insert(length, " ");
                                            length++;
                                            stringBuilder.Insert(length, text2);
                                            length += text2.Length;
                                            stringBuilder.Insert(length, " ");
                                            length++;
                                            stringBuilder.Insert(length, line);
                                            length += line.Length;
                                            stringBuilder.Insert(length, " ");
                                            length++;
                                            stringBuilder.Insert(length, j.ToString());
                                            length++;
                                            stringBuilder.Insert(length, " ");
                                            length++;
                                            stringBuilder.Insert(length, fileA[i]);
                                            length += fileA[i].Length;
                                            stringBuilder.Insert(length, "\n");
                                            length++;
                                            count++;
                                            matchCount++;
                                        }
                                    }
                                }

                            }
                        }
                    }
                    if (matchCount != 0)
                    {
                        prervrntage = Math.Round(Convert.ToDecimal((matchCount / Convert.ToDecimal(holder)) * 100), 2);
                    }    
                    if (prervrntage > 100)
                    {
                        prervrntage = 100;
                    }
                    if (prervrntage >= 50)
                    {
                        composer = fileName + " match " + prervrntage.ToString() + "% with " + fileName1;
                        if (matchCount != 0)
                        {
                            match.Add(composer);
                        }
                    }
                  
                }
                if (stringBuilder != null)
                {
                    equalslines.Add(stringBuilder.ToString());
                }
            }

            if(match!= null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }   
    }
}
