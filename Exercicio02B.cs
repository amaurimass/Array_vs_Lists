using System;

//Desenvolvimento de outra versao do programa de lista de convidados, agora no formato de lista.

public class Exercicio02B
{
	public static void main ()

	{
        List<string> convidados = new List<string>();
        convidados.Add("Antonio");
        convidados.Add("Debora");
        convidados.Add("Tamires");
        convidados.Add("Arthur");
        convidados.Add("Henrique");
        convidados.Add("Amauri");
        convidados.Add("Kelly");
        convidados.Add("Flavio");
        convidados.Add("Karina");
        convidados.Add("Nathalia");

        Console.WriteLine("O número de convidados na lista é de: " + convidados.Count);
        Console.WriteLine("Convidado: " + convidados[0]);
        Console.WriteLine("Convidado: " + convidados[1]);
        Console.WriteLine("Convidado: " + convidados[2]);
        Console.WriteLine("Convidado: " + convidados[3]);
        Console.WriteLine("Convidado: " + convidados[4]);
        Console.WriteLine("Convidado: " + convidados[5]);
        Console.WriteLine("Convidado: " + convidados[6]);
        Console.WriteLine("Convidado: " + convidados[7]);
        Console.WriteLine("Convidado: " + convidados[8]);
        Console.WriteLine("Convidado: " + convidados[9]);
        Console.WriteLine("Convidado: " + convidados[10]);
        Console.WriteLine("Convidado: " + convidados[11]);
    }
}
