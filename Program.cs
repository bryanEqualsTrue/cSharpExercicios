using System;
namespace sixarpe
{
    class Program
    {
        static void Main(string[] args)
        {
            jogoAdivinhacao();
            Console.WriteLine("\nVocê quer jogar novamente?");

            if (Console.ReadLine().ToUpper() == "NAO" || Console.ReadLine().ToUpper() == "N")
            {
                Console.WriteLine("\nObrigado por jogar!");
                Console.ReadLine();
            }

            while (Console.ReadLine().ToUpper() == "SIM" || Console.ReadLine().ToUpper() == "S")
            {
                jogoAdivinhacao();
            }


            static void resetarConsole()
            {
                Console.Clear();
                Console.WriteLine("=========== BEM-VINDO AO JOGO DE ADIVINHAÇÃO DO BRAIA!!! ===========\n");
            }

            static void jogoAdivinhacao()
            {
                // Cabeçalho
                resetarConsole();
                int points = 0;


                // Recebendo entradas de informações do jogador
                Console.Write("Insira o seu nome: ");
                string nomeDoJogador = Console.ReadLine();

                Console.Write("Insira a sua idade: ");
                int idadeDoJogador = Convert.ToInt32(Console.ReadLine());

                Console.Write("Insira o ano atual: ");
                int anoDeJogo = Convert.ToInt32(Console.ReadLine());


                // Primeira pergunta
                resetarConsole();

                Console.WriteLine("Quanto é a sua idade multiplicada por cem?");

                if (Convert.ToInt32(Console.ReadLine()) == idadeDoJogador * 100)
                {
                    Console.WriteLine("\nAcertou!");
                    points++;
                }
                else
                {
                    Console.WriteLine("\nErrou...");
                }
                Console.ReadKey();


                // Segunda pergunta
                resetarConsole();

                Console.WriteLine("Quem é o Presidente do Brasil?");

                if (Console.ReadLine().ToUpper() == "LULA")
                {
                    Console.WriteLine("\nAcertou!");
                    points++;
                }
                else if (Console.ReadLine().ToUpper() == "BOLSONARO")
                {
                    Console.WriteLine("\nSó se for o teu...");
                    points--;
                }
                else
                {
                    Console.WriteLine("\nErrou...");
                }
                Console.ReadKey();


                // Terceira pergunta
                resetarConsole();

                Console.WriteLine("Qual o seu nome mesmo..?");

                if (Console.ReadLine().ToUpper() == nomeDoJogador.ToUpper())
                {
                    Console.WriteLine("\nAcertou! (graças a deus!)");
                    points++;
                }
                else
                {
                    Console.WriteLine("\nErrou...");
                    Console.WriteLine("A doença de Alzheimer é uma doença degenerativa do cérebro que acomete pessoas com mais idade. Funções cerebrais como memória, linguagem, cálculo, comportamento  são comprometidas de forma lentamente progressiva levando o paciente a uma dependência para executar suas atividades de vida diária.");
                }
                Console.ReadKey();


                // Quarta pergunta
                resetarConsole();

                Console.WriteLine("Quanto é 9+10?");

                if (Convert.ToInt32(Console.ReadLine()) == 19)
                {
                    Console.WriteLine("\nAcertou!");
                    points++;
                }
                else if (Convert.ToInt32(Console.ReadLine()) == 21)
                {
                    Console.WriteLine("\nYou stupid.");
                    points--;
                }
                else
                {
                    Console.WriteLine("Errou...");
                }
                Console.ReadKey();


                // Quinta pergunta
                resetarConsole();

                Console.WriteLine("Em que ano você nasceu?");

                if (Convert.ToInt32(Console.ReadLine()) == anoDeJogo - idadeDoJogador)
                {
                    Console.WriteLine("\nAcertou!");
                    points++;
                }
                else
                {
                    Console.WriteLine("\nErrou...");
                }
                Console.ReadKey();


                // Fim de jogo & pontuação total
                resetarConsole();

                Console.WriteLine(nomeDoJogador + ", sua pontuação total é " + points + "!");
                Console.ReadKey();
            }
        }
    }
}
