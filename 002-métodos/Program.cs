using System;

namespace _002_métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.apresentar();
            obj.apresentar("Ralf");
            obj.apresentar("Ralf", 33);
        }
    }
}
