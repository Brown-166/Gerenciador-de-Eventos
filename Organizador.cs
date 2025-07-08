using System;


class Organizador : Usuario
{
    public Organizador()
    {

    }

    public Organizador(string cpf, string nome, string sobrenome, string email) : base(cpf, nome, sobrenome, email)
    {

    }

    public void CriarEvento()
    {
        Evento novoEvento = new Evento();
        Console.WriteLine();
        Console.WriteLine("Digite o nome do evento:");
        while (novoEvento.Nome == "")
        {
            novoEvento.Nome = Console.ReadLine();
        }
        Console.WriteLine();

        Console.WriteLine("Digite o local do evento:");
        while (novoEvento.Local == "")
        {
            novoEvento.Local = Console.ReadLine();
        }
        Console.WriteLine();

        Console.WriteLine("Digite em que ano será o evento:");
        int ano = 0;
        while (ano == 0)
        {
            if (int.TryParse(Console.ReadLine(), out int valorAno))
            {
                if (valorAno >= 2025)
                {
                    ano = valorAno;
                }
                else Console.WriteLine("O valor mínimo é 2025");
            }
            else Console.WriteLine("Digite um ano válido");
        }
        Console.WriteLine();

        Console.WriteLine("Digite em que mês será o evento:");
        int mes = 0;
        while (mes == 0)
        {
            if (int.TryParse(Console.ReadLine(), out int valorMes))
            {
                if (valorMes >= 1 && valorMes <= 12)
                {
                    mes = valorMes;
                }
                else Console.WriteLine("O valor mínimo é 01 e o máximo é 12");
            }
            else Console.WriteLine("Digite um mês válido");
        }
        Console.WriteLine();

        Console.WriteLine("Digite em que dia será o evento:");
        int dia = 0;
        while (dia == 0)
        {
            if (int.TryParse(Console.ReadLine(), out int valorDia))
            {
                if (mes == 1 || mes == 5 || mes == 7 || mes == 9 || mes == 11)
                if (valorDia >= 1 && valorDia <= 31)
                {
                    mes = valorMes;
                }
                else Console.WriteLine("O valor mínimo é 01 e o máximo é 12");
            }
            else Console.WriteLine("Digite um mês válido");
        }
        Console.WriteLine();
    }
}