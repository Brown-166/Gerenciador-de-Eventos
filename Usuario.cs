using System;
using System.Numerics;
using System.Text.Json;

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

    private string senha;
    public string Senha
    {
        get { return senha; }
        set { senha = value; }
    }


    public Usuario()
    {
        this.cpf = "";
        this.nome = "";
        this.sobrenome = "";
        this.email = "";
        this.senha = "";
    }

    public Usuario(string cpf, string nome, string sobrenome, string email, string senha)
    {
        this.cpf = "";
        this.nome = "";
        this.sobrenome = "";
        this.email = "";
        this.senha = "";

        this.CPF = cpf;
        this.Nome = nome;
        this.Sobrenome = sobrenome;
        this.Email = email;
        this.Senha = senha;
    }


    public static bool BuscarParametrosDeUsuario(string parametro, string valor, string lista)
    {
        if (File.Exists(lista))
        {
            string listaJSON = File.ReadAllText(lista);
            var listaDeUsuarios = JsonSerializer.Deserialize<List<Participante>>(listaJSON);
            if (listaDeUsuarios != null)
            {
                foreach (var usuario in listaDeUsuarios)
                {
                    var propriedade = usuario.GetType().GetProperty(parametro);
                    if (propriedade != null && propriedade.GetValue(usuario)?.ToString() == valor) {
                        return true;
                    }
                }
            }
        }
        return false;
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
            string emailValor = Console.ReadLine();
            if (BuscarParametrosDeUsuario("Email", emailValor, "listaDeParticipantes.json") || BuscarParametrosDeUsuario("Email", emailValor, "listaDeOrganizadores.json"))
                Console.WriteLine("Esse email já está cadastrado");
            else Email = emailValor;
        }
        Console.WriteLine();

        Console.WriteLine("Cria uma senha:");
        while (senha == "")
        {
            Senha = Console.ReadLine();
        }
        Console.WriteLine();
    }

    virtual public void listarEventos()
    {
    }
}
