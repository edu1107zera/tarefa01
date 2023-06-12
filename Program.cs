using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa01
{
    class Program
    {
        static void Main(string[] args)
        {
         //variaveis
            int idade;
            string nome;
            string nome2;
          //processo
            Console.Write("--Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Nome:" + nome);

            Console.WriteLine("\n");

            Console.Write("--Digite seu sobrenome:");
            nome2 = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Sobrenome:" + nome2);

            Console.WriteLine("\n");

            Console.Write($"Seja Bem-vindo(a):{nome} {nome2}. Quantos anos voce tem? ");
            idade = Int32.Parse( Console.ReadLine() );




            
            

            

            Console.WriteLine($"Usuario:{nome} {nome2} tem {idade} anos");








            Console.ReadKey();










            

            //tarefa
            /**
            Boolean cl1 = true;
            Boolean cl2 = false;
          
            string nome1 ="conradito";
            string nome2 = "pedrita";
          
            int idade = 15; //conrado
            int idade2 = 19; // pedrita
            int cafestm = 187; //conrado
            int cafestm2 = 5; //pedrita
            int totalcafes = cafestm + cafestm2; //somas de cafes tomados
            int falta1 = cafestm - 200; // falta de cafes para conrado
            int falta2 = cafestm2 - 200; // falta de cafes para pedrita
                 

            Console.WriteLine("ola");
            Console.WriteLine("Bem-vindo ao sistema de usuarios do Eduzito");
            Console.WriteLine("Abaixo estao as informaçoes dos usuarios cadastrados no nosso sistema:");

            Console.WriteLine("\n\n");

            Console.WriteLine("----Lista de usuarios");
            Console.WriteLine($"1 - nome:{nome1}.idade:{idade}. é cliente:{cl1}");
            Console.WriteLine($"2 - nome:{nome2}. idade:{idade2}. é cliente:{cl2}");
            
            Console.WriteLine("\n\n");

            Console.WriteLine("----Quantidade de cafes");
            Console.WriteLine($"O cliente {nome1}. ja tomou {cafestm}!");
            Console.WriteLine($"O cliente {nome2}. ja tomou {cafestm2}!");

            Console.WriteLine("\n\n");

            Console.WriteLine("---- Somas de cafes tomados");
            Console.WriteLine($"Juntos, os clientes {nome1} e {nome2} tomaram {totalcafes} cafes!");

            Console.WriteLine("\n\n");

            Console.WriteLine("-----Quantos cafes falta para chegar a 200?");
            Console.WriteLine($"Faltam {falta1} para {nome1}");
            Console.WriteLine($"Faltam {falta2} para {nome2}");

            Console.WriteLine("\n\n");

            Console.WriteLine("---- Fim do sistema de consultas");
            Console.WriteLine("- Obrigado e volte sempre!!!");


            Console.ReadKey();
            */

        }
        void Revisaoaula04etarefa()
        {

            float lanche = 8.00f;
            float salsicha = 1.50f;
            float hamburguer = 2.00f;
            float requeijao = 1.50f;
            float bacon = 2.00f;

            float xtudo = lanche + salsicha + hamburguer + bacon;

            float hotdog = lanche + (salsicha * 2) + requeijao;

            float modcasa = lanche + salsicha + hamburguer + requeijao + bacon;

            float combo = xtudo + hotdog + modcasa;

            Console.WriteLine("cardapio do conradito lanches");
            Console.WriteLine("valores:");
            Console.WriteLine($"X-TUDO: hamburger, bacon, e salshicha R${xtudo}  ");
            Console.WriteLine($"Cachorro-quente cremoso: 2 salshichas e requeijao R${hotdog}");
            Console.WriteLine($"A moda da casa: salsicha, hambuguer, requeijao e bacon R${modcasa}");
            Console.WriteLine("\n\n");
            Console.WriteLine($"COMBO: x-tudo + cachorro-quente cremoso + A moda da casa R${combo}");



            Console.ReadKey();

        }

    }
}
