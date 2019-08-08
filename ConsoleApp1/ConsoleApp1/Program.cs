using System;

namespace ConsoleApp1
{
    class Program
    {
        static void escreveNaTela()
        {
            Console.WriteLine("vamos fazer um terceiro commit!");
        }
        static void escreveNaTela3(String txt)
        {
            Console.WriteLine(txt);
        }
        static void Main(string[] args)
        {
            escreveNaTela();
            escreveNaTela3("versao beta!");
            Console.ReadKey();
        }
    }
}
