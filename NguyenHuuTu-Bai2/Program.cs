using System;
using System.Collections.Generic;
class Bai2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346");
        List<int> list2 = new List<int>();
        Console.WriteLine("Nhap so luong phan tu: ");
        int.TryParse(Console.ReadLine(), out var n);
        for (int i=0; i<n; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i + 1}");
            int.TryParse(Console.ReadLine(), out var pt);
            list2.Add(pt);
        }
        int tong = 0;
        foreach(var pt in list2)
        {
            tong = tong + pt;
        }
        Console.WriteLine($"Tong cua cac phan tu la: {tong}");
    }
}