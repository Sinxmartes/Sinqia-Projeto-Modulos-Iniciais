namespace Sinqia_Projeto_Modulo01
{
    public class CDB: IInvestimento
    {
        
         double valorAplicacao;
         
         public double ValorAplicacao
         {
             get
             {
                return 60;
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

         public CDB(double valorInicial)
         {
             this.valorAplicacao = valorInicial;
             this.valorAtual = valorInicial;
         }

         public void Render()
         {
             this.ValorAtual = ValorAplicacao * 1.10;
         }
    }
}