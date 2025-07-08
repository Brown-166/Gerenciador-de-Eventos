using System;


class Organizador : Usuario
{
    public Organizador()
    {

    }

    public Organizador(string cpf, string nome, string sobrenome, string email, string senha) : base(cpf, nome, sobrenome, email, senha)
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
                        dia = valorDia;
                    }
                    else Console.WriteLine("O valor mínimo para o mês " + mes + " é 01 e o máximo é 31");
                else if (mes == 2 || mes == 4 || mes == 6 || mes == 8 || mes == 10 || mes == 12)
                    if (valorDia >= 1 && valorDia <= 30)
                    {
                        dia = valorDia;
                    }
                    else Console.WriteLine("O valor mínimo para o mês " + mes + " é 01 e o máximo é 30");
            }
            else Console.WriteLine("Digite um dia válido");
        }
        Console.WriteLine();

        DateOnly dataCriada = new DateOnly(ano, mes, dia);
        novoEvento.DataDoEvento = dataCriada;

        Console.WriteLine("Digite a que horas será o evento (apenas a hora):");
        int hora = 24;
        while (hora == 24)
        {
            if (int.TryParse(Console.ReadLine(), out int valorHora))
            {
                if (valorHora >= 0 && valorHora <= 23)
                {
                    hora = valorHora;
                }
                else Console.WriteLine("O valor mínimo para o hora é 00 e o máximo é 23");
            }
            else Console.WriteLine("Digite uma hora válida");
        }
        Console.WriteLine();

        Console.WriteLine("Digite agora o minuto:");
        int minuto = 60;
        while (minuto == 60)
        {
            if (int.TryParse(Console.ReadLine(), out int valorMinuto))
            {
                if (valorMinuto >= 0 && valorMinuto <= 59)
                {
                    minuto = valorMinuto;
                }
                else Console.WriteLine("O valor mínimo para minutos é 00 e o máximo é 59");
            }
            else Console.WriteLine("Digite um minuto válido");
        }
        Console.WriteLine();

        TimeOnly horaCriada = new TimeOnly(hora, minuto);
        novoEvento.Horario = horaCriada;

        Console.WriteLine("Digite o número máximo de ingressos:");
        while (novoEvento.MaxIngressos == 0)
        {
            if (int.TryParse(Console.ReadLine(), out int valorMax))
            {
                novoEvento.MaxIngressos = valorMax;
            }
            else Console.WriteLine("Digite um número válido");
        }
        Console.WriteLine();

        Console.WriteLine("Digite o cpf do organizador do evento:");
        string cpfOrganizador = "";
        while (cpfOrganizador == "")
        {
            string lerLinha = Console.ReadLine();
            if (lerLinha.Length == 11 && long.TryParse(lerLinha, out long lerLinhaINT) && lerLinhaINT > 0)
            {
                cpfOrganizador = lerLinha;
            }
            else
            {
                Console.WriteLine("CPF inválido");
                Console.WriteLine("Digite apenas números. Exemplo: 15362475982");
            }
        }
        Console.WriteLine();
    }
}