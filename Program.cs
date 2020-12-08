using System;

namespace ProjetoPassagensAéreas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];

            Console.WriteLine("Seja bem vindo... antes de iniciarmos insira a senha");
            int senha = int.Parse(Console.ReadLine());
            switch (senha)
            {
                case 123456:
                Console.WriteLine("O que gostaria de fazer?");
                Console.WriteLine("[1] - Cadastrar passagem");
                Console.WriteLine("[2] - Listar passagem");
                Console.WriteLine("[0] - Sair");
                int escolha1 = int.Parse(Console.ReadLine());
                
                while (1 == 1)
                {
                    switch (escolha1)
                    {
                        case 0:
                        Environment.Exit(1);
                            break;
                        case 1:
                        Console.WriteLine("Quantas passagens gostaria de cadastrar?");
                        Console.WriteLine("Máximo de 5 pessoas");
                        int e = int.Parse(Console.ReadLine());
                        for (var i = 0; i < e; i++)
                        {
                            Console.Write("Escreva o nome do passageiro: ");
                            nome[i] = Console.ReadLine();
                            Console.Write("Digite a origem do passageiro: ");
                            origem[i] = Console.ReadLine();
                            Console.Write("Digite o destino do passageiro: ");
                            destino[i] = Console.ReadLine();
                            Console.Write("Digite a data de partida: ");
                            data[i] = Console.ReadLine();
                        }
                            break;
                        case 2:
                        Console.WriteLine("Aqui está uma lista de todas as passagens cadastradas:");
                        foreach (var item in nome)
                        {
                            Console.WriteLine("Nome: "+nome);
                            Console.WriteLine("Origem: "+origem);
                            Console.WriteLine("Destino: "+destino);
                            Console.WriteLine("Data: "+data);
                        }
                            break;
                        default:
                            break;
                    }
                }
                default:
                Environment.Exit(1);
                    break;
            }
            
        }
    }
}
