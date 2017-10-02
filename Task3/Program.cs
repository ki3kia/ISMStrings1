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
            Regex reg = new Regex(@"\b([01]\d:[0-5]\d|2[0-3]:[0-5]\d)\b");
            Match m = reg.Match(s);
            while (m.Success)
            {
                if (m.Success)
                {
                    Console.WriteLine($"Найдено: {m.Value}");
                }
                m = m.NextMatch();
            }
            //sekond task
            Regex r = new Regex(@"\b(0[1-9]\.0\d\.19\d{2}|[12]\d\.0\d\.19\d{2}|3[01]\.0\d\.19\d{2}|0[1-9]\.\d\.200\d|[12]\d\.0\d\.200\d|3[01]\.0\d\.200\d|0[1-9]\.1[0-2]\.19\d{2}|[12]\d\.1[0-2]\.19\d{2}|3[01]\.1[0-2]\.19\d{2}|0[1-9]\.1[0-2]\.200\d|[12]\d\.1[0-2]\.200\d|3[01]\.1[0-2]\.200\d)\b");
            Match mat = r.Match(s);
            while (mat.Success)
            {
                if (mat.Success)
                {
                    Console.WriteLine($"Найдено: {mat.Value}");
                }
                mat = mat.NextMatch();
            }
            Regex regex = new Regex(@"\b(198[4-9]|199\d|20[01]\d|202[0-5])\b");
            Match match = regex.Match(s);
            while (match.Success)
            {
                if (match.Success)
                {
                    Console.WriteLine("Год находится в интервале от 1984 до 2025");
                    Console.WriteLine($"Найдено: {match.Value}");
                }
                match = match.NextMatch();
            }
        }
    }
}
