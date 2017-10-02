using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringsMethods;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Введите строку");
            s = Console.ReadLine();
            string max = Strings1.LengthStr(s);
            Console.WriteLine(max);
            int N = Strings1.NumberOfWords(s);
            Console.WriteLine(N);
            int ND;
            ND = Strings1.NumberOfDifferentWords(s);
            Console.WriteLine(ND);
            Strings1.DeleteProbil(ref s);
            Console.WriteLine(s);
        }
    }
}
