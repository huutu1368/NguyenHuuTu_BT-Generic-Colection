using System;
using System.Collections.Generic;

class Bai15
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346");
        Dictionary<string, string> tuDien = new Dictionary<string, string>();
        tuDien.Add("Hello", "Xin chao");
        tuDien.Add("Student", "Sinh vien");
        tuDien.Add("Teacher", "Giao vien");
        tuDien.Add("Book", "Quyen sach");
        tuDien.Add("Computer", "May tinh");
        string y = "";
        do
        {
            Console.WriteLine("Nhap tu tieng Anh can tra nghia: ");
            string tuKhoa = Console.ReadLine();
            if (tuDien.TryGetValue(tuKhoa, out string nghiaViet))
            {
                Console.WriteLine($"Nghia cua tu '{tuKhoa}' la: {nghiaViet}");
            }
            else
            {
                Console.WriteLine($"He thong chua cap nhat tu: {tuKhoa} nay. Vui long thu lai!");
            }
            Console.WriteLine("Nhap y de tiep tuc tra hoac bat ky de thoat:");
            y = Console.ReadLine();

        }
        while (y == "y" || y == "Y");
        Console.WriteLine("\n--- Cac tu dang co trong he thong ---");
        foreach (KeyValuePair<string, string> item in tuDien)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        Console.WriteLine("Cam on da su dung chuong trinh!");
    }
}