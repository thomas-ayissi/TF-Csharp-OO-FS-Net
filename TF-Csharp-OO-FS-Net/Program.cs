using TF_Csharp_OO_FS_Net.Models;

Console.WriteLine();

Personne personne = new Personne();

personne.Prenom = "Dimitri";
personne.Nom = "DelaHaute";
personne.DateNaiss = DateTime.Now;

Courant courant = new Courant();

courant.Numero = "ABC123";
courant.LigneDeCredit = 400;
courant.Titulaire = personne;


Console.WriteLine($"Le Proprio du compte {courant.Numero} est {courant.Titulaire.Prenom} {courant.Titulaire.Nom}");


Indexeur indexeur = new Indexeur();

indexeur[1] = "RO34623462346";

Console.WriteLine(indexeur["fr"]);
