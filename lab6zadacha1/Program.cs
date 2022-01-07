using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение, слова разделены пробелами: ");
            string vvod = Console.ReadLine();
            string[] str = vvod.Split(new Char[] {' '});
            int maxSlo = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxSlo)
                {
                    maxSlo = str[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", str[index]);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
