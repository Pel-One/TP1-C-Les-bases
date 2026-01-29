using System;

public class Salarié
{
    private int maricule;
    private string nom;
    private string prenom;
    private double salaire;
    private double tauxCS;

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

public class Fournisseur
{
    private int idF;
    private string nomF;
    private string adresseF;

    public int IdF { get => idF; set => idF = value; }
    public string NomF { get => nomF; set => nomF = value; }
    public string AdresseF { get => adresseF; set => adresseF = value; }
    public Fournisseur() { }
    public Fournisseur(int idF, string nomF, string adresseF)
    {
        IdF = idF;
        NomF = nomF;
        AdresseF = adresseF;
    }
    public void Afficher()
    {
        Console.WriteLine("fournisseur :");
        Console.WriteLine($"idf : {IdF}");
        Console.WriteLine($"nom : {NomF}");
        Console.WriteLine($"adresse : {AdresseF}");
    }
}

public class Auteur
{
    private int idA;
    private string nomA;
    private string prenomA;

    public int IdA { get => idA; set => idA = value; }
    public string NomA { get => nomA; set => nomA = value; }
    public string PrenomA { get => prenomA; set => prenomA = value; }

    public Auteur() { }

    public Auteur(int idA, string nomA, string prenomA)
    {
        IdA = idA;
        NomA = nomA;
        PrenomA = prenomA;
    }

    public void Afficher()
    {
        Console.WriteLine($"Auteur {NomA} {PrenomA} (numéro {IdA})");
    }
}

public class Livre
{
    private string titre;
    private string annee;
    private int nPage;
    private int prix;
    private Fournisseur fournisseurLivre;
    private Auteur auteurLivre;

    public string Titre { get => titre; set => titre = value; }
    public string Annee { get => annee; set => annee = value; }
    public int NPage { get => nPage; set => nPage = value; }
    public int Prix { get => prix; set => prix = value; }
    public Fournisseur FournisseurLivre { get => fournisseurLivre; set => fournisseurLivre = value; }
    public Auteur AuteurLivre { get => auteurLivre; set => auteurLivre = value; }

    public Livre(string titre, string annee, int nPage, int prix)
    {
        Titre = titre;
        Annee = annee;
        NPage = nPage;
        Prix = prix;
        FournisseurLivre = null;
        AuteurLivre = null;
    }

    public Livre(string titre, string annee, int nPage, int prix, Fournisseur fournisseur, Auteur auteur)
        : this(titre, annee, nPage, prix)
    {
        FournisseurLivre = fournisseur;
        AuteurLivre = auteur;
    }

    public void Afficher()
    {
        Console.WriteLine("Livre :");
        Console.WriteLine($"Titre : {Titre}");
        Console.WriteLine($"Année : {Annee}");
        Console.WriteLine($"Nombre de pages : {NPage}");
        Console.WriteLine($"prix : {Prix}");
        Console.WriteLine();

        if (this.AuteurLivre != null)
        {
            this.AuteurLivre.Afficher();
            Console.WriteLine();
        }

        if (this.FournisseurLivre != null)
        {
            this.FournisseurLivre.Afficher();
            Console.WriteLine();
        }
    }
}

public class Program
{
    public static void Main()
    {
        var salarie1 = new Salarié(1001, "Dupont", "Jean", 3000.00, 0.22);
        var salarie2 = new Salarié(1002, "Martin", "Marie", 4200.50, 0.22);

        Console.WriteLine("Test des objets Salarié :");
        Console.WriteLine($"1) {salarie1.Nom} {salarie1.Prenom} (Maricule {salarie1.Maricule}) - Salaire brut : {salarie1.Salaire:C} - Salaire net : {salarie1.CalculerSalaireNet():C}");
        Console.WriteLine($"2) {salarie2.Nom} {salarie2.Prenom} (Maricule {salarie2.Maricule}) - Salaire brut : {salarie2.Salaire:C} - Salaire net : {salarie2.CalculerSalaireNet():C}");

        Console.WriteLine();
        var fournisseur = new Fournisseur(1, "toto", "1 allée du parc au loup bas");
        var auteur = new Auteur(1, "Rolland", "Stéphane");

        var livreSans = new Livre("apprenez C#", "2017", 250, 25);
        livreSans.Afficher();

        var livreAvec = new Livre("apprenez C#", "2017", 250, 25, fournisseur, auteur);
        livreAvec.Afficher();
    }
}