using System;
using System.Collections.Generic;
public class Student
{
    public string Name { get; set; }
    public double Score { get; set; }
    public Student(string name, double score)
    {
        Name = name;
        this.Score = score;
    }
    public Student()
    {
    }
}
class Bai18
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346");
        List<Student> students = new List<Student>();
        students.Add(new Student("Van A", 5));
        students.Add(new Student("Van B", 7));
        students.Add(new Student("Van C", 10));
        Console.WriteLine("Danh sach sinh vien:");
        foreach (var student in students)
        {
            Console.WriteLine($"Ten: {student.Name} || Diem: {student.Score}");
        }
        Student hs = students[0];
        foreach (var student in students)
        {
            if (student.Score > hs.Score)
            {
                hs = student;
            }
        }
        Console.WriteLine($"Thong tin sinh vien co diem cao nhat: Name:{hs.Name} || Score:{hs.Score}");
    }
}