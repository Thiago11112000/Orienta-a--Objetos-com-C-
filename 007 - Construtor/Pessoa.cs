using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Pessoa
    {
        //CONSTRUTOR

        public Pessoa()
        {
            Console.WriteLine("Construtor Executado");
        }
        public Pessoa(string nome)
        {
            Console.WriteLine("Olá " + nome);
        }
    }
