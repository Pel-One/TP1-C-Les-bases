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
    public double CalculerSalaireNet()
    {
        const double tauxCSFixe = 0.22;
        return Salaire * (1 - tauxCSFixe);
    }
}
public class Program
{
    public static void Main()
    {
        // Création de deux salariés pour tester
        var salarie1 = new Salarié(1001, "Dupont", "Jean", 3000.00, 0.22);
        var salarie2 = new Salarié(1002, "Martin", "Marie", 4200.50, 0.22);

        // Affichage des résultats
        Console.WriteLine("Test des objets Salarié :");
        Console.WriteLine($"1) {salarie1.Nom} {salarie1.Prenom} (Maricule {salarie1.Maricule}) - Salaire brut : {salarie1.Salaire:C} - Salaire net : {salarie1.CalculerSalaireNet():C}");
        Console.WriteLine($"2) {salarie2.Nom} {salarie2.Prenom} (Maricule {salarie2.Maricule}) - Salaire brut : {salarie2.Salaire:C} - Salaire net : {salarie2.CalculerSalaireNet():C}");
    }
}