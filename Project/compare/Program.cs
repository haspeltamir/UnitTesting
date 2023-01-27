using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using compare.Properties;


namespace compare
{
    internal class Program
    {
        static void Main()
        {
            Compares compare = new Compares();
           // This will get the current WORKING directory (i.e. \bin\Debug)
           string workingDirectory = Environment.CurrentDirectory;
           // This will get the current PROJECT directory
           string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName; 
           string path = Path.Combine(projectDirectory,@"compare\TestData");
           compare.compares(path);
        }
    }
}
