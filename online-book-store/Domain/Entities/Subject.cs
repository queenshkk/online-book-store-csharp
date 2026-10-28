namespace NeedfulThings.Domain.Entities
{
    /*id : int, clé primaire.
        name : string, obligatoire et unique, maximum 50 caractères.
        Relation : une catégorie peut contenir 0 à N livres.
        */
    public class Subject
    {
        int id { get; set; }
        string name { get; set; } = null!;

        public List<Book> books { get; set; } = new List<Book>();
    }
}
