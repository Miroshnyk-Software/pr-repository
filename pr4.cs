// See https://aka.ms/new-console-template for more information
using System;

namespace Pr4
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n����i�� ����� ������:");
                String firstString = Console.ReadLine();

                Console.WriteLine("����i�� ����� ������:");
                String secondString = Console.ReadLine();

                Console.WriteLine("\n����� �������� � �i��� ������� ����� �����," +
                    "���������� ����������: " + stringPermutationRepeated(firstString, secondString) + "\n");
                Console.WriteLine("\n����� �������� � �i��� ������� ����� �����: " +
                    stringPermutation(firstString, secondString) + "\n");
            }


            Console.ReadLine();

        }

        public static Boolean stringPermutationRepeated(String firstString, String secondString)
        {
            char[] charArray = secondString.ToCharArray();
            foreach (char c in charArray)
            {
                if (!firstString.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static Boolean stringPermutation(String firstString, String secondString)
        {
            char[] charArray = secondString.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i] + " : " + stringCountChars(firstString, charArray[i]) + " | " + stringCountChars(secondString, charArray[i]));
                if (stringCountChars(secondString, charArray[i]) > (stringCountChars(firstString, charArray[i])))
                {
                    return false;
                }
            }
            return true;
        }

        public static int stringCountChars(String strInput, char charInput)
        {
            int count = 0;
            char[] charArray = strInput.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == charInput)
                {
                    count++;
                }
            }

            return count;
        }



    }
}
