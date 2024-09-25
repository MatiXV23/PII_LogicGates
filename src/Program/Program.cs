using Library;
using Library.obj;

namespace Program;

class Program
{
    static void Main(string[] args)
    {
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
                    Console.WriteLine($"\n Coombinacion {aux}");
                    garageGate.ButtonPrinter();
                    Console.WriteLine($" Salida: {garageGate.Calculate()}");
                    
                    garageGate.PressButtonABC("a");   
                }
                garageGate.PressButtonABC("B");
            }
            garageGate.PressButtonABC("c");
        }
    }
    
    static void GarageTest()
    {
        GarageGate garageGate = new GarageGate();
        Console.WriteLine(garageGate.Calculate());
        
        garageGate.PressButtonABC("c");
        Console.WriteLine(garageGate.Calculate());
        
        garageGate.PressButtonABC("a");
        Console.WriteLine(garageGate.Calculate());
        
        garageGate.PressButtonABC("B");
        Console.WriteLine(garageGate.Calculate());
        
        garageGate.ReleaseButtonABC("C");
        Console.WriteLine(garageGate.Calculate());
    }
    static void Test1()
    {
        And and1 = new And("and1");
        and1.AgregarEntrada("A", 1);
        and1.AgregarEntrada("B", 1);


        Or or2 = new Or("or2");
        or2.AgregarEntrada("C",0);
        or2.AgregarEntrada(and1.Name, and1.Calculate());

        
        Not not3 = new Not("not3");
        not3.AgregarEntrada(or2.Name,or2.Calculate());
        
        
        Console.WriteLine($"Resultado final: {not3.Calculate()}");
    }
}
    