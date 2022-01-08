using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Введите предложение, слова разделены пробелами: ");
            string vvod = Console.ReadLine();
            string[] str = vvod.Split(new Char[] { ' ' });
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
            Console.ReadLine();*/

            Console.WriteLine("Введите предложение, слова разделены пробелами: ");
            string sentence = Console.ReadLine();
            sentence = sentence.Replace(" ", "").ToLower();
            Console.WriteLine(sentence);
            string reverse = new string(sentence.ToCharArray().Reverse().ToArray());
            if (sentence == reverse)
                Console.WriteLine("Это предложение является палидромом");
            if (sentence != reverse)
                Console.WriteLine("Это предложение - не палидром... Начинайте заново.");
            Console.ReadKey();
        }
    }
}
