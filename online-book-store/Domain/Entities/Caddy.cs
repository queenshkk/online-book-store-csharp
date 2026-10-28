using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NeedfulThings.Domain.Entities
{
    /*id : int, clé primaire.
    clientId : int, clé étrangère obligatoire vers clients.id.
    date : DateTime, obligatoire, date de création du panier.
    amount : decimal, précision (10,2), supérieur ou égal à 0, calculé par l’application.
    payed : bool, obligatoire, valeur par défaut false.
    */
    public class Caddy
    {
        int id { get; set; }
        int clientId { get; set; }
        DateTime date { get; set; }
        decimal amount { get; set; }
        bool payed { get; set; }

        public Client client { get; set; } = null!;

        public List<CaddyItem> caddyItems { get; set; } = new List<CaddyItem>();

    }
}
