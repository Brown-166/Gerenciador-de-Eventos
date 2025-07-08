using System;


class Evento
{
    private int id = new Random().Next();
    public int ID
    {
        get { return this.id; }
        set { }
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

    private string local;
    public string Local
    {
        get { return this.local; }
        set
        {
            if (value.Length > 0)
            {
                this.local = value;
            }
            else
            {
                Console.WriteLine("Digite um local válido");
            }
        }
    }

    private DateOnly dataDoEvento;
    public DateOnly DataDoEvento
    {
        get { return dataDoEvento; }
        set { dataDoEvento = value; }
    }

    private TimeOnly horario;
    public TimeOnly Horario
    {
        get { return horario; }
        set { horario = value; }
    }

    private int maxIngressos = 0;
    public int MaxIngressos
    {
        get { return maxIngressos; }
        set
        {
            if (value > 0)
            {
                maxIngressos = value;
            }
            else Console.WriteLine("O número máximo de ingressos deve ser maior que 0");
        }
    }

    private Organizador? responsavel;
    public Organizador? Responsavel
    {
        get { return responsavel; }
        set { responsavel = value; }
    }

    public Evento()
    {
        nome = "";
        local = "";
    }

    public Evento(string nome, string local, DateOnly dataDoEvento, TimeOnly horario, int maxIngressos, Organizador responsavel)
    {
        this.nome = "";
        this.local = "";

        Nome = nome;
        Local = local;
        DataDoEvento = dataDoEvento;
        Horario = horario;
        MaxIngressos = maxIngressos;
        Responsavel = responsavel;
    }

    public void VerIngressosDisponíveis()
    {

    }
}