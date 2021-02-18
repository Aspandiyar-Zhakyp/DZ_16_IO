using System;
using System.IO;
using System.Collections.Generic;

namespace IO_Practice_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> stat = new Dictionary<char, int>();

            using (FileStream stream = new FileStream(@"C:\Users\Esetb\source\repos\README.md", FileMode.OpenOrCreate))
            {
                byte[] bytes = new byte[stream.Length];

                stream.Read(bytes, 0, bytes.Length);

                string data = System.Text.Encoding.Unicode.GetString(bytes);
                foreach (char symbol in data)
                {
                    if (stat.ContainsKey(symbol))
                    {
                        stat[symbol]++;
                    }
                    else
                    {
                        stat[symbol] = 0;
                    }
                }
                Console.WriteLine(data);
            }
            foreach (KeyValuePair<char, int> item in stat)
            {
                Console.WriteLine(item.Key + "\t\t" + item.Value);
            }
            Console.ReadLine();
        }
    }
}
