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