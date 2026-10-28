using Microsoft.SqlServer.Server;

namespace NeedfulThings.Domain.Entities
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
        int id { get; set; }
        string nom { get; set; } = null!;
        string prenom { get; set; } = null!;
        string email { get; set; } = null!;
        string adresse { get; set; } = null!;
        string code_postal { get; set; } = null!;
        string ville { get; set; } = null!;
        string pays { get; set; } = null!;
        string? telephone { get; set; } = null!;

        public List<Caddy> caddies { get; set; } = new List<Caddy>();
    }
}
