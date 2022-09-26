namespace Ex_aula4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> atend = new Queue<string>();
            string nome;
            int i = 1;

            for (; i <=10; i++)
            {
                Console.WriteLine("Digite seu nome para atendimento: ");
                nome = Console.ReadLine();
                Console.WriteLine("Senha: {0}",i);
                atend.Enqueue(nome);
            }
            foreach (string s in atend)
            {
                Console.WriteLine("Atendimento {0}\n", s);
            }
            //INVERSO
            //Stack <string> stack2 = new Stack<string>(atend.ToArray());
            //foreach (string s in stack2)
            //{
            //    Console.WriteLine("Atendimento {0}\n",s);
            //}
        }
    }
}