using StrMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Введите строку");
            s = Console.ReadLine();
            //first task
            Reg.CorrectTime(s, out Match m);
            while (m.Success)
            {
                if (m.Success)
                {
                    Console.WriteLine($"Найдено: {m.Value}");
                }
                m = m.NextMatch();
            }
            //sekond task
            Reg.DateInterval(s, out Match mat, out Match match);
            while (mat.Success)
            {
                if (mat.Success)
                {
                    Console.WriteLine($"Найдено: {mat.Value}");
                }
                mat = mat.NextMatch();
            }
            while (match.Success)
            {
                if (match.Success)
                {
                    Console.WriteLine("Год находится в интервале от 1984 до 2025");
                    Console.WriteLine($"Найдено: {match.Value}");
                }
                match = match.NextMatch();
            }
            Reg.FindIPv4(s, out Match mth);
            while (mth.Success)
            {
                if (mth.Success)
                {
                    Console.WriteLine("Ряд - адрес IPv4");
                }
                else Console.WriteLine("Ряд не является адресом IPv4");
            }
            Reg.FindEmail(s, out Match mtch);
            while (mtch.Success)
            {
                if (mtch.Success)
                {
                    Console.WriteLine("Найденные e-mail адреса");
                    Console.WriteLine($"Найдено: {mtch.Value}");
                }
                match = match.NextMatch();
            }
        }
    }
}
