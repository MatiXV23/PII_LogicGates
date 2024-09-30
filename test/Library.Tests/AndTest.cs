using Library.obj;

namespace Library.Tests;

public class AndTests
{
    [SetUp]
    public void Setup()
    {
    }

    
    
    
    
    [Test]
    public void AgregarEntradasSimple()
    {
        And and1 = new And("And1");
        
        and1.AgregarEntrada("A", 1);
        and1.AgregarEntrada("B", 1);
        
        Assert.That(and1.Entradas.Count, Is.EqualTo(2));
    }
    
    [Test]
    public void AgregarEntradasIguales()
    {
        And and1 = new And("And1");

        and1.AgregarEntrada("A", 1);
        and1.AgregarEntrada("A", 1);
        and1.AgregarEntrada("B", 0);
        
        Assert.That(and1.Entradas.Count, Is.EqualTo(2));
    }

    [Test]
    public void CalculateSimple()
    {
        And and1 = new And("And1");
        
        and1.AgregarEntrada("A", 1);
        and1.AgregarEntrada("B", 1);
        
        Assert.That(and1.Calculate(), Is.EqualTo(1));
    }
    
    [Test]
    public void CalculateSimple0()
    {
        And and1 = new And("And1");
        
        and1.AgregarEntrada("A", 1);
        and1.AgregarEntrada("B", 0);
        
        Assert.That(and1.Calculate(), Is.EqualTo(0));
    }
    
    [Test]
    public void CalculateEmpty()
    {
        And and1 = new And("And1");
        
        Assert.That(and1.Calculate(), Is.EqualTo(0));
    }
}