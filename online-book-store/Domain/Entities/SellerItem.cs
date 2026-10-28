namespace NeedfulThings.Domain.Entities
{

    /*sellerId : int, clé étrangère obligatoire vers sellers.id.
    bookId : int, clé étrangère obligatoire vers books.id.
    quantity_in_stock et price (voir book).
    */
    public class SellerItem
    {
        int sellerId { get; set; }
        int bookId { get; set; }
        int quantity_in_stock { get; set; }

        public Seller seller { get; set; } = null!;
        public Book book { get; set; } = null!;

    }
}
