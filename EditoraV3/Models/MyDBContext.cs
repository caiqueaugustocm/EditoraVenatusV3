using System.Data.Entity;

namespace EditoraV3.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }
        public System.Data.Entity.DbSet<EditoraV3.Models.Autor> autors { get; set; }
        public System.Data.Entity.DbSet<EditoraV3.Models.Classificao> classificaos { get; set; }
        public System.Data.Entity.DbSet<EditoraV3.Models.Cliente> clientes { get; set; }
        public System.Data.Entity.DbSet<EditoraV3.Models.Compra> compras { get; set; }
        public System.Data.Entity.DbSet<EditoraV3.Models.Cupom> cupoms { get; set; }

        public System.Data.Entity.DbSet<EditoraV3.Models.Escola> escolas { get; set; }
        public System.Data.Entity.DbSet<EditoraV3.Models.Endereco> enderecos { get; set; }
        public System.Data.Entity.DbSet<EditoraV3.Models.Estoque> estoques { get; set; }

        public System.Data.Entity.DbSet<EditoraV3.Models.Livraria> livrarias { get; set; }
        public System.Data.Entity.DbSet<EditoraV3.Models.Livro> livros { get; set; }
        public System.Data.Entity.DbSet<EditoraV3.Models.Pessoa> pessoas { get; set; }
        public System.Data.Entity.DbSet<EditoraV3.Models.RedeSocial> redeSocials { get; set; }
        public System.Data.Entity.DbSet<EditoraV3.Models.Telefone> telefones { get; set; }
        public System.Data.Entity.DbSet<EditoraV3.Models.Tipo> tipos { get; set; }

        public System.Data.Entity.DbSet<EditoraV3.Models.Login> Logins { get; set; }
        public System.Data.Entity.DbSet<EditoraV3.Models.Evento> eventos { get; set; }
        public System.Data.Entity.DbSet<EditoraV3.Models.RegistroControleMercadoria> RegistroControleMercadorias { get; set; }
    }
}