using System.Globalization;
using System;
namespace Sinqia_Projeto_Modulo01
{
    public class FastFood : IAlimentacao
    {

         private string nome;
         public string Nome 
         {
            get { return nome;}
            set { nome = value;}
         
         }
         public int Numeracao
         {
             get { return 101;}
        }

         double aluguel = 100000;
         public double Aluguel
         {
             get { return aluguel;}
         }

         public FastFood(string nome)
         {
             this.Nome = nome;
         }

           public FastFood(string nome, double aluguel)
         {
             this.Nome = nome;
             this.aluguel = aluguel;
         }

         public void Vender()
         {
             PrepararPedido();
             Console.WriteLine($"{Nome} - Venda concluida com sucesso");
         }
         public void PrepararPedido()
         {
             Console.WriteLine("Hamburguer na chapa");
             Console.WriteLine("Refrigerante no copo");
             Console.WriteLine("Pedido embalado");
         }
    }
}