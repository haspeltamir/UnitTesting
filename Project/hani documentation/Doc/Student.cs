using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc
{
    public class Student
    {

        public string[] Id = new string[2];// array of the students' id (up to 2 students)
        public string Path;
        public bool doesFileCompile; // for several files.
        public int[] correctOutput; // might be several input/output files.
        public int documentedFile; // grade for the documentation.
        public int finalGrade;// final grade
        public int structuredFile;
        //public bool variableConventions;
        //public bool classConventions;
        //public bool runningExecute;
        public string[] getId()
        {
            return Id;
        }

        public bool getDoesFileCompile()
        {
            return doesFileCompile;
        }

        public int[] getCorrectOutput()
        {
            return correctOutput;
        }

        public int getDocumentedFile()
        {
            return documentedFile;
        }

        public int getFinalGrade()
        {
            return finalGrade;
        }

        public int getStructuredFile()
        {
            return structuredFile;
        }

        /*public bool getVariableConventions()
        {
            return variableConventions;
        }

        public void setVariableConventions(bool variableConventions)
        {
            this.variableConventions = variableConventions;
        }

        public bool getClassConventions()
        {
            return classConventions;
        }

        public void setClassConventions(bool classConventions)
        {
            this.classConventions = classConventions;
        }

        public bool getRunningExecute()
        {
            return runningExecute;
        }

        public void setRunningExecute(bool runningExecute)
        {
            this.runningExecute = runningExecute;
        }
        */
        public void setId(string[] id)
        {
            Id = new string[2];
        }

        public void setDoesFileCompile(bool[] doesFileCompile)
        {

        }

        public void setCorrectOutput(int[] correctOutput)
        {
            this.correctOutput = correctOutput;
        }

        public void setDocumentedFile(int documentedFile)
        {
            this.documentedFile = documentedFile;
        }

        public void setStructuredFile(int structuredFile)
        {
            this.structuredFile = structuredFile;
        }
        public void setFinalGrade(int[] weights)
        {
            this.finalGrade = weights[5];
        }
    }
}
