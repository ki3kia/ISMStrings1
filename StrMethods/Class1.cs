using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StrMethods
{
    public class Str
    {
        public static bool Brackets(string s)
        {
            bool b = false;
            int k1 = 0, k2 = 0;
            for (int i=0; i<s.Length; i++)
            {
                bool b1 = false;
                b1 = s.Substring(i, 1).Equals("(");
                if (b1 == true)
                    k1++;
                bool b2 = false;
                b2 = s.Substring(i, 1).Equals(")");
                if (b2 == true)
                    k2++;
                if (k1 == k2)
                    b = true;
            }
            return b;
        }
        public static string LengthStr(string s)
        {
            char[] a = { ' ' };
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
            char[] a = { ' ', '(', ')', ',', '.' };
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
        public static void ArrOfDouble(string s, out string[] str1)
        {
            char[] a = { ' ', '(', ')', ',', '.' };
            string[] str = s.Split(a, StringSplitOptions.RemoveEmptyEntries);
            string s1 = " ";
            foreach(string m in str)
            {
                if (m.Length > 1)
                {
                    for (int i = 0; i < m.Length - 1; i++)
                    {
                        bool b = false;
                        b = m.Substring(i, 1).Equals(m.Substring(i + 1, 1));
                        if (b == true)
                        {
                            s1 = s1.Insert(s1.Length, " ");
                            s1 = s1.Insert(s1.Length, m);
                            break;
                        }
                    }
                }
                else continue;
            }
            str1 = s1.Split( a, StringSplitOptions.RemoveEmptyEntries);
        }
        public static void DeleteProbil(ref string s)
        {
            char[] a = { ' ' };
            string[] str = s.Split(a, StringSplitOptions.RemoveEmptyEntries);
            s = String.Join(" ", str);
        }
        public static void Seven(string s, out string str)
        {
            char[] a = { ' ', '(', ')', ',', '.' };
            string n;
            str = null;
            int n1 = 0;
            string[] s1 = s.Split(a, StringSplitOptions.RemoveEmptyEntries);
            foreach (string m in s1)
            {
                n1 = m.Length - 1;
                n = m;
                n = n.Replace(n[0], m[n1]);
                n = n.Replace(n[n1], m[0]);
                str = str + " " + n;
            }
        }
        public static string OddLetter(string s)
        {
            char[] a = { ' ', '(', ')', ',', '.' };
            string n = null;
            bool b;
            int c = 0;
            string[] m = { "а", "е", "є", "и", "і", "ї", "о", "у", "ю", "я" };
            string[] s1 = s.Split(a, StringSplitOptions.RemoveEmptyEntries);
            foreach(string k in s1)
            {
                int d = 0;
                for (int i =0; i < k.Length; i++)
                {
                    for (int j=0; j < m.Length; j++)
                    {
                        b = false;
                        b = s.Substring(i, 1).Equals(a[j]);
                        if (b == true)
                            d++;
                    }
                    c = k.Length - d;
                }

                if (c % 2 != 0)
                    n += k;
            }
            return n;
        }
    }
    public class Reg
    {
        public static void LifeAndKiev(ref string s, out Match match)
        {
            Regex reg = new Regex(@"\+38\(063\)-\d{3}-\d{4}|\+38\(093\)-\d{3}-\d{4}|\+38\(073\)-\d{3}-\d{4}");
            match = reg.Match(s);
        }
        public static void Data(string s, out MatchCollection match)
        {
            Regex regex = new Regex(@"\b(0[1-9]\.0\d\.19\d{2}|[12]\d\.0\d\.19\d{2}|3[01]\.0\d\.19\d{2}|0[1-9]\.0\d\.200\d|[12]\d\.0\d\.200\d|3[01]\.0\d\.200\d|0[1-9]\.1[0-2]\.19\d{2}|[12]\d\.1[0-2]\.19\d{2}|3[01]\.1[0-2]\.19\d{2}|0[1-9]\.1[0-2]\.200\d|[12]\d\.1[0-2]\.200\d|3[01]\.1[0-2]\.200\d|0[1-9]\.1[0-2]\.20\d{2}|[12]\d\.1[0-2]\.20\d{2}|3[01]\.1[0-2]\.20\d{2}|0[1-9]\.0\d\.20\d{2}|[12]\d\.0\d\.20\d{2}|3[01]\.0\d\.20\d{2})\b");
            match = regex.Matches(s);
        }
        public static void Stud(string s, out MatchCollection match)
        {
            Regex regex = new Regex(@"№([1-9]d{7})");
            match = regex.Matches(s);
        }
        public static void CorrectTime(string s, out Match match)
        {
            Regex regex = new Regex(@"\b([01]\d:[0-5]\d|2[0-3]:[0-5]\d)\b");
            match = regex.Match(s);
        }
        public static void DateInterval(string s, out Match match, out Match mat)
        {
            Regex regex = new Regex(@"\b(0[1-9]\.0\d\.19\d{2}|[12]\d\.0\d\.19\d{2}|3[01]\.0\d\.19\d{2}|0[1-9]\.\d\.200\d|[12]\d\.0\d\.200\d|3[01]\.0\d\.200\d|0[1-9]\.1[0-2]\.19\d{2}|[12]\d\.1[0-2]\.19\d{2}|3[01]\.1[0-2]\.19\d{2}|0[1-9]\.1[0-2]\.200\d|[12]\d\.1[0-2]\.200\d|3[01]\.1[0-2]\.200\d)\b");
            match = regex.Match(s);
            Regex reg = new Regex(@"\b(198[4-9]|199\d|20[01]\d|202[0-5])\b");
            mat = reg.Match(s);
        }
    }
}
