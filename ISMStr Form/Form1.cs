using StrMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISMStr_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            s = textBox1.Text;
            bool b = Str.Brackets(s);
            if (b == true)
               label3.Text = "Количество открытых и закрытых скобок совпадает";
            else label3.Text = "Количество открытых и закрытых скобок не совпадает";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string max = Str.LengthStr(s);
            label5.Text = $"Самое длинное слово: {max}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int N = Str.NumberOfWords(s);
            label6.Text = $"Количество слов: {N}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int a = Str.NumberOfDifferentWords(s);
            label8.Text = $"Количество разных слов: {a}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            Str.ArrOfDouble(s, out string[] str);
            Console.WriteLine("Массив слов с удвоенными буквами");
            foreach (string k in str)
            {
               label10.Text = $"{k}";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            Str.DeleteProbil(ref s);
            label12.Text = $"Строка без лишних пробелов: {s}";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            Str.Seven(s, out string str1);
            label14.Text = $"Изменены певая и последняя буквы: {str1}";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string n = Str.OddLetter(s);
            label14.Text = $"{n}";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            Reg.LifeAndKiev(ref s, out Match m);
            if (m.Success)
            {
                label18.Text = $"Найдено: {m.Value}";
                label20.Text = $"Групп: {m.Groups.Count - 1}";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            Reg.Data(s, out MatchCollection mat);
            if (mat.Count > 0)
            {
                foreach (Match n in mat)
                {
                    label22.Text = $"Найдено: {n.Value}";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            Reg.Stud(s, out MatchCollection mtch);
            if (mtch.Count > 0)
            {
                foreach (Match n in mtch)
                {
                    label21.Text = $"Найдено номеров студенческих билетов: {n.Value}";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            Reg.CorrectTime(s, out Match m);
            while (m.Success)
            {
                if (m.Success)
                {
                    label26.Text = $"Найдено: {m.Value}";
                }
                m = m.NextMatch();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            Reg.DateInterval(s, out Match mat, out Match match);
            while (mat.Success)
            {
                mat = mat.NextMatch();
            }
            while (match.Success)
            {
                if (match.Success)
                {
                    label26.Text = $"Найдено: {match.Value}";
                }
                match = match.NextMatch();
            }
        }
    }
}
