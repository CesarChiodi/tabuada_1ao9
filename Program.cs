using System;

namespace tabuada_1ao9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, result = 0;
            Console.WriteLine("escreva um numero de 1 a 9");
            n = int.Parse(Console.ReadLine());
            if(n>9 || n<1)
                Console.WriteLine("o numero informado nao corresponde ao requerimento");
            else
            {
                for (int i = 0; i <= 10; i++)
                {
                    result = i * n;
                    Console.WriteLine(i + "x" + n + "=" + result);
                }
            }                    
        }
    }
}
