namespace Sinqia_Projeto_Modulo01
{
    public interface ILoja
    {
         string Nome {get;set;}
         int Numeracao{get;}
         double Aluguel{get;}
         void Vender();
    }
}