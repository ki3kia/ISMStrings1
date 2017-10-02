using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringsMethods
{
    public class Strings1
    {
        public static string LengthStr(string s)
        {
            char[]  a = {' '};
            string[] str = s.Split(a, StringSplitOptions.RemoveEmptyEntries);
            string max = str[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > max.Length)
                    max = str[i];
            }
            return max;
        }
        public static int NumberOfWords(string s)
        {
            int N;
            char[] a = { ' ', '(', ')' };
            string[] str = s.Split(a, StringSplitOptions.RemoveEmptyEntries);
            N = str.Length;
            return N;
        }
        public static int NumberOfDifferentWords(string s)
        {
            int N;
            char[] a = { ' ', '(', ')' };
            string[] str = s.Split(a, StringSplitOptions.RemoveEmptyEntries);
            N = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    int c = String.Compare(str[i], str[j]);
                    if (c == 0)
                        N = N - 1;
                }
            }
            return N;
        }
        public static string[] ArrOfDouble(string s)
        {
            char[] a = { ' ', '(', ')' };
            string[] str = s.Split(a, StringSplitOptions.RemoveEmptyEntries);            
            return str;
        }
        public static void DeleteProbil(ref string s)
        {
            char[] a = { ' ' };
            string[] str = s.Split(a, StringSplitOptions.RemoveEmptyEntries);
            s = String.Join(" ", str);
        }
        public static void NamberLifeAndKiev(ref string s)
        {
            Regex reg = new Regex(@"\+38\(063\)-\d{3}-\d{4}|\+38\(093\)-\d{3}-\d{4}|\+38\(073\)-\d{3}-\d{4}");
            Match m = reg.Match(s);
            if (m.Success)
            {
                Console.WriteLine($"Найдено: {m.Value}");
                Console.WriteLine($"Групп: {m.Groups.Count-1}");
                for (int i = 1; i < m.Groups.Count; i++)
                    Console.WriteLine($"Группа №{i}: {m.Groups[i].Value}");
            }
        }
        public static void Email(ref string s)
        {
            Regex reg = new Regex(@"\w+\.gmail\.com|\w+\.mail\.ru|\w+\.mail\.ukr\.net/\w+\.yandex\.ru");
            Match m = reg.Match(s);
            if (m.Success)
            {
                Console.WriteLine($"Найдено: {m.Value}");
                Console.WriteLine($"Групп: {m.Groups.Count - 1}");
                for (int i = 1; i < m.Groups.Count; i++)
                    Console.WriteLine($"Группа №{i}: {m.Groups[i].Value}");
            }
        }
    }
}
