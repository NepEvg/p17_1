using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace p17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strok = File.ReadAllLines("file.txt");
            string[] text = File.ReadAllText(@"file.txt").Replace("\n", " ").Split(" ");
            if (strok.Length != 0)
            {
                List<string> list = new List<string>();
                for (int i = 0; i < text.Length; i++)
                {
                    string slovo = text[i], gotovoe = "";
                    for (int j = 0; j < slovo.Length; j++)
                    {
                        if (slovo[j] != '.' && slovo[j] != ',' && slovo[j] != '!' && slovo[j] != '?')
                        {
                            gotovoe += slovo[j];
                        }
                        else { break; }
                    }
                    list.Add(gotovoe.ToUpper());
                }
                Console.Write("введите слово: ");
                string p = Console.ReadLine();
                var num = list.Where(u => u == p.ToUpper()).Count();
                Console.WriteLine($"были найдены {num} вхождения(ий) поискового запроса \"{p}\"");
            }
            else { Console.WriteLine("файл пустой"); }
            
        }
    }
}
