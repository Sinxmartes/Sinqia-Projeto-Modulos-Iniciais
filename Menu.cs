using System;
using System.Collections.Generic;

namespace Sinqia_Projeto_Modulo01
{
     class Menu {
        public void MenuCalc() { 
            Calculadora calc = new Calculadora();
            Console.WriteLine("\nEscolha a operação matemática abaixo:");
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
            Console.WriteLine("4 - Sistema Shopping");
            Console.WriteLine("0 - Sair do programa");
            Console.Write("Opção: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option) {
                case 1:
                    MenuCalc();
                    break;
                case 2:
                case 3:
                case 4:
                    MenuShopping(new List<ILoja>());
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção Incorreta, tente novamente");
                    MenuGeral();
                    break;
            }
        }

        public void MenuShopping(List<ILoja> lojas) {
            Polimorfismo menuShopping = new Polimorfismo(lojas);
            Console.WriteLine("\nBem vindo Menu do Shopping");
            Console.WriteLine("1 - Listas Lojas Cadastradas");
            Console.WriteLine("2 - Realizar Compra");
            Console.WriteLine("3 - Cadastrar Loja Departamento");
            Console.WriteLine("4 - Cadastrar Fast Food");
            Console.WriteLine("5 - Remover Loja ou Fast Food");
            Console.WriteLine("0 - Sair do menu shopping e voltar ao menu inicial");
            Console.Write("Opção: ");
            menuShopping.SelectOption(Convert.ToInt32(Console.ReadLine()));
        }
    }
}