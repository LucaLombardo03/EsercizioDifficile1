﻿using System;
using System.IO;

namespace EsercizioDifficile1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fileinput = "input.txt";
            string numeri = "";
            if(File.Exists(fileinput))
            try
            {
                using (StreamReader sr = new StreamReader(fileinput))
                {
                    numeri = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}