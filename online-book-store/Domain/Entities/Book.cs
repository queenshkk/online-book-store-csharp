namespace OnlineBookStore.Domain.Entities
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
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int SubjectId { get; set; }
        public string Title { get; set; } = null!;
        public string Isbn { get; set; } = null!;
        public int PageCount { get; set; }
        public int StockQuantity { get; set; }
        public decimal Price { get; set; }
        public int PublishYear { get; set; }

        public Author Author { get; set; } = null!;
        public Subject Subject { get; set; } = null!;

        public List<CaddyItem> CaddyItems { get; set; } = new List<CaddyItem>();
        public List<SellerItem> SellerItems { get; set; } = new List<SellerItem>();
    }
}
