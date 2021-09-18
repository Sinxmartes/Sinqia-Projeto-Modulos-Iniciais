namespace Sinqia_Projeto_Modulo01
{
    public class Poupanca: IInvestimento
    {
        
         double valorAplicacao;
         public double ValorAplicacao
         {
             get
             {
                return valorAplicacao;
             }
             private set
             {
                valorAplicacao = value;
             }
         }

        double valorAtual;
        public double ValorAtual
         {
             get
             {
                return valorAtual;
             }
             private set 
             {
                valorAtual = value;
             }
         }

         public Poupanca(double valorInicial)
         {
             this.valorAplicacao = valorInicial;
             this.valorAtual = valorInicial;
         }

         public void Render()
         {
             this.ValorAtual = ValorAplicacao * 1.01;
         }
    }
}