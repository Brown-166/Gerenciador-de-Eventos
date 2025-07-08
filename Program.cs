using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string comando = "";
        Participante usuarioParticipante;
        Organizador usuarioOrganizador;
        while (comando != "0")
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Para criar um novo participante digite: 1");
            Console.WriteLine("Para criar um novo organizador digite:  2");
            Console.WriteLine("Para entrar como participante digite:   3");
            Console.WriteLine("Para entrar como organizador digite:    4");
            Console.WriteLine("Para encerrar o programa digite:        0");
            Console.WriteLine("------------------------------------------");

            comando = Console.ReadLine();

            if (comando == "1")
            {
                Participante novoUsuario = new Participante();
                novoUsuario.criarUsuario();

                List<Participante> listaDeParticipantes;

                if (File.Exists("listaDeParticipantes.json"))
                {
                    string participantesJSON = File.ReadAllText("listaDeParticipantes.json");
                    listaDeParticipantes = JsonSerializer.Deserialize<List<Participante>>(participantesJSON) ?? new List<Participante>();
                }
                else
                {
                    listaDeParticipantes = new List<Participante>();
                }

                listaDeParticipantes.Add(novoUsuario);
                string listaAtualizada = JsonSerializer.Serialize(listaDeParticipantes, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("listaDeParticipantes.json", listaAtualizada);

                Console.WriteLine("Participante cadastrado com sucesso!");
            }
            else if (comando == "2")
            {
                Organizador novoUsuario = new Organizador();
                novoUsuario.criarUsuario();

                List<Organizador> listaDeOrganizadores;

                if (File.Exists("listaDeOrganizadores.json"))
                {
                    string organizadoresJSON = File.ReadAllText("listaDeOrganizadores.json");
                    listaDeOrganizadores = JsonSerializer.Deserialize<List<Organizador>>(organizadoresJSON) ?? new List<Organizador>();
                }
                else
                {
                    listaDeOrganizadores = new List<Organizador>();
                }

                listaDeOrganizadores.Add(novoUsuario);
                string listaAtualizada = JsonSerializer.Serialize(listaDeOrganizadores, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("listaDeOrganizadores.json", listaAtualizada);

                Console.WriteLine("Organizador cadastrado com sucesso!");
            }

            if (comando == "3")
            {
                string email = "";
                string senha = "";
                string valorEmail = "";
                string valorSenha = "";
                while (email == "")
                {
                    Console.WriteLine("Digite seu email:");
                    valorEmail = Console.ReadLine();

                    if (valorEmail == "0") break;

                    if (Usuario.BuscarParametrosDeUsuario("Email", valorEmail, "listaDeParticipantes.json"))
                        email = valorEmail;
                    else
                    {
                        Console.WriteLine("Esse email não foi cadastrado como participante.");
                        Console.WriteLine("Caso deseje sair, digite: 0");
                    }
                }

                while (senha == "")
                {
                    if (valorEmail == "0") break;

                    Console.WriteLine("Digite sua senha:");
                    valorSenha = Console.ReadLine();

                    if (valorSenha == "0") break;

                    string listaJSON = File.ReadAllText("listaDeParticipantes.json");
                    var listaDeUsuarios = JsonSerializer.Deserialize<List<Participante>>(listaJSON);
                    if (listaDeUsuarios != null)
                    {
                        foreach (var participante in listaDeUsuarios)
                        {
                            if (participante.Email == email)
                            {
                                if (participante.Senha == valorSenha)
                                {
                                    senha = valorSenha;
                                    Console.WriteLine("Seja bem vindo!");
                                    usuarioParticipante = participante;
                                    comando = "5";
                                    break;
                                }
                                else Console.WriteLine("Senha incorreta");
                            }

                        }
                    }
                }
            }
            if (comando == "4")
            {
                string email = "";
                string senha = "";
                string valorEmail = "";
                string valorSenha = "";
                while (email == "")
                {
                    Console.WriteLine("Digite seu email:");
                    valorEmail = Console.ReadLine();

                    if (valorEmail == "0") break;

                    if (Usuario.BuscarParametrosDeUsuario("Email", valorEmail, "listaDeOrganizadores.json"))
                        email = valorEmail;
                    else
                    {
                        Console.WriteLine("Esse email não foi cadastrado como organizador.");
                        Console.WriteLine("Caso deseje sair, digite: 0");
                    }
                }

                while (senha == "")
                {
                    if (valorEmail == "0") break;

                    Console.WriteLine("Digite sua senha:");
                    valorSenha = Console.ReadLine();

                    if (valorSenha == "0") break;

                    string listaJSON = File.ReadAllText("listaDeOrganizadores.json");
                    var listaDeUsuarios = JsonSerializer.Deserialize<List<Organizador>>(listaJSON);
                    if (listaDeUsuarios != null)
                    {
                        foreach (var organizador in listaDeUsuarios)
                        {
                            if (organizador.Email == email)
                            {
                                if (organizador.Senha == valorSenha)
                                {
                                    senha = valorSenha;
                                    Console.WriteLine("Seja bem vindo!");
                                    usuarioOrganizador = organizador;
                                    comando = "6";
                                    break;
                                }
                                else Console.WriteLine("Senha incorreta");
                            }

                        }
                    }
                }
            }

            if (comando == "5")
            {
                Console.WriteLine("Saldo na conta: R$" + usuarioParticipante.Dinheiro);
            }
            if (comando == "6")
        }
    }
}