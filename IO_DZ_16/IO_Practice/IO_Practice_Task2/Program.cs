using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IO_Practice_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Esetb\source\repos\pwtask2.txt";
            using (StreamWriter stream = new StreamWriter(path))
            {
                stream.WriteLine("Aspandiyar");
                stream.WriteLine("Zhakyp");
                stream.WriteLine("16");
            }
        }
    }
}
