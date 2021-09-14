using System;

namespace Sinqia_Projeto_Modulo01
{
    class Program
    {

        //camelCase -> Variáveis
        //PascalCase -> Métodos e Classes

        static void Main(string[] args)
        {            
            //const string MensagemSistema = "Bem vindo a simples calculadora";
            //Console.WriteLine(MensagemSistema);

            //BoasVindas.MensagemBoasVindas();
            Menu menu = new Menu();
            menu.MenuCalc();

            //EstruturaRepeticaoFor();
            //EstruturaRepeticaoWhile();
            //EstruturaRepeticaoDoWhile();

            //EstruturaVetoresMatrizes();


            //Calculadora calc = new Calculadora();
            //Console.WriteLine(calc.NumberOne);
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
            
            //int[] ValoresPares = {0, 2, 4, 6};
            //int[,] ValoresPeI = {{0, 2, 4, 6}, {1, 3, 5, 7}};

            //int[] MatrizUni = new int[6]; //{1, 2, 3, 4, 5, 6}
            //int[] MatrizUni2 = new int[] {0, 2, 4, 6};

            //int[,] MatrizBi = new int[2,3];

            /* int [] ValoresPares = new int[10]; */

            /* 
                ValoresPares[0] = 2;
                ValoresPares[1] = 4; 
                ValoresPares[2] = 6;
                ValoresPares[3] = 8;
                ValoresPares[4] = 10;
                ValoresPares[5] = 12;
                ValoresPares[6] = 14;
                ValoresPares[7] = 16;
                ValoresPares[8] = 18;
                ValoresPares[9] = 20; 
            */

            /* int par = 0; */
                      
            /* Usando While
            int i = 0;
            
            while(i < ValoresPares.Length) {
                par += 2;
                ValoresPares[i] = par;
                i++;
            } */

            /* Usando For
            for(int i = 0; i < ValoresPares.Length; i++) {
                par += 2;
                ValoresPares[i] = par;
            } */

            //foreach      
            /* foreach(int elemento in ValoresPares) { //for each -> PARA CADA
                Console.WriteLine(elemento);
            } */

            string [,] AlunosLC = new string[6,2]; // 6 -> linhas ; 3 -> colunas

            
            /* Console.WriteLine(AlunosLC.Length); // mostra o tamanho de elementos no meu array(en) === matriz(pt) ou vector(en) === vetor(pt)
            Console.WriteLine(AlunosLC.Rank); // mostra a quantidade de dimensões
            Console.WriteLine(AlunosLC.GetUpperBound(0); // mostra a quantidade de elementos - 1 em uma determinada dimensão */
               
            for(int i = 0; i <= AlunosLC.GetUpperBound(0); i++) {
                for(int j = 0; j <= AlunosLC.GetUpperBound(1); j++) {
                    if(j == 0) {
                        Console.WriteLine("Digite o nome do aluno: ");
                        AlunosLC[i, j] = Console.ReadLine();                
                    } else {
                        Console.WriteLine("Digite a idade do aluno: ");
                        AlunosLC[i, j] = Console.ReadLine();               
                    }
                }
            }
                        
            foreach(string e in AlunosLC) { 
                Console.WriteLine(e);
            }
        }
    }
}
