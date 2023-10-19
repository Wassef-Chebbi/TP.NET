namespace TP1;

public class Equation
{

    private double CoefficientA;
    private double CoefficientB;
    private double CoefficientC;
    
    public double coefficientA
    {
        get { return CoefficientA; }
        set { CoefficientA = value; }
    }
    public double coefficientB
    {
        get { return CoefficientB; }
         set { CoefficientB = value; }
    }
    public double coefficientC
    {
        get { return CoefficientC; }
         set { CoefficientC = value; }
    }

    private double Delta;
    private double Racine1;
    private double Racine2;
    
    public double delta
    {
        get { return Delta; }
        private set { Delta = value; }
    }

    public double racine1
    {
        get { return Racine1; }
        private set { Racine1 = value; }
    }

    public double racine2
    {
        get { return Racine2; }
        private set { Racine2 = value; }
    }

    
    public Equation(double a, double b, double c)
    {
        CoefficientA = a;
        CoefficientB = b;
        CoefficientC = c;
    }
    
    public void CalculRacines()
    {
        Delta = CoefficientB * CoefficientB - 4 * CoefficientA * CoefficientC;

        if (delta >= 0)
        {
            Racine1 = (-CoefficientB + Math.Sqrt(delta)) / (2 * CoefficientA);
            Racine2 = (-CoefficientB - Math.Sqrt(delta)) / (2 * CoefficientA);
        }
        else
        { 
            Racine1 = double.NaN; // Racine non réelle (NaN : Not a Number)
            Racine2 = double.NaN; // Racine non réelle (NaN : Not a Number)
        }
    }
    
    public override string ToString()
    {
        string equationString = $"Equation {CoefficientA}*x^2 + {CoefficientB}*x + {CoefficientC} = 0.";

        if (double.IsNaN(racine1) || double.IsNaN(racine2))
        {
            equationString += " Pas de racine réelle.";
        }
        else
        {
            equationString += $" Racines {racine1} et {racine2}";
        }

        return equationString;
    }

}