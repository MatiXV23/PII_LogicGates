using Library.obj;

namespace Library.Tests;

public class GarageGateTest
{
    [SetUp]
    public void Setup()
    {
    }




    [Test]
    public void PressButtonA()
    {
        GarageGate garageGate = new GarageGate();
        
        garageGate.PressButtonABC("A");
        Assert.That(garageGate.BotonA, Is.EqualTo(1));
    }
    [Test]
    
    public void PressButtonB()
    {
        GarageGate garageGate = new GarageGate();
        
        garageGate.PressButtonABC("B");
        Assert.That(garageGate.BotonB, Is.EqualTo(1));
    }
    [Test]
    
    public void PressButtonC()
    {
        GarageGate garageGate = new GarageGate();
        
        garageGate.PressButtonABC("C");
        Assert.That(garageGate.BotonC, Is.EqualTo(1));
    }
    
    [Test]
    public void ReleaseButtonA()
    {
        GarageGate garageGate = new GarageGate();
        
        garageGate.ReleaseButtonABC("A");
        Assert.That(garageGate.BotonA, Is.EqualTo(0));
    }
    [Test]
    
    public void ReleaseButtonB()
    {
        GarageGate garageGate = new GarageGate();
        
        garageGate.ReleaseButtonABC("B");
        Assert.That(garageGate.BotonB, Is.EqualTo(0));
    }
    [Test]
    
    public void ReleaseButtonC()
    {
        GarageGate garageGate = new GarageGate();
        
        garageGate.ReleaseButtonABC("C");
        Assert.That(garageGate.BotonC, Is.EqualTo(0));
    }
    
    [Test]
    public void AllButtonsCombinationsTest()
    {
        string result = "";
        GarageGate garageGate = new GarageGate();
        int aux = 0;
        for (int i = 0; i < 2; i++)
        {
            garageGate.ReleaseButtonABC("b");
            for (int j = 0; j < 2; j++)
            {
                garageGate.ReleaseButtonABC("a");
                for (int k = 0; k < 2; k++)
                {
                    aux++;
                    result += $"\n\n Coombinacion {aux}";
                    result += "\n"+garageGate.ButtonPrinterMSG();
                    result += $"\n Salida: {garageGate.Calculate()}";
                    
                    garageGate.PressButtonABC("a");   
                }
                garageGate.PressButtonABC("B");
            }
            garageGate.PressButtonABC("c");
        }

       
        File.WriteAllText("../../../TestGarageOutput.txt", result);
        FileAssert.AreEqual("../../../ExpectedGarageOutput.txt", "../../../TestGarageOutput.txt");
        
    }
}