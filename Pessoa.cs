using System;

namespace Sinqia_Projeto_Modulo01
{
    class Pessoa
    {
        double altura;
        double peso;
        int calcado;
        string nome;
        int diaNascimento;
        int mesNascimento;
        int anoNascimento;

        public int idade() {
            return DateTime.Now.Year - anoNascimento;
        }

        public void novoPeso(int qtdePerdeu) {
            peso = peso - qtdePerdeu;
        }
    }
}