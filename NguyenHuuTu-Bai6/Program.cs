using System;
using System.Collections.Generic;
class Bai6
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346");
        List<string> list6 = new List<string>();
        Console.WriteLine("Nhap so luong phan tu:");
        int.TryParse(Console.ReadLine(), out var n);
        if (n <= 0)
        {
            Console.WriteLine("Danh sach rong");
            return;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i + 1}");
            String pt = Console.ReadLine();
            list6.Add(pt);
        }
        Console.WriteLine("Nhap phan tu can kiem tra:");
        String ten = Console.ReadLine();
        if (list6.Contains(ten))
        {
            Console.WriteLine($"Ton tai phan tu {ten}");
        }
        else
            Console.WriteLine($"Khong ton tai phan tu {ten}");
    }
}