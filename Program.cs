using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._4
{
    internal class Program
    {

        public static void Array()
        {
            Console.WriteLine("Enter no of subjects");
            int subjects = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subjects Name");
            string[] subject = new string[subjects];
            for (int i = 0; i < subjects; i++)
            {
                subject[i] = Console.ReadLine();
            }


            int noc, nos;
            Console.WriteLine("Enter Number of Classes");
            noc = int.Parse(Console.ReadLine());
            string[][] students = new string[noc][];
            for (int i = 0; i < noc; i++)
            {
                Console.WriteLine("Enter Number of student in class " + (i + 1));
                nos = int.Parse(Console.ReadLine());
                students[i] = new string[nos];
                for (int j = 0; j < nos; j++)
                {
                    Console.WriteLine($"ENter student {j + 1}\'s name");
                    students[i][j] = Console.ReadLine();
                }

            }
            for (int k = 0; k < subjects; k++)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine($"Students List of class {i + 1}");
                    Console.WriteLine("*****************************************");
                    for (int j = 0; j < students[i].Length; j++)
                    {


                        Console.WriteLine(subject[k] + " " + students[i][j]);
                    }
                }

            }
            Console.WriteLine("*********************************************");





          /*  string[] students3A, students3B;

            students3A = new string[10] { "Rahul", "Sheela", "Mukesh", "Afzal", "Ramesh", "Geeta", "Jason", "Robert", "Gopal", "Meera" };
            students3B = new string[10] { "Pinky", "Rakesh", "Rafi", "Mumtaz", "Derek", "Sukhwinder", "Gopi", "Tulsi", "Chandrika", "Ann" };

            string[] subjects = new string[6];
            subjects[0] = "Physics";
            subjects[1] = "Chemistry";
            subjects[2] = "Biology";
            subjects[3] = "Calculus";
            subjects[4] = "Computer Science";
            subjects[5] = "Algebra";

            int[] marks = new int[6];
            marks[0] = 67;
            marks[1] = 90;
            marks[2] = 80;
            marks[3] = 55;
            marks[4] = 71;
            marks[5] = 92;

            Console.WriteLine("Students of Class 3A:");
            foreach (string s in students3A)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Students of Class 3B:");
            foreach (string s in students3B)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Marks of Kamal:");
            int total = 0;
            for (int i = 0; i < 6; i++)
            {
                total += marks[i];
                Console.WriteLine(subjects[i] + " = " + marks[i]);
            }
            Console.WriteLine("TOTAL = " + total + "/600 = " + (total * 100 / 600) + " percent");
        }
*/
    }
    static void Main(string[] args)
        {
        Array();
        }

    }
    }


