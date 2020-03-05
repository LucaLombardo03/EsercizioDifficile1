using System;
using System.IO;
using System.Text;

namespace EsercizioDifficile1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const string input = "input.txt";
                const string output = "output.txt";
                string numero;
                string numerointermedio;
                string numerofinale;
                string uno;
                int i = 0;
                using (StreamReader sr = new StreamReader(input))
                {
                    numero = sr.ReadLine();
                }
                using (StreamWriter sw = new StreamWriter(output, false, Encoding.UTF8))
                {
                    int found = 0;
                    found = numero.IndexOf("1");
                    uno = numero.Substring(found + 1);
                    numerointermedio = uno.Substring(found);
                    i = numerointermedio.Length - 1;
                    numerofinale = numerointermedio.Substring(0, i);
                    sw.WriteLine(numerofinale);
                    Console.WriteLine("il numero è stato scritto sul file output.txt");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }
    }
}
