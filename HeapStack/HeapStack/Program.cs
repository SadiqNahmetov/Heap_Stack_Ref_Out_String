using System;

namespace HeapStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Gulperi";
            string count = ReverseWords(name);
            Console.WriteLine(count);
                                  
        }


        static string ReverseWords(string name)
        {
            string count = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                count += name[i];
            }
            return count;


        }


    }
}
