using System.Globalization;
using System;
namespace Sinqia_Projeto_Modulo01
{
    public class FastFoodMexicano : FastFood, IAlimentacao
    {

        public FastFoodMexicano(string nome): base(nome)
         {
         }

         public override void PrepararPedido()
         {
             Console.WriteLine("Apimentando o chilli");
             Console.WriteLine("Assando las papas");
             Console.WriteLine("Enrolando burritos");
         }
    }
}