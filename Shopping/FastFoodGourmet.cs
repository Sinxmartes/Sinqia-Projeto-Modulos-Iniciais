using System.Globalization;
using System;
namespace Sinqia_Projeto_Modulo01
{
    public class FastFoodGourmet : FastFood, IAlimentacao
    {
            public FastFoodGourmet(string nome): base(nome)
         {
             this.Nome = nome;
         }

         public override void PrepararPedido()
         {
             base.PrepararPedido();
             Console.WriteLine("Renomeando batatas fritas, para batatas rústicas");
             Console.WriteLine("Adicionando palavra orgânico ao lanche");
             Console.WriteLine("Pedido embalado em sacolas de papel reciclavel");
         }
    }
}