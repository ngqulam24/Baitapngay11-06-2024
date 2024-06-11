using System;
class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("\nBài 9: Viết chương trình C#.");
            Console.WriteLine("a. Viết một chương trình nhận vào một chuỗi kí tự từ người dùng và đảo ngược chuỗi đó.");
            Console.WriteLine("b. Viết một chương trình nhận vào một chuỗi kí tự từ người dùng và đếm số lượng từ trong chuỗi đó.");
            Console.WriteLine("x. Thoát chương trình.");
            Console.Write("\nMời nhập lựa chọn của bạn: ");
            choice = char.Parse(Console.ReadLine());
            switch (choice)
            {
                case 'a':
                    bai9a();
                    break;
                case 'b':
                    bai9b();
                    break;
                case 'x':
                    Console.WriteLine("\nĐã thoát chương trình!");
                    break;
                default:
                    Console.WriteLine("\nBạn đã nhập sai lựa chọn!");
                    break;
            }
        } while (choice != 'x');
    }

    static void bai9a()
    {
        Console.Write("\nNhập chuỗi: ");
        string input = Console.ReadLine();

        string reversedString = Reverse(input);
        Console.WriteLine("Chuỗi đảo ngược: " + reversedString);
    }

    static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void bai9b() 
    {
        Console.Write("\nNhập chuỗi: ");
        string input = Console.ReadLine();

        int wordCount = CountWords(input);
        Console.WriteLine("Số lượng từ: " + wordCount);
    }

    static int CountWords(string s)
    {
        string[] words = s.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}