using System;
using System.IO;

struct Student
{
    public string Name;
    public double Score;
}
class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("\nBài 10: Viết một chương trình cho phép người dùng nhập thông tin của n sinh viên gồm tên và điểm,\nở đó n được nhập từ bàn phím. Sau đó, hiển thị thông tin của từng sinh viên và tính điểm trung\nbình của cả lớp. Sử dụng cấu trúc (struct) để lưu trữ thông tin của sinh viên.");
            Console.WriteLine("\nBài 11: Viết một chương trình cho phép người dùng nhập nội dung và tên file từ bàn phím. Chương trình\nsau đó ghi nội dung vào file văn bản và sau đó đọc nội dung từ file và hiển thị lên màn hình.");
            Console.WriteLine("\n0. Thoát chương trình.");
            Console.Write("\nMời nhập lựa chọn của bạn: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 10:
                    bai10();
                    break;
                case 11:
                    bai11();
                    break;
                case 0:
                    Console.WriteLine("\nĐã thoát chương trình!");
                    break;
                default:
                    Console.WriteLine("\nBạn đã nhập sai lựa chọn!");
                    break;
            }
        } while (choice != 0);
    }

    static void bai10()
    {
        Console.Write("Nhập số lượng sinh viên: ");
        int n = int.Parse(Console.ReadLine());

        Student[] students = new Student[n];

        // Nhập thông tin sinh viên
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nSinh viên {i + 1}:");
            Console.Write("Tên: ");
            students[i].Name = Console.ReadLine();
            Console.Write("Điểm: ");
            students[i].Score = double.Parse(Console.ReadLine());
        }

        // Hiển thị thông tin sinh viên và tính điểm trung bình
        double totalScore = 0;
        Console.WriteLine("\nThông tin sinh viên:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nSinh viên {i + 1}");
            Console.WriteLine($"Tên: {students[i].Name}, Điểm: {students[i].Score}");
            totalScore += students[i].Score;
        }

        double averageScore = totalScore / n;
        Console.WriteLine($"\nĐiểm trung bình của cả lớp: {averageScore}");
    }

    static void bai11() 
    {
        // Nhập tên file
        Console.Write("Nhập tên file: ");
        string fileName = Console.ReadLine();

        // Nhập nội dung
        Console.WriteLine("Nhập nội dung (nhấn Enter để kết thúc):");
        string content = "";
        string line;
        while ((line = Console.ReadLine()) != "")
        {
            content += line + "\n";
        }

        // Ghi nội dung vào file
        try
        {
            File.WriteAllText(fileName, content);
            Console.WriteLine("Nội dung đã được ghi vào file.");
        }
        catch (IOException e)
        {
            Console.WriteLine($"Lỗi khi ghi file: {e.Message}");
        }

        // Đọc nội dung từ file và hiển thị
        try
        {
            string readContent = File.ReadAllText(fileName);
            Console.WriteLine("\nNội dung trong file:");
            Console.WriteLine(readContent);
        }
        catch (IOException e)
        {
            Console.WriteLine($"Lỗi khi đọc file: {e.Message}");
        }
    }
}