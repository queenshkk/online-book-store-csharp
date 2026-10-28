namespace OnlineBookStore.Domain.Entities
{
    /*sellerId : int, clé étrangère obligatoire vers sellers.id.
    bookId : int, clé étrangère obligatoire vers books.id.
    quantity_in_stock et price (voir book).
    */
    public class SellerItem
    {
        public int SellerId { get; set; }
        public int BookId { get; set; }
        public int QuantityInStock { get; set; }
        public decimal Price { get; set; }

        public Seller Seller { get; set; } = null!;
        public Book Book { get; set; } = null!;

    }
}
