
namespace TP2;

public class Ex2
{
    

}
    


// Classe Point3D pour représenter un point en 3D
public class Point3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public override string ToString()
    {
        return $"[Point3D x: {X}, y: {Y}, z: {Z}]";
    }
}

// Classe Forme (abstraite)
public abstract class Forme
{
    public Point3D CentreDeGravite { get; set; }

    public Forme(Point3D centreDeGravite)
    {
        CentreDeGravite = centreDeGravite;
    }

    // Méthode abstraite pour bouger la forme
    public abstract void Bouger(double x, double y, double z);

    // Méthodes abstraites pour calculer la surface et le volume de la forme
    public abstract double CalculerSurface();
    public abstract double CalculerVolume();
    
    public override string ToString()
    {
        return $"[{GetType().Name}\ncentre de gravité : {CentreDeGravite}]";
    }
}

// Classe Brique
public class Brique : Forme
{
    public double Largeur { get; set; }
    public double Longueur { get; set; }
    public double Hauteur { get; set; }

    public Brique(Point3D centreDeGravite, double largeur, double longueur, double hauteur) : base(centreDeGravite)
    {
        Largeur = largeur;
        Longueur = longueur;
        Hauteur = hauteur;
    }

    public override void Bouger(double x, double y, double z)
    {
        CentreDeGravite.X += x;
        CentreDeGravite.Y += y;
        CentreDeGravite.Z += z;
    }

    public override double CalculerSurface()
    {
        return 2 * (Largeur * Longueur + Longueur * Hauteur + Hauteur * Largeur);
    }

    public override double CalculerVolume()
    {
        return Largeur * Longueur * Hauteur;
    }
    public override string ToString()
    {
        return $"[{GetType().Name}\ncentre de gravité : {CentreDeGravite}\nlargeur : {Largeur}\nlongueur : {Longueur}\nhauteur : {Hauteur}]";
    }
}

// Classe Cube 
public sealed class Cube : Brique
{
    public Cube(Point3D centreDeGravite, double cote) : base(centreDeGravite, cote, cote, cote)
    {
    }
}

// Classe Boule
public class Boule : Forme
{
    public double Rayon { get; set; }

    public Boule(Point3D centreDeGravite, double rayon) : base(centreDeGravite)
    {
        Rayon = rayon;
    }

    public override void Bouger(double x, double y, double z)
    {
        CentreDeGravite.X += x;
        CentreDeGravite.Y += y;
        CentreDeGravite.Z += z;
    }

    public override double CalculerSurface()
    {
        return 4 * Math.PI * Math.Pow(Rayon, 2);
    }

    public override double CalculerVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(Rayon, 3);
    }
    
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Boule other = (Boule)obj;
        return CentreDeGravite.Equals(other.CentreDeGravite) && Rayon == other.Rayon;
    }
}
