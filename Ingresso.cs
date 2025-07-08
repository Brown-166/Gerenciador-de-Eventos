using System;


class Ingresso
{
    private int id = new Random().Next();
    public int ID
    {
        get { return this.id; }
        set { }
    }

    private float preco;
    public float Preco
    {
        get { return preco; }
        set
        {
            if (value >= 0)
            {
                this.preco = value;
            }
            else Console.WriteLine("O preço do ingresso deve ser maior ou igual a 0");
        }
    }

    private Participante? dono;
    public Participante? Dono
    {
        get { return dono; }
        set { dono = value; }
    }
    /*
    private Evento eventoDoIngresso;
    public Evento EventoDoIngresso
    {
        get { return eventoDoIngresso; }
        set { eventoDoIngresso = value; }
    } 
    */

    public Ingresso()
    {

    }
    public Ingresso(int id, float preco)
    {
        ID = id;
        Preco = preco;
    }

    public Ingresso(int id, float preco, Participante dono)
    {
        ID = id;
        Preco = preco;
        Dono = dono;
    }


    public void ComprarIngresso()
    {
        
    }
}