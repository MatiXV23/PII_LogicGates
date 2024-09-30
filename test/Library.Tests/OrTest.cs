using Library.obj;

namespace Library.Tests;

public class OrTests
{
    [SetUp]
    public void Setup()
    {
    }

    
    
    [Test]
    public void AgregarEntradasSimple()
    {
        Or or1 = new Or("Or1");
        
        or1.AgregarEntrada("A", 1);
        or1.AgregarEntrada("B", 1);
        
        Assert.That(or1.Entradas.Count, Is.EqualTo(2));
    }
    
    [Test]
    public void AgregarEntradasIguales()
    {
        Or or1 = new Or("Or1");

        or1.AgregarEntrada("A", 1);
        or1.AgregarEntrada("A", 1);
        or1.AgregarEntrada("B", 0);
        
        Assert.That(or1.Entradas.Count, Is.EqualTo(2));
    }

    [Test]
    public void CalculateSimple()
    {
        Or or1 = new Or("Or1");
        
        or1.AgregarEntrada("A", 1);
        or1.AgregarEntrada("B", 1);
        
        Assert.That(or1.Calculate(), Is.EqualTo(1));
    }
    
    [Test]
    public void CalculateSimpleDouble0()
    {
        Or or1 = new Or("Or1");
        
        or1.AgregarEntrada("A", 0);
        or1.AgregarEntrada("B", 0);
        
        Assert.That(or1.Calculate(), Is.EqualTo(0));
    }
    
    [Test]
    public void CalculateEmpty()
    {
        Or or1 = new Or("Or1");
        
        Assert.That(or1.Calculate(), Is.EqualTo(0));
    }
}