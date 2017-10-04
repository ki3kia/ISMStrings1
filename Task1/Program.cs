using StrMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Введите строку");
            s = Console.ReadLine();

            bool b = Str.Brackets(s);
            if (b == true)
                Console.WriteLine("Количество открытых и закрытых скобок совпадает");
            else Console.WriteLine("Количество открытых и закрытых скобок не совпадает");

            string max = Str.LengthStr(s);
            Console.WriteLine($"Самое длинное слово: {max}");

            int N = Str.NumberOfWords(s);
            Console.WriteLine($"Количество слов: {N}");

            int a = Str.NumberOfDifferentWords(s);
            Console.WriteLine($"Количество разных слов: {a}");

            Str.ArrOfDouble(s, out string[] str);
            Console.WriteLine("Массив слов с удвоенными буквами");
            foreach (string k in str)
            {
                Console.WriteLine($"{k}");
            }

            Str.DeleteProbil(ref s);
            Console.WriteLine($"Строка без лишних пробелов: {s}");

            Str.Seven(s, out string str1);
            Console.WriteLine($"Изменены певая и последняя буквы: {str1}");

            string n = Str.OddLetter(s);
            Console.WriteLine($"{n}");
        }
    }
}
