/*
 * @Author: Quynh T. Vu
 * Collaborated with the entire class
 */
using System;
using System.IO;

namespace FileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Quynh\Documents\School Semesters\Fall2020\MIS 3033 Non-Procedural Programming\Pride and Prejudice by Jane Austen.txt";

            //Reads the entire file into 1 SINGLE string
            //string contentsOfFile = File.ReadAllText(filePath);

            var lines = File.ReadAllLines(filePath);
            
            //Outputs chapters at a time of the file
            for(int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                if (currentLine.Contains("Chapter"))
                {
                    Console.ReadKey();
                }
                Console.WriteLine(currentLine);
            }

            //Output 5 lines at a time of the file
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    if (i % 5 == 0 && i != 0)
            //    {
            //        Console.ReadKey();
            //    }

            //    Console.WriteLine(lines[i]);
            //}

            

            Console.ReadKey();
        }
    }
}
