public class Salarié
{
    private int maricule;
    private string nom;
    private string prenom;
    private double salaire;
    private double tauxCS ;

    public int Maricule { get => maricule; set => maricule = value; }
    public string Nom { get => nom; set => nom = value; }
    public string Prenom { get => prenom; set => prenom = value; }
    public double Salaire { get => salaire; set => salaire = value; }
    public double TauxCS { get => tauxCS; set => tauxCS = value; }
    public Salarié(int maricule, string nom, string prenom, double salaire, double tauxCS)
    {
        Maricule = maricule;
        Nom = nom;
        Prenom = prenom;
        Salaire = salaire;
        TauxCS = tauxCS;
    }
}
