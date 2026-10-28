namespace NeedfulThings.Domain.Entities
{
    /*id : int, clé primaire.
    name : string, obligatoire, maximum 100 caractères.
    TVA : string, obligatoire et unique, maximum 30 caractères ; représente le numéro de TVA du
    vendeur.
    */
    public class Seller
    {
        int id { get; set; }
        string name { get; set; } = null!;
        string TVA { get; set; } = null!;

        public List<SellerItem> sellerItems { get; set; } = new List<SellerItem>();
        public List<CaddyItem> caddyItems { get; set; } = new List<CaddyItem>();
    }
}
