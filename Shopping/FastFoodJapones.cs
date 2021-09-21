using System.Globalization;
using System;
namespace Sinqia_Projeto_Modulo01
{
    public class FastFoodJapones : FastFood, IAlimentacao
    {

       public FastFoodJapones(string nome): base(nome)
         {
         }

         public override void PrepararPedido()
         {
             Console.WriteLine("Espalhando Arroz");
             Console.WriteLine("Enrolando sushi");
             Console.WriteLine("Cortando alga");
         }
    }
}