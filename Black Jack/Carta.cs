using System;

public class Carta
{
	public Naipe naipe { get; private set; }
	public string nome { get; private set; }
    public int valor { get; private set; }
	public Bitmap imagem { get; private set; }

    public Carta(Naipe naipe, string nome, int valor, Bitmap imagem)
	{
		this.naipe = naipe;
		this.nome = nome;
		this.valor = valor;
		this.imagem = imagem;
	}
}
