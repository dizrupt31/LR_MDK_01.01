using System;
using System.Collections.Generic;
using System.Linq; 

public class Student
{
    public string Name;
    public int Course;
    public double AverageGrade;
}

public class Program
{
    public static List<Student> FindTop10Students(List<Student> allStudents)
    {
        List<Student> top10 = allStudents
                                .OrderByDescending(s => s.AverageGrade)
                                .Take(10)
                                .ToList();

        return top10;
    }
}

