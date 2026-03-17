using System;
using System.Collections.Generic;
class bai3
{
    public static void  Main(String[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346");
        List<int> list3 = new List<int>();
        Console.WriteLine("nhap so luong phan tu:");
        int.TryParse(Console.ReadLine(), out var n);
        if (n<0)
        {
            Console.WriteLine("danh sach trong, khong co so lon nhat");
            return;
        }
        for(int i=0; i < n; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i+1}");
            int.TryParse(Console.ReadLine(), out var pt);
            list3.Add(pt);
        }
        int max = list3[0];
        foreach ( var pt in list3)
        {
            if(pt> max)
            {
                max = pt;
            }
        }
        Console.WriteLine($"so lon nhat trong danh sach la: {max}");
    }
}