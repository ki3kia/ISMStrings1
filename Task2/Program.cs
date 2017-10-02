using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringsMethods;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Введите строку");
            s = Console.ReadLine();
            Regex reg = new Regex(@"\+38\(063\)-\d{3}-\d{4}|\+38\(093\)-\d{3}-\d{4}|\+38\(073\)-\d{3}-\d{4}");
            Match m = reg.Match(s);
            if (m.Success)
            {
                Console.WriteLine($"Найдено: {m.Value}");
                Console.WriteLine($"Групп: {m.Groups.Count - 1}");
                for (int i = 1; i < m.Groups.Count; i++)
                    Console.WriteLine($"Группа №{i}: {m.Groups[i].Value}");
            }
            Regex regex = new Regex(@"\w*\W*\@.gmail\.com|\w+\@.mail\.ru|\w+\@.mail\.ukr\.net/\w+\@.yandex\.ru");
            MatchCollection match = reg.Matches(s);
            if (match.Count > 0)
            {
                foreach(Match n in match)
                {
                    Console.WriteLine($"Найдено: {n.Value}");
                    Console.WriteLine($"Групп: {n.Groups.Count - 1}");
                    for (int i = 1; i < n.Groups.Count; i++)
                        Console.WriteLine($"Группа №{i}: {n.Groups[i].Value}");
                }
            }
            Regex r = new Regex(@"\b(0[1-9]\.0\d\.19\d{2}|[12]\d\.0\d\.19\d{2}|3[01]\.0\d\.19\d{2}|0[1-9]\.\d\.200\d|[12]\d\.0\d\.200\d|3[01]\.0\d\.200\d|0[1-9]\.1[0-2]\.19\d{2}|[12]\d\.1[0-2]\.19\d{2}|3[01]\.1[0-2]\.19\d{2}|0[1-9]\.1[0-2]\.200\d|[12]\d\.1[0-2]\.200\d|3[01]\.1[0-2]\.200\d)\b");
            MatchCollection mat = r.Matches(s);
            if (mat.Count > 0)
            {
                foreach (Match n in mat)
                {
                    Console.WriteLine($"Найдено: {n.Value}");
                    Console.WriteLine($"Групп: {n.Groups.Count - 1}");
                    for (int i = 1; i < n.Groups.Count; i++)
                        Console.WriteLine($"Группа №{i}: {n.Groups[i].Value}");
                }
            }
            Regex rgx = new Regex(@"№([1-9]d{7})");
            Match mtch = rgx.Match(s);
            if (mtch.Success)
            {
                Console.WriteLine($"Найдено: {mtch.Value}");
                Console.WriteLine($"Групп: {mtch.Groups.Count - 1}");
                for (int i = 1; i < mtch.Groups.Count; i++)
                    Console.WriteLine($"Группа №{i}: {mtch.Groups[i].Value}");
            }
        }
    }
}
