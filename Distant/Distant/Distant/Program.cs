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

    static void Main(string[] args)
    {
        List<Student> allStudents = new List<Student>();
        Random random = new Random();

        Console.WriteLine("--- Создание 100 тестовых студентов ---");

        for (int i = 1; i <= 100; i++)
        {
            Student newStudent = new Student();
            newStudent.Name = "Student " + i;
            newStudent.Course = random.Next(1, 5);
            newStudent.AverageGrade = 3.0 + (random.NextDouble() * 2.0);

            allStudents.Add(newStudent);
        }
        Console.WriteLine("100 студентов успешно созданы.");
        Console.WriteLine("---------------------------------------");
        List<Student> topStudents = FindTop10Students(allStudents);
        Console.WriteLine("\n--- 🎓 ТОП-10 СТУДЕНТОВ ПО СРЕДНЕМУ БАЛЛУ ---");

        int rank = 1;

        foreach (Student s in topStudents)
        {
            Console.WriteLine($"{rank}. {s.Name,-15} (Курс: {s.Course}) - Балл: {s.AverageGrade:F2}");
            rank++;
        }
        Console.WriteLine("-----------------------------------------------");

        Console.ReadKey();
    }
}

