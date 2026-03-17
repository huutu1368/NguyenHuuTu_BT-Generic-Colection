using System;
using System.Collections.Generic;
class Bai9
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346");
        List<int> list9 = new List<int>();
        Console.WriteLine("Nhap so luong phan tu:");
        int.TryParse(Console.ReadLine(), out var n);
        if (n <= 0)
        {
            Console.WriteLine("Danh sach rong!");
            return;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i + 1}");
            int.TryParse(Console.ReadLine(), out var pt);
            list9.Add(pt);
        }
        List<int> newlist = new List<int>();
        foreach (int pt in list9)
        {
            if (!newlist.Contains(pt))
            {
                newlist.Add(pt);
            }
        }
        Console.Write("Danh sach phan tu moi (khong chua phan tu trung):");
        foreach (int pt in newlist)
        {
            Console.Write($"{pt} ");
        }
    }
}