using Library.obj;

namespace Library;


public class And : ILogicGate
{
    public string Name { get; }
    public List<Entrada> Entradas { get; }
    
    public And(string name)
    {
        Name = name;
        Entradas = new List<Entrada>();
    }
    
    
    public void AgregarEntrada(string name, int valor)
    {
        if (ExistEn(name) != -1)
        {
            Entradas[ExistEn(name)].Valor = valor;
        }
        else
        {
            Entrada newEntrada = new Entrada(name, valor);
            Entradas.Add(newEntrada);
        }
    }
    
    public int Calculate()
    {
        int prod = 0;
        int aux = 1;
        foreach (var entrada in Entradas)
        {
            aux *= entrada.Valor;
            prod = aux;
        }
        
        return prod;
    }

    private int ExistEn(string name)
    {
        int index = -1;
        int aux = 0;
        foreach (var entrada in Entradas)
        {
            if (entrada.Name == name)
            {
                index = aux;
            }
            aux++;
        }

        return index;
    }
}
