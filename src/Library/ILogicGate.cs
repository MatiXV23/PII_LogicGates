namespace Library.obj;

public interface ILogicGate
{
    public string Name { get; }
    public List<Entrada> Entradas { get; }

    public void AgregarEntrada(string name, int valor);
    public int Calculate();
}