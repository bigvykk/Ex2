namespace Ex2.Models
{
    public class Client
    {
        public long Numero { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set;}
        public string Courriel { get; set;}
        public Client(long numero, string nom, string prenom, string courriel)
        {
            Numero = numero;
            Nom = nom;
            Prenom = prenom;
            Courriel = courriel;
        }
    }
}
