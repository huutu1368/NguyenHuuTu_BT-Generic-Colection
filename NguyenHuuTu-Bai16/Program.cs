using System;
using System.Collections.Generic;

class Bai16
{
    static void Main()
    {
        Console.WriteLine("Nguyen Huu Tu //  2415053122346");
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();
        Dictionary<char, int> dem = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (dem.ContainsKey(c))
                dem[c] = dem[c] + 1;
            else
                dem[c] = 1;
        }
        Console.WriteLine("\nKet qua:");
        foreach (var item in dem)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}