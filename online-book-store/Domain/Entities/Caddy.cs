using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OnlineBookStore.Domain.Entities
{
    /*id : int, clé primaire.
    clientId : int, clé étrangère obligatoire vers clients.id.
    date : DateTime, obligatoire, date de création du panier.
    amount : decimal, précision (10,2), supérieur ou égal à 0, calculé par l’application.
    payed : bool, obligatoire, valeur par défaut false.
    */
    public class Caddy
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public bool Payed { get; set; }

        public Client Client { get; set; } = null!;

        public List<CaddyItem> CaddyItems { get; set; } = new List<CaddyItem>();

    }
}
