namespace OnlineBookStore.Domain.Entities
{
    /*id : int, clé primaire.
    name : string, obligatoire, maximum 100 caractères.
    TVA : string, obligatoire et unique, maximum 30 caractères ; représente le numéro de TVA du
    vendeur.
    */
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string TVA { get; set; } = null!;

        public List<SellerItem> SellerItems { get; set; } = new List<SellerItem>();
        public List<CaddyItem> CaddyItems { get; set; } = new List<CaddyItem>();
    }
}
