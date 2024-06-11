using System;
using System.Text;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("\nBài 8: Viết chương trình C#.");
            Console.WriteLine("a. Viết một chương trình hiển thị bảng mã ASCII.");
            Console.WriteLine("b. Viết chương trình để hiển thị bảng mã UTF-8 của trang mã 65001.");
            Console.WriteLine("c. Viết chương trình phát tiếng beep khi nhấn phím space.");
            Console.WriteLine("d. Viết chương trình nhập vào một chuỗi kí tự từ người dùng, đếm số lần xuất hiện của mỗi kí tự trong chuỗi và hiển thị kết quả đếm.");
            Console.WriteLine("x. Thoát chương trình.");
            Console.Write("\nMời nhập bài của bạn: ");
            choice = char.Parse(Console.ReadLine());
            switch (choice)
            {
                case 'a':
                    bai8a();
                    break;
                case 'b':
                    bai8b();
                    break;
                case 'c':
                    bai8c();
                    break;
                case 'd':
                    bai8d();
                    break;
                case 'x':
                    Console.WriteLine("\nĐã thoát chương trình!");
                    break;
                default:
                    Console.WriteLine("\nLựa chọn của bạn không phù hợp.");
                    break;
            }
        } while (choice != 'x');
    }
    static void bai8a()
    {
        Console.WriteLine("\nBảng mã ASCII:");
        Console.WriteLine("Char\tASCII");
        Console.WriteLine("-------------------");
        for (int i = 0; i < 128; i++)
        {
            Console.WriteLine((char)i + "\t" + i);
        }
    }

    static void bai8b()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("\nBảng mã UTF-8 của trang mã 65001:");
        Console.WriteLine("Char\tUnicode");
        Console.WriteLine("-------------------");
        for (int i = 0; i < 65536; i++)
        {
            Console.WriteLine((char)i + "\t" + i);
        }
    }

    static void bai8c()
    {
        Console.WriteLine("\nNhấn phím space để phát tiếng beep. Nhấn ESC để thoát.");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Spacebar)
            {
                Console.Beep();
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }

    static void bai8d() 
    {
        Console.Write("\nNhập chuỗi ký tự: ");
        string input = Console.ReadLine();

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        Console.WriteLine("Kết quả đếm:");
        foreach (KeyValuePair<char, int> kvp in charCount)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} lần");
        }
    }
}