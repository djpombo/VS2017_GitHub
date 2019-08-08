using System;

namespace ConsoleApp1
{
    class Program
    {
        static void escreveNaTela()
        {
            Console.WriteLine("vamos fazer um terceiro commit!");
        }
        static void escreveNaTela2(String txt)
        {
            Console.WriteLine(txt);
        }
        static void escreveNaTela3(String txt)
        {
            escreveNaTela2(txt);
        }
        static void Main(string[] args)
        {
            escreveNaTela();
            escreveNaTela2("alo gitHub");
            escreveNaTela3("carniça");
            Console.ReadKey();
        }
    }
}
