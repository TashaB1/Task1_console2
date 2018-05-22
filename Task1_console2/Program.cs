using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_console2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\Resources\text.txt";

            try
            {
                Console.WriteLine("******считываем весь файл********");
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

                /*  Console.WriteLine();
                  Console.WriteLine("******считываем построчно********");
                  using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                  {
                      string line;
                      while ((line = sr.ReadLine()) != null)
                      {
                          Console.WriteLine(line);
                      }
                  }*/
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.Write("Press <Enter>");
                Console.ReadLine();
            }
        }
    }
}
