namespace NeedfulThings.Domain.Entities
{
    /*Auteur — authors
    id : int, clé primaire.
    last_name : string, obligatoire, maximum 50 caractères.
    first_name : string, obligatoire, maximum 50 caractères.
    birth_date : DateOnly ou DateTime, obligatoire, antérieure à la date du jour.
    */
    public class Author
    {
        public int id { get; set; }
        public string last_name { get; set; } = null!;
        public string first_name { get; set; } = null!;
        public DateOnly birth_date { get; set; }

        public List<Book> books { get; set; } = new List<Book>();

    }
}
