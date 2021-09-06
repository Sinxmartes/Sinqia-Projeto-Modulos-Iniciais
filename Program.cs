using System;

namespace Sinqia_Projeto_Modulo01
{
    class Program
    {
        static void Main(string[] args)
        {

            const string MensagemBoasVinda = "Hello World";

            Console.WriteLine(MensagemBoasVinda);

            //int x = 10;
            //float z = 1.5f;
            //double a = 1.5; //suporta o dobro de valor do float
            //bool b = true;
            //string y = "cadeia de caracteres";
            //char c = 'c';

            Console.WriteLine("Bem vindo a simples calculadora");
            Console.WriteLine("Escolha a operação matemática abaixo:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Multiplicação");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Subtração");
            Console.WriteLine("5 - Resto");
            Console.WriteLine("6 - Sair da calculadora");
            Console.Write("Opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());            
           
            /* switch (opcao)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:

                default:
            } */

            if (opcao == 6) {
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
            }
        }
    }
}
