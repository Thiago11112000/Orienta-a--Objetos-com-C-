using System;

namespace _003_ExercícioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.nome = "Denis";
            a.nota1 = 8;
            a.nota2 = 10;
            a.mensagem();
        }
    }
}
