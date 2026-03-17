using System;
using System.Collections.Generic;

class Bai5
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346");

        List<string> list5 = new List<string>();

        Console.WriteLine("Nhap so luong sinh vien: ");
        int.TryParse(Console.ReadLine(), out var n);

        if (n <= 0)
        {
            Console.WriteLine("Danh sach rong");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap sinh vien thu {i + 1}: ");
            string pt = Console.ReadLine();
            list5.Add(pt);
        }

        Console.WriteLine("Nhap ten sinh vien can xoa:");
        string ten = Console.ReadLine();

        if (list5.Contains(ten))
        {
            while (list5.Contains(ten))
            {
                list5.Remove(ten);
            }
            Console.WriteLine($"Da xoa sinh vien co ten {ten}");
        }
        else
        {
            Console.WriteLine("Khong tim thay ten sinh vien de xoa");
        }

        Console.WriteLine("Danh sach sinh vien la:");
        foreach (var pt in list5)
        {
            Console.WriteLine(pt);
        }
    }
}