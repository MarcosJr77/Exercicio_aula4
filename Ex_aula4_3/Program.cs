using System.Collections;

namespace Ex_aula4_3 {
    internal class Program {
        static void Main(string[] args) {
            Stack my_stack = new Stack();
            char resp=' ';
            char polin;
            
            while (resp!= '-') {
                Console.WriteLine("Digite caracteres: ");
                Console.WriteLine("- Sair");
                resp = char.Parse(Console.ReadLine());

                if (resp == resp) {
                    my_stack.Push(resp);
                }
            }
            foreach (var elem in my_stack) {
                Console.WriteLine("\n{0}",elem);
            }
            Stack stack2 = new Stack (my_stack.ToArray());
            
            Console.WriteLine("\nOrdem inversa:\n");
            foreach (var number in stack2) {
                Console.WriteLine(number);
            }
        }
    }
}