using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using StrMethods;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Введите строку");
            s = Console.ReadLine();

            Reg.LifeAndKiev(ref s, out Match m);
            if (m.Success)
            {
                Console.WriteLine($"Найдено: {m.Value}");
                Console.WriteLine($"Групп: {m.Groups.Count - 1}");
                for (int i = 1; i < m.Groups.Count; i++)
                    Console.WriteLine($"Группа №{i}: {m.Groups[i].Value}");
            }

            Reg.Data(s, out MatchCollection mat);
            if (mat.Count > 0)
            {
                foreach (Match n in mat)
                {
                    Console.WriteLine($"Найдено: {n.Value}");
                    for (int i = 1; i < n.Groups.Count; i++)
                        Console.WriteLine($"{n.Groups[i].Value}");
                }
            }

            Reg.Stud(s, out MatchCollection mtch);
            if (mtch.Count > 0)
            {
                foreach (Match n in mtch)
                {
                    Console.WriteLine($"Найдено номеров студенческих билетов: {n.Value}");
                    for (int i = 1; i < n.Groups.Count; i++)
                        Console.WriteLine($"{n.Groups[i].Value}");
                }
            }
        }
    }
}
