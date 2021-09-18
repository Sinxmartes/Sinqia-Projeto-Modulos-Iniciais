using System;

namespace Sinqia_Projeto_Modulo01
{
    class Aluno: Pessoa, IAcademico
    {
     
        public string Instituicao {get; set;}

        public string Curso {get; set;}

        public char Periodo {get; set;}

        public void Responsabilidade()
        {
            Console.WriteLine("Prestando atenção e aprendendo");
        }
    }
}