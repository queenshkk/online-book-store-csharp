namespace OnlineBookStore.Domain.Entities
{

    /*id : int, clé primaire.
    caddyId : int, clé étrangère obligatoire vers caddies.id.
    bookId : int, clé étrangère obligatoire vers books.id.
    sellerId : int, clé étrangère obligatoire vers seller.id.
    quantity : int, strictement supérieur à 0.
    */
    public class CaddyItem
    {
        public int Id { get; set; }
        public int CaddyId { get; set; }
        public int BookId { get; set; }
        public int SellerId { get; set; }
        public int Quantity { get; set; }

        public Caddy Caddy { get; set; } = null!;
        public Book Book { get; set; } = null!;
        public Seller Seller { get; set; } = null!;
    }
}
