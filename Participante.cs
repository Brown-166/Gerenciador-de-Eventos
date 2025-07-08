using System;


class Participante : Usuario
{
    private float dinheiro = 0;
    public float Dinheiro
    {
        get { return dinheiro; }
        set
        {
            if (value > 0)
            {
                this.dinheiro = value;
            }
            else Console.WriteLine("O valor deve ser maior que 0");
        }
    }

    public Participante()
    {

    }

    public Participante(string cpf, string nome, string sobrenome, string email, string senha, float dinheiro) : base(cpf, nome, sobrenome, email, senha)
    {
        this.Dinheiro = dinheiro;
    }

    public override void criarUsuario()
    {
        base.criarUsuario();
        Console.WriteLine("Digite a quantidade de dinheiro que você pode gastar:");
        while (dinheiro == 0)
        {
            if (float.TryParse(Console.ReadLine(), out float valorDinheiro))
            {
                Dinheiro = valorDinheiro;
            }
            else Console.WriteLine("Digite um valor válido");
            Console.WriteLine();
        }
    }
}