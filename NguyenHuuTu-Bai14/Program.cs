using System;
using System.Collections.Generic;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Student(int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
}
class Bai14
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346");
        List<Student> students = new List<Student>();
        students.Add(new Student(1, "Van A"));
        students.Add(new Student(2, "Van B"));
        students.Add(new Student(3, "Van C"));
        students.Add(new Student(4, "Van D"));
        students.Add(new Student(5, "Van E"));
        Console.WriteLine($"Danh sach sinh vien:");
        foreach (Student student in students)
        {
            Console.WriteLine($"ID:{student.Id} || Name:{student.Name}");
        }
        Console.WriteLine("Nhap id sinh vien can xoa:");
        int.TryParse(Console.ReadLine(), out int id);
        int xoa = 0;
        for (int i = students.Count - 1; i >= 0; i--)
        {
            if (students[i].Id == id)
            {
                students.RemoveAt(i);
                xoa++;
            }
        }
        if (xoa != 0)
        {
            Console.WriteLine($"Da xoa sinh vien voi id {id}");
            Console.WriteLine("Danh sach sinh vien sau khi xoa la:");
            foreach (Student student in students)
            {
                Console.WriteLine($"ID:{student.Id} || Name:{student.Name}");
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien de xoa");
        }
    }
}