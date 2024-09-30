using Library.obj;

namespace Library.Tests;

public class NotTests
{
    [SetUp]
    public void Setup()
    {
    }

    
    
    
    
    [Test]
    public void AgregarEntradasSimple()
    {
        Not not1 = new Not("Not1");
        
        not1.AgregarEntrada("A", 1);
        
        Assert.That(not1.Entradas.Count, Is.EqualTo(1));
    }
    
    [Test]
    public void AgregarEntradasCambioDeEntrada()
    {
        Not not1 = new Not("Not1");
        
        not1.AgregarEntrada("A", 1);
        not1.AgregarEntrada("B", 1);
        
        Assert.That(not1.Entradas.Count, Is.EqualTo(1));
    }
    
    [Test]
    public void Calculate0()
    {
        Not not1 = new Not("Not1");
        
        not1.AgregarEntrada("A", 1);
        
        Assert.That(not1.Calculate(), Is.EqualTo(0));
    }
    
    [Test]
    public void Calculate1()
    {
        Not not1 = new Not("Not1");
        
        not1.AgregarEntrada("A", 0);
        
        Assert.That(not1.Calculate(), Is.EqualTo(1));
    }
    
}