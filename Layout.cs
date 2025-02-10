using System.Reflection.PortableExecutable;

namespace Layout
{
    class Formatacao
    {
        public static void Cor(string texto, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(texto);
            Console.ResetColor();
        }

        public static void ReadLine(string texto, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
    }
}