namespace Ex_aula4_1 {
    internal class Program {
        static void Main(string[] args) {
           // List<int> list = new List<int>();
            List<string> listFilme= new List<string>();
            int idade = 0;
            string resp = " ";
            int respruim = 0, respessimo = 0, idaderespruim = 0, mediaidade1 = 0, maioridade = 0, i=0;
 
            //string[] filme = new string[] { };

            for (; i < 100; i++) {
                Console.WriteLine("Qual sua idade?");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Filme é ótimo, bom, regular, ruim ou péssimo:?");
                resp= (string)Console.ReadLine();


                if (resp == "otimo" || resp == "bom" || resp == "regular" || resp == "pessimo") {
                    listFilme.Add(resp);
                }
                
                if (resp == "ruim") {
                    respruim = +1;
                    idaderespruim= +idade;
                }
                if(resp== "pessimo") {
                    if (idade > maioridade) {
                        maioridade = idade;
                    }
                }
            }
            mediaidade1 = idaderespruim / idade;
            double percpessimo = (respessimo / 100) * 100;
            Console.WriteLine("respostas {0}",i);
            Console.WriteLine(" A média de idade das pessoas que responderam ruim: {0}", mediaidade1);
            Console.WriteLine(" A porcentagem dos entrevistados que responderam Péssimo foi:{0}", percpessimo);
            Console.WriteLine("A maior idade que respondeu pessimo foi: {0}",maioridade);


        }
    }
}