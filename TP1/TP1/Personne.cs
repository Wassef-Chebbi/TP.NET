using System.Runtime.InteropServices;

namespace TP1;

public class Personne
{
    public string nom;
    private string prenom;
    public int age;
    private int telephone;
    
    //Constructeurs
    public Personne(){} //Constructeur par défaut
    public Personne(string nom, string prenom, int age, int telephone)
    {
        this.nom = nom;
        this.prenom = prenom;
        this.age = age;
        this.telephone = telephone;
    }
    public Personne(Personne p)
    {
        this.nom = p.nom;
        this.prenom = p.prenom;
        this.age = p.age;
        this.telephone = p.telephone;
    }

   
}