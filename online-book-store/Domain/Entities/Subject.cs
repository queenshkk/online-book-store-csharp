namespace OnlineBookStore.Domain.Entities
{
    /*id : int, clé primaire.
    name : string, obligatoire et unique, maximum 50 caractères.
    Relation : une catégorie peut contenir 0 à N livres.
    */
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
