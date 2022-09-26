using System.Collections.Generic;

namespace Ex_aula4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> chamada = new Dictionary<int, string>();
            string nome;
            Console.WriteLine("Sala de Aula- chamada");


            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("nome:");
                nome = Console.ReadLine();
                chamada.Add(i, nome);
            }
            Console.WriteLine("Número 7 - Nome: :{0}",chamada[7]);
        }
    }
}