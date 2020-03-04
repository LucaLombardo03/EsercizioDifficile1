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
                using (StreamReader sr = new StreamReader(input))
                {
                    numero = sr.ReadLine();

                }
                using (StreamWriter sw = new StreamWriter(output, false, Encoding.UTF8))
                {
                    int i = 0;
                    do
                    {
                        int lunghezzanumero = 0;
                        do
                        {
                            lunghezzanumero++;

                            i++;
                        } while (numero[i] != '1');

                        string n = numero.Substring(i + 1, lunghezzanumero);
                        int n1 = int.Parse(n);

                        string numerofinale = numero.Substring(i + lunghezzanumero + 1, n1);
                        sw.WriteLine(numero);
                        i += 1 + lunghezzanumero + n1;

                    } while (numero[i] != '*');
                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
            
        }
    }
}
