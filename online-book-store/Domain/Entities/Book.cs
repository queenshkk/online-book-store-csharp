namespace NeedfulThings.Domain.Entities
{
    /*id : int, clé primaire.
    author_id : int, clé étrangère obligatoire vers authors.id.
    subject_id : int, clé étrangère obligatoire vers subjects.id.
    title : string, obligatoire, maximum 200 caractères.
    isbn : string, obligatoire et unique, contenant un ISBN-13 valide de 13 chiffres, enregistré sans
    séparateurs.
    page_count : int, strictement supérieur à 0.
    stock_quantity : int, supérieur ou égal à 0. Déplacer vers le vendeur
    price : decimal, précision (10,2), strictement supérieur à 0. Déplacer vers le vendeur
    publish_year : int, compris entre 1450 et l’année courante.
     */
    public class Book
    {
        int id { get; set; }
        int author_id { get; set; }
        int subject_id { get; set; }
        string title { get; set; } = null!;
        string isbn { get; set; } = null!;
        int page_count { get; set; }
        int stock_quantity { get; set; }
        decimal price { get; set; }
        int publish_year { get; set; }

        public Author author { get; set; } = null!;
        public Subject subject { get; set; } = null!;

        public List<CaddyItem> caddyItems { get; set; } = new List<CaddyItem>();
        public List<SellerItem> sellerItems { get; set; } = new List<SellerItem>();
    }
}
