using System;

namespace Sinqia_Projeto_Modulo01
{
    class Menu {
        public void MenuCalc() { 
            Calculadora calc = new Calculadora();
            Console.WriteLine("Escolha a operação matemática abaixo:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Multiplicação");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Subtração");
            Console.WriteLine("5 - Resto");
            Console.WriteLine("6 - Fatorial");
            Console.WriteLine("0 - Sair da calculadora e voltar para o menu");
            Console.Write("Opção: ");
            calc.SelectOption(Convert.ToInt32(Console.ReadLine()));

        }

        public void MenuGeral() {
            Console.WriteLine("Bem vindo ao código da turma Sinqia C#");
            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Cadastrar Pessoa");
            Console.WriteLine("3 - Visualizar dados da Pessoa Cadastrada");
            Console.WriteLine("0 - Sair do programa");
            Console.Write("Opção: ");
        }   
    }
}