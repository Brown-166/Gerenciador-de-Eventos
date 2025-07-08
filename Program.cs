using System;

class Program
{
    static void Main(string[] args)
    {
        Participante pessoa = new Participante();

        pessoa.criarUsuario();
        Console.WriteLine(pessoa.CPF);
        Console.WriteLine(pessoa.Nome);
        Console.WriteLine(pessoa.Sobrenome);
        Console.WriteLine(pessoa.Email);
        Console.WriteLine(pessoa.Dinheiro);
    }
}