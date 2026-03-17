using System;
using System.Collections.Generic;
class Bai10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346.");
        List<int> list10 = new List<int>();
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
            int.TryParse(Console.ReadLine(), out var pt);
            list10.Add(pt);
        }
        int min = list10[0];
        foreach (var pt in list10)
        {
            if (pt < min)
            {
                min = pt;
            }
        }
        Console.WriteLine($"So nho nhat trong danh sach la:{min}");
    }
}