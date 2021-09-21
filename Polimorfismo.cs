using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinqia_Projeto_Modulo01
{
    class Polimorfismo
    {
        List<ILoja> lojas;

        public Polimorfismo(List<ILoja> _lojas) {
            lojas = _lojas;
        }

        public void ExecutarExemplos()
        {
            this.Exemplo1Academico();
            this.Exemplo2Investimentos();
            this.Exemplo3LojaShopping();
        }

        //utilizamos a interface IAcademico para designar as pessoas que possuem relação com uma instituição
        //No caso temos dois tipos de pessoa o Professor e o Aluno
        void Exemplo1Academico()
        {
            Console.WriteLine("Exemplo dos acadêmicos - Início");
            //Exemplo sem polimorfismo, implica que temos que conhecer a responsabilidade de cada um
            //Além é claro de ter uma variável para cada classe    
            Aluno aluno = new Aluno();
            Professor professor = new Professor();
            aluno.Responsabilidade();
            professor.Responsabilidade();

            //Exemplo com polimorfismo
            IAcademico pessoa = new Aluno();

            pessoa.Responsabilidade();

            pessoa = new Professor();

            pessoa.Responsabilidade();

            Console.WriteLine("Exemplo dos acadêmicos - Fim \n");

        }

        /// <summary>
        /// Simulação de necessidade para a criação de uma forma de todos os investimentos terem como atributos: ValorInicial, ValorAtual e um método que gera rendimentos
        /// </summary>
        void Exemplo2Investimentos()
        {
            Console.WriteLine("Exemplo dos investimentos - Início");
            //Independente de qual for o investimento escolhido, sabemos que ele terá um método "Render"
            IInvestimento investimento = new Poupanca(1000);
            investimento.Render();
            Console.WriteLine(investimento.ValorAtual);


            investimento = new CDB(1000);
            investimento.Render();
            Console.WriteLine(investimento.ValorAtual);
            Console.WriteLine("Exemplo dos investimentos - Fim \n");
        }
        /// <summary>
        /// Definir uma matriz com as lojas do shopping, Imprimir o nome e valor do aluguel de cada uma e por fim simular o processo de venda, independente da loja.
        /// </summary>
        void Exemplo3LojaShopping()
        {
            Console.WriteLine("Exemplo das Lojas - Início");
            // Matriz de Lojas (objeto mais basico e comum) com a criação de cada loja com seu tipo
            ILoja[] lojas = new ILoja[4] { new FastFood("McDonalds", 50000) //Exemplo de polimorfismo no construtor, em que dependendo de uma entrada ou outra temos diferenças no comportamento
                                         , new FastFood("KFC")
                                         , new LojaDepartamento("Renner")
                                         , new LojaDepartamento("CeA")
                                        };

            foreach (ILoja loja in lojas)
            {
                Console.WriteLine(loja.Nome);
                Console.WriteLine(loja.Aluguel);
                loja.Vender();
            }
            Console.WriteLine("Exemplo das Lojas - Fim \n");
        }

        public void SelectOption(int option) {            
            Menu menu = new Menu();

            switch (option)
            {
                case 0:
                    menu.MenuGeral();
                    break;
                case 1:
                    ListarLojasCadastradas();
                    menu.MenuShopping(lojas);
                    break;
                case 2:
                    
                    menu.MenuShopping(lojas);
                    break;
                case 3:
                    CadastrarLojaDepartamento();
                    menu.MenuShopping(lojas);
                    break;
                case 4:
                    CadastrarFastFood();
                    menu.MenuShopping(lojas);
                    break;
                case 5:
                    RemoverLojaOuFastFood();
                    menu.MenuShopping(lojas);
                    break;
                default:
                    Console.WriteLine("Opção incorreta, tente novamente\n");
                    menu.MenuShopping(lojas);
                    break;
            }
        }

        void CadastrarLojaDepartamento()
        {           
            /*Tipos de Collections:
            * - List<>
            * - Dictionary<Tkey, TValue>
            */

            string nomeLoja = "";
            bool novamente = false;

            do {
                Console.Write("Digite o nome da loja de departamento que deseja cadastrar: ");
                nomeLoja = Console.ReadLine();

                lojas.Add(new LojaDepartamento(nomeLoja));
                
                Console.Write("\nDeseja cadastrar outra loja? Sim ou não (sem acento): ");
                string simNao = Console.ReadLine().ToUpper();
                switch (simNao) {
                    case "SIM":
                        novamente = true;
                        break;
                    case "NAO": 
                        novamente = false;
                        break;
                    default:
                        Console.WriteLine("Opção Invalida, não haverá novo cadastro");
                        novamente = false;
                        break;
                }

            } while(novamente);
        }

        void CadastrarFastFood()
        {           
            /*Tipos de Collections:
            * - List<>
            * - Dictionary<Tkey, TValue>
            */

            string nomeLoja = "";
            double aluguelLoja;
            bool novamente = false;

            do {
                Console.Write("Digite o nome do FastFood que deseja cadastrar: ");
                nomeLoja = Console.ReadLine();
                Console.Write("Digite o valor do aluguel do FastFood: ");
                aluguelLoja = Convert.ToDouble(Console.ReadLine());
                lojas.Add(new FastFood(nomeLoja, aluguelLoja));
                
                Console.Write("\nDeseja cadastrar outro FastFood? Sim ou não (sem acento): ");
                string simNao = Console.ReadLine().ToUpper();
                switch (simNao) {
                    case "SIM":
                        novamente = true;
                        break;
                    case "NAO": 
                        novamente = false;
                        break;
                    default:
                        Console.WriteLine("Opção Invalida, não haverá novo cadastro");
                        novamente = false;
                        break;
                }

            } while(novamente);
        }

        void RemoverLojaOuFastFood() {
            string nomeLoja;
            Console.Write("Digite o nome da Loja de Departamento ou FastFood que deseja remover: ");
            nomeLoja = Console.ReadLine();

            int indexLoja = lojas.FindIndex(loja => loja.Nome == nomeLoja);

            if(indexLoja == -1) {
                Console.WriteLine("Loja não encontrada, tente novamente");
                RemoverLojaOuFastFood();
            } else {
                lojas.RemoveAt(indexLoja);
                Console.WriteLine($"Foi removido a loja {nomeLoja} com sucesso");
            }            
        }

        void ListarLojasCadastradas()
        {
            Console.WriteLine("Estas são as lojas cadastradas: ");
            foreach (ILoja loja in lojas)
            {
                Console.WriteLine($"Loja: {loja.Nome} - Aluguel: {loja.Aluguel}");
            }
        }
    }
}
