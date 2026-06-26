using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    class Student
    {
        // Fields (Private = Encapsulation)
        private int id;
        private string name;
        private int age;
        private double cgpa;

        // Constructor
        public Student(int id, string name, int age, double cgpa)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.cgpa = cgpa;
        }

        // Properties (Getter & Setter)

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
            }
        }

        public double Cgpa
        {
            get { return cgpa; }
            set
            {
                if (value >= 0 && value <= 4)
                    cgpa = value;
            }
        }

        // Method
        public void DisplayStudent()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"ID   : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age  : {Age}");
            Console.WriteLine($"CGPA : {Cgpa}");
            Console.WriteLine("--------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.WriteLine("\n===== Student Management System =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Exit");

                Console.Write("Enter Choice: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Console.Write("Enter ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Age: ");
                            int age = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter CGPA: ");
                            double cgpa = Convert.ToDouble(Console.ReadLine());

                            Student s = new Student(id, name, age, cgpa);

                            students.Add(s);

                            Console.WriteLine("Student Added Successfully.");
                            break;

                        case 2:

                            if (students.Count == 0)
                            {
                                Console.WriteLine("No Student Found.");
                            }
                            else
                            {
                                foreach (Student student in students)
                                {
                                    student.DisplayStudent();
                                }
                            }

                            break;

                        case 3:

                            Console.Write("Enter Student ID: ");
                            int searchId = Convert.ToInt32(Console.ReadLine());

                            bool found = false;

                            foreach (Student student in students)
                            {
                                if (student.Id == searchId)
                                {
                                    student.DisplayStudent();
                                    found = true;
                                    break;
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine("Student Not Found.");
                            }

                            break;

                        case 4:

                            Console.WriteLine("Thank You.");
                            return;

                        default:
                            Console.WriteLine("Invalid Choice.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input! Please enter correct data.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}