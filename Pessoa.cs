using System;

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