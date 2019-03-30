using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace minmaxhelp
{
    class Program
    {
        static void Main(string[] args)
        {


            Student student = CreateNewStudent();
            List<Student> students = new List<Student>();
            students.Add(student);


            //List<Student> students = CreateNewStudent();
            //Student students = new Student();
            //students = CreateNewStudent(line);

            foreach (var item in students)
            {
                Console.WriteLine($"{student.Name} Min: {student.GetMinimumScore()} Max: {student.GetMaximumScore()}");
            }


            Console.ReadLine();
        





    }

        private static Student CreateNewStudent()
        {
            List<string> students = GetStudentDataFile();
            //List<int> s = new List<int>();
            //List<string> scores = new List<string>();

            //int[] s = Array.Empty<int>();



            // string[] scores = new string[properties.Length - 1];
            string[] scores = Array.Empty<string>();

            string name = "";

            int[] s = Array.Empty<int>();
            

            foreach (string line in students)
            {
                string[] properties = line.Split(" ");
                scores = new string[properties.Length - 1];


                for (int i = 0; i < properties.Length; i++)
                {
                    

                    if (i == 0)
                    {
                        name = properties[0];
                    }
                    else
                    {
                        scores[i - 1] = properties[i];

                    }

                    //s = scores.ConvertAll(x => Int32.Parse(x));




                    
                }

                

            }

            s = new int[scores.Length];

            s = Array.ConvertAll(scores, int.Parse);
            Student student = new Student(name, s);
            //int[] s = new int[scores.Length];


            return student;





        }

        private static List<string> GetStudentDataFile()
        {
            List<string> students = new List<string>();
            foreach (string line in File.ReadAllLines(@"C:\Users\kstar\source\repos\minmaxhelp\minmaxhelp\studentdata.txt"))
            {
                students.Add(line);
            }
            return students;
            //List<string> lines = File.ReadAllLines(@"c:studentdata.txt").ToList();
            //return lines;

        }

        }
    }
