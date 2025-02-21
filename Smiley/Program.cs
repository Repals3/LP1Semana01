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
            string code= Console.ReadLine();
            //converter para int
            int x= int.Parse(code,NumberStyles.AllowHexSpecifier);
            // escrever resultado
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("Carácter Unicode:" + x);
        }
    }
}
