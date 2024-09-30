using Library.obj;

namespace Library;

public class Not : ILogicGate
{
    public string Name { get; }
    public List<Entrada> Entradas { get; }

    
    public Not(string name)
    {
        Name = name;
        Entradas = new List<Entrada>();
    }
    
    public void AgregarEntrada(string name, int valor)
    {
        if (Entradas.Count == 0)
        {
            Entrada newEntrada = new Entrada(name, valor);
            Entradas.Add(newEntrada);
        }
        else
        {
            if (Entradas[0].Name == name)
            {
                Entradas[0].Valor = valor;
            }
            else
            {
                Entrada newEntrada = new Entrada(name, valor);
                Entradas[0] = newEntrada;
            }
        }
       
    }
    
    public int Calculate()
    {
        if (Entradas[0].Valor == 1)
        {
            return 0;
        }
        
        return 1;
        
    }

}