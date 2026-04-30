// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
    public int Attendance { get; set; }
    public int Participation { get; set; }
}

public delegate void StudentEvaluation(Student student);

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Aman", Marks = 60, Attendance = 80, Participation = 70 },
            new Student { Name = "Ravi", Marks = 45, Attendance = 60, Participation = 50 },
            new Student { Name = "Neha", Marks = 75, Attendance = 90, Participation = 85 }
        };

        // Anonymous Method
        StudentEvaluation evaluate = delegate (Student s)
        {
            int total = s.Marks + s.Attendance + s.Participation;

            Console.WriteLine($"Student: {s.Name}");
            Console.WriteLine($"Total Score: {total}");

            if (total > 200)
                Console.WriteLine("Performance: Excellent");
            else
                Console.WriteLine("Performance: Average");

            Console.WriteLine("---------------------");
        };

        foreach (var student in students)
        {
            evaluate(student);
        }

        // Lambda Expression
        Func<Student, bool> isEligible = s => s.Marks > 50;

        var eligibleStudents = students.Where(s => s.Marks > 50).ToList();

        Console.WriteLine("\nEligible Students:");
        foreach (var s in eligibleStudents)
        {
            Console.WriteLine(s.Name);
        }
    }
}
