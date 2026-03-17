using System;
using System.Collections.Generic;
class Bai17
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu //  2415053122346");
        List<int> list17 = new List<int>();
        Console.WriteLine("Nhap vao so luong phan tu:");
        int.TryParse(Console.ReadLine(), out int n);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap vao phan tu thu {i + 1}:");
            int.TryParse(Console.ReadLine(), out int pt);
            list17.Add(pt);
        }
        int maxCount = 0;
        int ptnhieu = list17[0];
        foreach (int pt in list17)
        {
            int count = 0;
            foreach (int item in list17)
            {
                if (item == pt)
                    count++;
            }
            if (count > maxCount)
            {
                maxCount = count;
                ptnhieu = pt;
            }
        }
        Console.WriteLine("So xuat hien nhieu nhat: " + ptnhieu);
        Console.WriteLine("So lan xuat hien: " + maxCount);
    }
}