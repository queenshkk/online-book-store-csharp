namespace NeedfulThings.Domain.Entities
{

    /*id : int, clé primaire.
    caddyId : int, clé étrangère obligatoire vers caddies.id.
    bookId : int, clé étrangère obligatoire vers books.id.
    sellerId : int, clé étrangère obligatoire vers seller.id.
    quantity : int, strictement supérieur à 0.
    */
    public class CaddyItem
    {
        int id { get; set; }
        int caddyId { get; set; }
        int bookId { get; set; }
        int sellerId { get; set; }
        int quantity { get; set; }

        public Caddy caddy { get; set; } = null!;
        public Book book { get; set; } = null!;
        public Seller seller { get; set; } = null!;
    }
}
