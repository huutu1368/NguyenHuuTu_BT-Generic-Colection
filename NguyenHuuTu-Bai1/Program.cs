using System;
class Bai1
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2425053122346");
        Console.WriteLine("Bai 1");
        List<int> list1 = new List<int>();
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        list1.Add(4);
        list1.Add(5);
        Console.WriteLine(" Danh sach cac phan tu:");
        foreach (var pt in list1)
        {
            Console.WriteLine(pt);
        }
    }
}