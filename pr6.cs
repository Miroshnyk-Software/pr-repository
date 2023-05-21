// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.IO;

namespace Pr6
{
    class Program
    {

        static void Main(string[] args)
        {
            String line;
            List<String[]> matrix = new List<String[]>();
            try
            {
                StreamReader streamReader = new StreamReader("matrix.txt");

                line = streamReader.ReadLine();
                while (line != null)
                {
                    matrix.Add(line.Split(" "));
                    line = streamReader.ReadLine();
                }

                streamReader.Close();
                foreach (String[] str in matrix)
                {
                    foreach (String strMatrix in str)
                    {
                        Console.Write(strMatrix + " ");
                    }
                    Console.WriteLine();
                }

                int sum = 0;
                int index = 0;
                foreach (String[] str in matrix)
                {
                    sum += Int32.Parse(str[index]);
                    index++;
                }

                Console.WriteLine("\n—ÛÏ‡: " + sum);

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }



    }
}
