using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratical_1
{
   
    
        // Student Class
        class Student
        {
            // Private Data Members
            private int studentId;
            private string studentName;
            private int age;
            private string course;

            // Constructor
            public Student(int id, string name, int studentAge, string studentCourse)
            {
                studentId = id;
                studentName = name;
                age = studentAge;
                course = studentCourse;
            }

            // Method to Display Student Details
            public void DisplayStudent()
            {
                Console.WriteLine("\n------ Student Admission Details ------");
                Console.WriteLine("Student ID   : " + studentId);
                Console.WriteLine("Student Name : " + studentName);
                Console.WriteLine("Age          : " + age);
                Console.WriteLine("Course       : " + course);
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter Student ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Course: ");
                string course = Console.ReadLine();

                // Create Object
                Student s1 = new Student(id, name, age, course);

                // Display Details
                s1.DisplayStudent();

                Console.WriteLine("\nAdmission Successful!");

                Console.ReadKey();
            }
        }
    }

 
