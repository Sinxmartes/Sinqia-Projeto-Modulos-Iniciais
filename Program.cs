using System;

namespace Sinqia_Projeto_Modulo01
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MensagemBoasVinda = "Hello World";
            //const string MensagemSistema = "Bem vindo a simples calculadora";

            Console.WriteLine(MensagemBoasVinda);
            //Console.WriteLine(MensagemSistema);

            //Menu();

            //EstruturaRepeticaoFor();
            EstruturaRepeticaoWhile();
            //EstruturaRepeticaoDoWhile();
        }

        static double LerValor1() {
            Console.Write("Digite o primeiro valor: ");
            double valor1 = Double.Parse(Console.ReadLine());
            return valor1;
        }

        static double LerValor2() {            
            double valor2;
            Console.Write("Digite o segundo valor: ");
            Double.TryParse(Console.ReadLine(), out valor2);
            return valor2;
        }

        static void Menu() { 
            Console.WriteLine("Escolha a operação matemática abaixo:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Multiplicação");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Subtração");
            Console.WriteLine("5 - Resto");
            Console.WriteLine("6 - Sair da calculadora");
            Console.Write("Opção: ");
            OpcaoSelecionada(Convert.ToInt32(Console.ReadLine()));
        }

        static void OpcaoSelecionada(int opcao) {
            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"A soma dos dois valores é: {LerValor1() + LerValor2()}\n");
                    Menu();
                    break;
                case 2:
                    Console.WriteLine($"A multiplicação dos dois valores é: {LerValor1() * LerValor2()}\n");
                    Menu();
                    break;
                case 3:
                    Console.WriteLine($"A divisão dos dois valores é: {LerValor1() / LerValor2()}\n");
                    Menu();
                    break;
                case 4:
                    Console.WriteLine($"A subtração dos dois valores é: {LerValor1() - LerValor2()}\n");
                    Menu();
                    break;
                case 5:
                    Console.WriteLine($"A resto da divisão dos dois valores é: {LerValor1() % LerValor2()}\n");
                    Menu();
                    break;                    
                case 6:                    
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção incorreta, tente novamente\n");
                    Menu();
                    break;
            }
        }

        static void OpcaoComIf() {
            /* if (opcao == 6) {
                Environment.Exit(0);
            } else if (opcao < 1 || opcao > 6) { //AND - E -> && //OR - OU -> || //NOT - NÃO -> !
                Console.WriteLine("Opção incorreta, tente novamente mais tarde");
                Environment.Exit(0);
            }
           
            Console.Write("Digite o primeiro valor: ");
            double valor1 = Double.Parse(Console.ReadLine());
            double valor2;
            Console.Write("Digite o segundo valor: ");
            Double.TryParse(Console.ReadLine(), out valor2);

            if (opcao == 1)
            {
                Console.WriteLine($"A soma dos dois valores é: {valor1 + valor2}");
            }
            else if (opcao == 2)
            {
                Console.WriteLine($"A multiplicação dos dois valores é: {valor1 * valor2}");
            }
            else if (opcao == 3)
            {
                Console.WriteLine($"A divisão dos dois valores é: {valor1 / valor2}");

            }
            else if (opcao == 4) // = -> atribuição | == -> igualdade
            {
                Console.WriteLine($"A subtração dos dois valores é: {valor1 - valor2}");
            }
            else if (opcao == 5)
            {
                Console.WriteLine($"A resto da divisão dos dois valores é: {valor1 % valor2}");
            } */
        }
        
        static void EstruturaRepeticaoFor() {
            Console.Write("Digite um valor para ser calculado o fatorial do mesmo: ");
            int fatorial;
            Int32.TryParse(Console.ReadLine(), out fatorial);
            int resultado = fatorial;
            for(int i = (fatorial-1); i >= 1; i--) { //i++ == i=i+1 || i-- == i=i-1
                resultado = resultado * i;
            }
            Console.WriteLine($"Resultado do fatorial é: {resultado}");
        }

        static void EstruturaRepeticaoWhile() {
            Random random = new Random();
            int vezes = random.Next(1, 101);
            int descobrir = random.Next(1, 51);
            Console.Write("Descubra o valor que estou pensando: ");
            int numero = 0, i = 1;
            Int32.TryParse(Console.ReadLine(), out numero);
            while(numero != descobrir && i < vezes) {
                Console.Write("Descubra o valor que estou pensando: ");
                Int32.TryParse(Console.ReadLine(), out numero);
                i++;
            }

            if (i == vezes && numero != descobrir) {
                Console.WriteLine($"Você não descobriu o valor e tentou {i} vezes");
            } else {
                Console.WriteLine($"Você demorou {i} vezes para descobrir o valor");
            }
        }

        static void EstruturaRepeticaoDoWhile() {           
            do {
                Console.WriteLine("\nDescubra a tecla que encerra o programa: ");                
            } while(Console.ReadKey().Key != ConsoleKey.V);
        }

        static void EstruturaVetoresMatrizes() {           
            
            // [0, 1, 2, 3, 4] -> 5 posições
            // [[0, 2, 4, 6, 8, 10],[1, 3, 5, 7, 9, 11]] -> 2x3 posições
            
            int[] ValoresPares = {0, 2, 4, 6};
            int[,] ValoresPeI = {{0, 2, 4, 6}, {1, 3, 5, 7}};

            int [] MatrizUni = new int[6];
            int [] MatrizUni2 = new int[] {0, 2, 4, 6};


            //foreach
            
        }

    }
}
