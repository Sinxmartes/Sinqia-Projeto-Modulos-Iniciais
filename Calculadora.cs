using System;

namespace Sinqia_Projeto_Modulo01
{
    class Calculadora {

        private double result;
        public double Result {
            get { return result; }
            private set { result = value; }
        }

        private double numberOne;

        public double NumberOne {
            get { return numberOne; }
            private set {
                Console.Write("Digite o primeiro valor: ");
                Double.TryParse(Console.ReadLine(), out numberOne);
            }
        }

        private double numberTwo;

        public double NumberTwo {
            get { return numberTwo; }                                   //get -> Retornar o valor da variável para o usuário ou método
            private set {                                               //set -> Salvar o valor na variável
                Console.Write("Digite o segundo valor: ");
                Double.TryParse(Console.ReadLine(), out numberTwo);
            }
        }
        
        private void Fatorial() {
            Result = NumberOne;
            for(int i = ((int) NumberOne - 1); i >= 1; i--) {
                Result *= i;
            }
        }

        /* public void SetNumberOne(bool fatorial = false) {
            if(!fatorial) Console.Write("Digite o primeiro valor: ");
            else Console.Write("Digite o valor para ser calculado o fatorial: ");

            Double.TryParse(Console.ReadLine(), out numberOne);
        } */

        private void Sum() {
            Result = NumberOne + NumberTwo;
        }

        private void Subtract() {
            Result = NumberOne - NumberTwo;
        }

        private void Mult() {
            Result = NumberOne * NumberTwo;
        }

        private void Div() {
            Result = NumberOne / NumberTwo;
        }

        private void Mod() {
            Result = NumberOne % NumberTwo;
        }
             

        public void SelectOption(int opcao) {
            Menu menu = new Menu();

            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"A soma dos dois valores é: {Program.LerValor1() + Program.LerValor2()}\n");
                    menu.MenuCalc();
                    break;
                case 2:
                    Console.WriteLine($"A multiplicação dos dois valores é: {Program.LerValor1() * Program.LerValor2()}\n");
                    menu.MenuCalc();
                    break;
                case 3:
                    Console.WriteLine($"A divisão dos dois valores é: {Program.LerValor1() / Program.LerValor2()}\n");
                    menu.MenuCalc();
                    break;
                case 4:
                    Console.WriteLine($"A subtração dos dois valores é: {Program.LerValor1() - Program.LerValor2()}\n");
                    menu.MenuCalc();
                    break;
                case 5:
                    Console.WriteLine($"A resto da divisão dos dois valores é: {Program.LerValor1() % Program.LerValor2()}\n");
                    menu.MenuCalc();
                    break;                    
                case 6:                    
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção incorreta, tente novamente\n");
                    menu.MenuCalc();
                    break;
            }
        }
    }
}