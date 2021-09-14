using System;

namespace Sinqia_Projeto_Modulo01
{
    class Pessoa
    {
        private string nome;
        private int diaNascimento;
        private int mesNascimento;
        private int anoNascimento;
        
        public int idade() {
            return DateTime.Now.Year - anoNascimento;
        }

        protected int AnoNascimento {
            get => anoNascimento;
            set {
                anoNascimento = value;
            }
        }

        public string Nome {
            get => nome;
            protected set {
                nome = value;
            }
        }
    }
}