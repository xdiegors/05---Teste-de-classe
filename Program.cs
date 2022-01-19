using System;

namespace _05___Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa PrimeiroCandidato = new Pessoa();
            
            PrimeiroCandidato.Nome = "Diego";
            PrimeiroCandidato.Idade = 30;
            PrimeiroCandidato.Profissao = "Desenvolvedor .NET";
            PrimeiroCandidato.Apresentacao();
        }
    }
}

public class Pessoa
{
    public string Nome { get; set; }

    public int Idade { get; set; }

    public string Profissao { get; set; }

    public void Apresentacao()
    {
        Console.WriteLine($"Olá pessoal! Meu nome é {Nome}, tenho {Idade} anos e sou um(a) {Profissao}");
    }
}