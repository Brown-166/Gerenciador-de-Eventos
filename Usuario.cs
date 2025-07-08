using System;
using System.Numerics;

class Usuario
{
    private string cpf;
    public string CPF
    {
        get { return this.cpf; }
        set {
            if (value.Length == 11 && long.TryParse(value, out long cpfINT) && cpfINT > 0)
            {
                this.cpf = value;
            }
            else
            {
                Console.WriteLine("CPF inválido");
                Console.WriteLine("Digite apenas números. Exemplo: 15362475982");
            }
        }
    }
    private string nome;
    public string Nome
    {
        get { return this.nome; }
        set
        {
            if (value.Length > 0)
            {
                this.nome = value;
            }
            else
            {
                Console.WriteLine("Digite um nome válido");
            }
        }
    }
    private string sobrenome;
    public string Sobrenome
    {
        get { return this.sobrenome; }
        set
        {
            if (value.Length > 0)
            {
                this.sobrenome = value;
            }
            else
            {
                Console.WriteLine("Digite um sobrenome válido");
            }
        }
    }
    private string email;
    public string Email {
        get { return this.email; }
        set
        {
            if (value.Length > 4 && value.EndsWith(".com"))
            {
                this.email = value;
            }
            else
            {
                Console.WriteLine("Digite um email válido");
            }
        }
    }


    public Usuario()
    {
        this.cpf = "";
        this.nome = "";
        this.sobrenome = "";
        this.email = "";
    }

    public Usuario(string cpf, string nome, string sobrenome, string email)
    {
        this.cpf = "";
        this.nome = "";
        this.sobrenome = "";
        this.email = "";
        
        this.CPF = cpf;
        this.Nome = nome;
        this.Sobrenome = sobrenome;
        this.Email = email;
    }

    virtual public void criarUsuario()
    {
        Console.WriteLine();
        Console.WriteLine("Digite seu cpf:");
        while (cpf == "")
        {
            CPF = Console.ReadLine();
        }
        Console.WriteLine();

        Console.WriteLine("Digite seu nome:");
        while (nome == "")
        {
            Nome = Console.ReadLine();
        }
        Console.WriteLine();

        Console.WriteLine("Digite seu sobrenome:");
        while (sobrenome == "")
        {
            Sobrenome = Console.ReadLine();
        }
        Console.WriteLine();

        Console.WriteLine("Digite seu email:");
        while (email == "")
        {
            Email = Console.ReadLine();
        }
        Console.WriteLine();
    }

    virtual public void listarEventos()
    {
    }
}
