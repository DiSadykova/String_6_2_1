using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_6_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите с клавиатуры предложение");
            string startString = Console.ReadLine();
            
            string[] word = startString.Split();
            int lengthArray = word.Length;
            int lengthWord;
            int maxLengthWord=0;
            for (int i = 0; i < lengthArray; i++)
            {
                lengthWord = word[i].Length;
                if (lengthWord > maxLengthWord)
                {
                    maxLengthWord = lengthWord;
                }
            }
            for (int i = 0; i < lengthArray; i++)
            {
                lengthWord = word[i].Length;
                if (lengthWord == maxLengthWord)
                {
                    Console.WriteLine(word[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
