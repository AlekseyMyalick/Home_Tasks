using System;

namespace DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lines lines = new Lines("jjjsnn\ndsds");
            Console.WriteLine(lines.Line);
            Console.WriteLine(lines.LineLength);
            Console.WriteLine(lines.Counting());
        }
    }
}
