namespace Library;

public class Entrada
{
    public string Name;
    public int Valor;

    public Entrada(string name, int valor)
    {
        if (valor > -1 || valor < 2)
        {
            Name = name;
            Valor = valor;
        }
        else
        {
            Console.WriteLine("Valor invalido");
        }
    }
}