using System;
using System.Globalization;
using System.Text;

namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // inserir código 1
            Console.WriteLine("Insere código: ");
            //inserir código
            string code1= Console.ReadLine();
            //converter para int
            int x1= int.Parse(code1,NumberStyles.AllowHexSpecifier);
            // escrever resultado
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("Carácter Unicode:" + x1);

              // inserir código 2
            Console.WriteLine("Insere código: ");
            //inserir código
            string code2= Console.ReadLine();
            //converter para int
            int x2= int.Parse(code2,NumberStyles.AllowHexSpecifier);
            // escrever resultado
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("Carácter Unicode:" + x2);

              // inserir código 3
            Console.WriteLine("Insere código: ");
            //inserir código
            string code3= Console.ReadLine();
            //converter para int
            int x3= int.Parse(code3,NumberStyles.AllowHexSpecifier);
            // escrever resultado
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("Carácter Unicode:" + x3);
        }
    }
}
