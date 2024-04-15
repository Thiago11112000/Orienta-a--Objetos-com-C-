using System;

public class Aluno
{
    //Atributos
    public string nome;
    public double nota1, nota2; 

    //MÉDIA
    public double media()
    {
        return (nota1 + nota2)/2;
    }

    //SITUAÇÃO
    public string situacao(double media)
    {
        return media >= 7 ?  "Aprovado" : "Reprovado";
    }

    //Mensagem
    public void mensagem()
    {
        //obter a média
        double obterMedia = media();

        string obterSituacao = situacao(obterMedia);
         
        //Mensagem
        Console.WriteLine(nome + " está "  + obterSituacao + " com média "  +  obterMedia );
    }
}