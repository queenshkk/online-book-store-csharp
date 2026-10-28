namespace OnlineBookStore.Domain.Entities
{
   /*Auteur — authors
   id : int, clé primaire.
   last_name : string, obligatoire, maximum 50 caractères.
   first_name : string, obligatoire, maximum 50 caractères.
   birth_date : DateOnly ou DateTime, obligatoire, antérieure à la date du jour.
   */
    public class Author
    {
        public int Id { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public DateTime BirthDate { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();

    }
}

