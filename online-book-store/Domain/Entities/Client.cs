using Microsoft.SqlServer.Server;

namespace OnlineBookStore.Domain.Entities
{
    /*id : int, clé primaire et numéro de client.
    nom : string, obligatoire, maximum 50 caractères.
    prénom : string, obligatoire, maximum 50 caractères.
    email : string, obligatoire et unique, maximum 254 caractères, format valide.
    adresse : string, obligatoire, maximum 200 caractères.
    code_postal : string, obligatoire, maximum 20 caractères.
    ville : string, obligatoire, maximum 100 caractères.
    pays : string, obligatoire, maximum 100 caractères.
    telephone : string, facultatif, maximum 30 caractères.
    */
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Adresse { get; set; } = null!;
        public string CodePostal { get; set; } = null!;
        public string Ville { get; set; } = null!;
        public string Pays { get; set; } = null!;
        public string? Telephones { get; set; } = null!;

        public List<Caddy> Caddies { get; set; } = new List<Caddy>();
    }
}
