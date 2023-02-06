using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Doc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test the function with a sample file

           
            List<Student> studentList = new List<Student>();
            Student student1 = new Student();
            Student student2 = new Student();
            student1.Id[0] = "312456798";
            student1.Id[1] = "311111111";
            student1.Path = "C:\\Users\\Win10\\Downloads\\qad\\HW6\\אחמד בדראן_25945_assignsubmission_file_\\h0w2.c";
            student1.correctOutput = new int[2];
            student1.correctOutput[0] = 1;
            student1.correctOutput[1] = 0;
            student1.documentedFile = 0;
            student1.structuredFile = 0;
            student1.finalGrade = 95;
            //student 2 info
            student2.Id[0] = "322222222";
            student2.Id[1] = "378945987";
            student2.Path = "C:\\Users\\Win10\\Downloads\\מבוא למדעי המחשב מים תשפג.א מלכי-תרגיל בית 3 -קלט  והדפסה בפורמט-11853\\דוד פולק_13231_assignsubmission_file_\\HW03.py";
            student2.correctOutput = new int[3];
            student2.correctOutput[0] = 1;
            student2.correctOutput[1] = 1;
            student2.correctOutput[2] = 1;
            student2.documentedFile = 0;
            student2.structuredFile = 0;
            student2.finalGrade = 100;
            //init student list
            studentList.Add(student1);
            studentList.Add(student2);

            var DOC1 = new Documentation();

            DOC1.CheckDocOfAllClass(ref studentList);
            Console.WriteLine("student 1 doc grade:" + student1.getDocumentedFile());
            Console.WriteLine("student 2 doc grade:" + student2.getDocumentedFile());
        }

       
    }   
}

