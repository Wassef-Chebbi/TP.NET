namespace TP1;

public class Eleve
{
    private string nom; // attribut d'instance cea il est specifique a chaque instance (private)
    private int niveau; // attribut d'instance cea il est specifique a chaque instance (private)
    public int nbEleve; // attribut de classe public partage a toutes les instances de la classe (public)

    Eleve(String n, int niv)
        : base() // ici on a le rincipe d'heritage qui permet d'ecrire cette instruction
    {
        nom = n;
        niveau = niv;
        nbEleve++; // incremente le nombre d'eleves a chaque instanciation de la classe
    }
    Eleve () : this ("Anonyme", 0){ } // c un constructeur qui fait appel a un autre constructeur avec les arguments fournies
    
    
    public string eleve(int niv) // cette methode a pour but de prendre le nouveau niveau de l'eleve, le modifier et retourner son nom
    {
        niveau = niv;
        return nom;
    }
    
    // encapsulation
    public string getNom() { return nom; }
    public void SetNiveau(int niv) { niveau= niv; }
    
    // redefinition de Tostring
    String ToString()  // la methode doit etre ecrite avec un t majiscule
    {
        return "Eleve "+nbEleve+" "+nom+" niveau "+niveau;
    }


}