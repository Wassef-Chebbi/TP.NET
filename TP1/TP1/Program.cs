// See https://aka.ms/new-console-template for more information

using TP1;

class Program
{
    static void Main(string[] args)
    {
        //##################### EX1 #####################
        // Personne p = new Personne("wassef","chebbi",23,42103322);
        // Console.WriteLine("Name: " + p.nom);
        // Console.WriteLine("Age: " + p.age);
        
        //##################### EX2 #####################
        Equation monEquation = new Equation(1, 4, 1);
        monEquation.coefficientA = 0; // le resultat affiché est juste puisque dans tous les cas on n'aura as de recines reelles !
        monEquation.CalculRacines();
        Console.WriteLine(monEquation.ToString());
    }
}

