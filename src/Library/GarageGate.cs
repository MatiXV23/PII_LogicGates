namespace Library.obj;

public class GarageGate
{
    public int BotonA = 0;
    public int BotonB = 0;
    public int BotonC = 0;

    public void ButtonPrinter()
    {
        Console.WriteLine($"C: {BotonC}   B: {BotonB}   A: {BotonA}");
    }
    public void PressButtonABC(string button)
    {
        switch (button.ToUpper())
        {
            case "A":
                BotonA = 1;
                break;
            case "B":
                BotonB = 1;
                break;
            case "C":
                BotonC = 1;
                break;
        }
        
    }

    public void ReleaseButtonABC(string button)
    {
        switch (button.ToUpper())
        {
            case "A":
                BotonA = 0;
                break;
            case "B":
                BotonB = 0;
                break;
            case "C":
                BotonC = 0;
                break;
        }
    }
    
    public int Calculate()
    {
        int aux = 0;
        
        Not notA = new Not("notA");
        Not notB = new Not("notB");

        Or or = new Or("or");

        And andAb = new And("andAB");
        And andAbN = new And("andAbN");
        And andFinal = new And("andFinal");
        
        notA.AgregarEntrada("botonA", BotonA);
        notB.AgregarEntrada("botonA", BotonB);
        
        andAb.AgregarEntrada("botonA",BotonA);
        andAb.AgregarEntrada("botonB",BotonB);
        
        andAbN.AgregarEntrada(notA.Name,notA.Calculate());
        andAbN.AgregarEntrada(notB.Name,notB.Calculate());
        
        or.AgregarEntrada(andAb.Name,andAb.Calculate());
        or.AgregarEntrada(andAbN.Name,andAbN.Calculate());
        
        andFinal.AgregarEntrada(or.Name,or.Calculate());
        andFinal.AgregarEntrada("botonC",BotonC);
        
        return andFinal.Calculate();
    }
}