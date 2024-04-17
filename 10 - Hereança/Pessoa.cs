using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Pessoa
    {
        // Atributos
       protected string nome;
       protected int  idade;

        protected void mensagemPessoa()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
        }

    }