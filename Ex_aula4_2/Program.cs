using System.Collections.Generic;
namespace Ex_aula4_2 {
    internal class Program {
        static void Main(string[] args) {
            //List<int> list = new List<int> { };
            HashSet<int> set = new HashSet<int>();
            int resp = 1;
            while (resp != 0) {

                Console.WriteLine("1-Digite um numero: ");
                Console.WriteLine("0-Sair");
                resp = int.Parse(Console.ReadLine());
                //  set.Add(n);

                if (resp != 0) {
                    set.Add(resp);
                    
                }
            }
            Console.WriteLine("\n");
            foreach (int i in set) {
                Console.WriteLine(i);
            }
        }
    }
}
