using System;
using System.Collections.Generic;
class Bai4
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346");
        List<int> list4 = new List<int>();
        Console.WriteLine("nhap so luong phan tu:");
        int.TryParse(Console.ReadLine(), out var n);
        if (n<0)
        {
            Console.WriteLine("danh sach rong");
            return;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap phan tu thu: {i + 1}");
            int.TryParse(Console.ReadLine(), out var pt);
            list4.Add(pt);
        }
        int count = 0;
        foreach(var pt in list4)
        {
            if (pt % 2 == 0)
                count = count + 1;
        }
        Console.WriteLine($"So luong phan tu chan la: {count}");
    }
}