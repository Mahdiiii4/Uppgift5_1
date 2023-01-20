using System;
namespace Uppgift5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text= new string[4];
            text[0]= "Manen dricker kaffe";
            text[1] = "Katten springer iväg";
            text[2] = "Datoren fungerar inte";
            text[3] = "Solen skiner";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(text[i]);
                Console.WriteLine("");
            }
        }
    }
}