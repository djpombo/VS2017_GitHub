using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void escreveNaTela(String txt)
        {
            Console.WriteLine(txt);
        }
        static void Main(string[] args)
        {
            String txt = "Alo gitHub";
            escreveNaTela(txt);
            Console.ReadKey();
        }
    }
}
