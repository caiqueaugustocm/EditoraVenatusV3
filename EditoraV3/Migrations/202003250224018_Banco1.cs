namespace EditoraV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Banco1 : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
        }
    }
}

/*
public override void Up()
{
    CreateTable(
        "dbo.Autors",
        c => new
        {
            ID_Autor = c.Int(nullable: false, identity: true),
            CPF = c.String(nullable: false, maxLength: 15),
            Nome = c.String(nullable: false, maxLength: 100),
            Id_livros = c.Int(nullable: false),
            Endereco_ID_Endereco = c.Int(),
            Login_ID_Login = c.Int(),
            RedeSocial_ID_RedeSocial = c.Int(),
            Telefone_ID_Telefone = c.Int(),
        })
        .PrimaryKey(t => t.ID_Autor)
        .ForeignKey("dbo.Enderecoes", t => t.Endereco_ID_Endereco)
        .ForeignKey("dbo.Logins", t => t.Login_ID_Login)
        .ForeignKey("dbo.RedeSocials", t => t.RedeSocial_ID_RedeSocial)
        .ForeignKey("dbo.Telefones", t => t.Telefone_ID_Telefone)
        .Index(t => t.Endereco_ID_Endereco)
        .Index(t => t.Login_ID_Login)
        .Index(t => t.RedeSocial_ID_RedeSocial)
        .Index(t => t.Telefone_ID_Telefone);

    CreateTable(
        "dbo.Livroes",
        c => new
        {
            ID_Livro = c.Int(nullable: false, identity: true),
            Titulo = c.String(nullable: false, maxLength: 100),
            Numero_Paginas = c.Int(nullable: false),
            Categoria = c.String(nullable: false, maxLength: 20),
            Descricao = c.String(nullable: false, maxLength: 50),
            ISBN = c.String(nullable: false, maxLength: 20),
            Ilustrador = c.String(nullable: false, maxLength: 50),
            Imagem_URL = c.String(),
            Botao_URL = c.String(),
            Datapublicacao = c.DateTime(nullable: false),
            Preco = c.Single(nullable: false),
            Idioma = c.String(nullable: false, maxLength: 20),
            Formato = c.String(nullable: false, maxLength: 20),
            SubTitulo = c.String(nullable: false, maxLength: 50),
            Sinopse = c.String(nullable: false),
            Id_autor = c.Int(nullable: false),
            Classificacao_Indicativa = c.String(nullable: false, maxLength: 10),
            Classificao_ID_Classificacao = c.Int(),
            Cupom_ID_Cupom = c.Int(),
            Estoque_ID_Estoque = c.Int(),
            RegistroControleMercadoria_ID_RegConMerc = c.Int(),
        })
        .PrimaryKey(t => t.ID_Livro)
        .ForeignKey("dbo.Classificaos", t => t.Classificao_ID_Classificacao)
        .ForeignKey("dbo.Cupoms", t => t.Cupom_ID_Cupom)
        .ForeignKey("dbo.Estoques", t => t.Estoque_ID_Estoque)
        .ForeignKey("dbo.RegistroControleMercadorias", t => t.RegistroControleMercadoria_ID_RegConMerc)
        .Index(t => t.Classificao_ID_Classificacao)
        .Index(t => t.Cupom_ID_Cupom)
        .Index(t => t.Estoque_ID_Estoque)
        .Index(t => t.RegistroControleMercadoria_ID_RegConMerc);

    CreateTable(
        "dbo.Classificaos",
        c => new
        {
            ID_Classificacao = c.Int(nullable: false, identity: true),
            Nota = c.Int(nullable: false),
            Comentario = c.String(nullable: false, maxLength: 50),
            id_cliente = c.Int(nullable: false),
            id_livros = c.Int(nullable: false),
        })
        .PrimaryKey(t => t.ID_Classificacao);

    CreateTable(
        "dbo.Clientes",
        c => new
        {
            ID_Cliente = c.Int(nullable: false, identity: true),
            Classificao_ID_Classificacao = c.Int(),
            Pessoa_ID_Pessoa = c.Int(),
            Endereco_ID_Endereco = c.Int(),
            Escola_ID_Escola = c.Int(),
            Livraria_ID_Livraria = c.Int(),
            Login_ID_Login = c.Int(),
            RedeSocial_ID_RedeSocial = c.Int(),
            Telefone_ID_Telefone = c.Int(),
        })
        .PrimaryKey(t => t.ID_Cliente)
        .ForeignKey("dbo.Classificaos", t => t.Classificao_ID_Classificacao)
        .ForeignKey("dbo.Pessoas", t => t.Pessoa_ID_Pessoa)
        .ForeignKey("dbo.Enderecoes", t => t.Endereco_ID_Endereco)
        .ForeignKey("dbo.Escolas", t => t.Escola_ID_Escola)
        .ForeignKey("dbo.Livrarias", t => t.Livraria_ID_Livraria)
        .ForeignKey("dbo.Logins", t => t.Login_ID_Login)
        .ForeignKey("dbo.RedeSocials", t => t.RedeSocial_ID_RedeSocial)
        .ForeignKey("dbo.Telefones", t => t.Telefone_ID_Telefone)
        .Index(t => t.Classificao_ID_Classificacao)
        .Index(t => t.Pessoa_ID_Pessoa)
        .Index(t => t.Endereco_ID_Endereco)
        .Index(t => t.Escola_ID_Escola)
        .Index(t => t.Livraria_ID_Livraria)
        .Index(t => t.Login_ID_Login)
        .Index(t => t.RedeSocial_ID_RedeSocial)
        .Index(t => t.Telefone_ID_Telefone);

    CreateTable(
        "dbo.Compras",
        c => new
        {
            ID_Compra = c.Int(nullable: false, identity: true),
            NomeCli = c.String(nullable: false),
            Total_Pag = c.Single(nullable: false),
            DataPag = c.DateTime(nullable: false),
        })
        .PrimaryKey(t => t.ID_Compra);

    CreateTable(
        "dbo.Cupoms",
        c => new
        {
            ID_Cupom = c.Int(nullable: false, identity: true),
            Desconto = c.Single(nullable: false),
            Botao_URL = c.String(),
            Nome = c.String(nullable: false, maxLength: 50),
            Data_Ini = c.DateTime(nullable: false),
            Data_Fim = c.DateTime(nullable: false),
            Id_livro = c.Int(nullable: false),
            Id_pessoa = c.Int(nullable: false),
        })
        .PrimaryKey(t => t.ID_Cupom);

    CreateTable(
        "dbo.Pessoas",
        c => new
        {
            ID_Pessoa = c.Int(nullable: false, identity: true),
            CPF = c.String(nullable: false, maxLength: 15),
            Nome = c.String(nullable: false, maxLength: 50),
            Sobrenome = c.String(nullable: false, maxLength: 50),
            Desconto = c.Boolean(nullable: false),
            Tipo_pessoa = c.String(nullable: false, maxLength: 20),
            sexo = c.String(nullable: false, maxLength: 1),
            Data_Nascimento = c.DateTime(nullable: false),
            Id_cup = c.Int(nullable: false),
            Id_cli = c.Int(nullable: false),
        })
        .PrimaryKey(t => t.ID_Pessoa);

    CreateTable(
        "dbo.Enderecoes",
        c => new
        {
            ID_Endereco = c.Int(nullable: false, identity: true),
            Nome_Proprietario = c.String(),
            CEP = c.String(nullable: false, maxLength: 10),
            Logradouro = c.String(nullable: false),
            Numero = c.String(nullable: false, maxLength: 10),
            Estado = c.String(nullable: false, maxLength: 30),
            Cidade = c.String(nullable: false, maxLength: 30),
            Bairro = c.String(nullable: false, maxLength: 30),
            Complemento = c.String(nullable: false, maxLength: 50),
            autor = c.Int(nullable: false),
            cliente = c.Int(nullable: false),
        })
        .PrimaryKey(t => t.ID_Endereco);

    CreateTable(
        "dbo.Escolas",
        c => new
        {
            ID_Escola = c.Int(nullable: false, identity: true),
            CNPJ = c.String(nullable: false),
            Nome_Instituicao = c.String(nullable: false, maxLength: 50),
            Responsavel = c.String(nullable: false, maxLength: 20),
            Livro_Adotado = c.String(nullable: false, maxLength: 100),
            Serie_Adotada = c.String(nullable: false, maxLength: 50),
            data_Adotada = c.DateTime(nullable: false),
            id_cliente = c.Int(nullable: false),
            Evento_ID_Evento = c.Int(),
        })
        .PrimaryKey(t => t.ID_Escola)
        .ForeignKey("dbo.Eventoes", t => t.Evento_ID_Evento)
        .Index(t => t.Evento_ID_Evento);

    CreateTable(
        "dbo.Estoques",
        c => new
        {
            ID_Estoque = c.Int(nullable: false, identity: true),
            Quantidade = c.Int(nullable: false),
            Livro = c.Int(nullable: false),
        })
        .PrimaryKey(t => t.ID_Estoque);

    CreateTable(
        "dbo.Eventoes",
        c => new
        {
            ID_Evento = c.Int(nullable: false, identity: true),
            Imagem_URL = c.String(nullable: false),
            Link = c.String(nullable: false),
            Titulo = c.String(nullable: false),
            Descrição = c.String(nullable: false),
            Data_Evento = c.DateTime(nullable: false),
            Escola = c.Int(nullable: false),
            Livraria = c.Int(nullable: false),
        })
        .PrimaryKey(t => t.ID_Evento);

    CreateTable(
        "dbo.Livrarias",
        c => new
        {
            ID_Livraria = c.Int(nullable: false, identity: true),
            Cliente = c.Int(nullable: false),
            CNPJ = c.String(nullable: false, maxLength: 15),
            Tipo_Consignacao = c.String(nullable: false, maxLength: 50),
            Nome = c.String(nullable: false, maxLength: 50),
            Evento_ID_Evento = c.Int(),
        })
        .PrimaryKey(t => t.ID_Livraria)
        .ForeignKey("dbo.Eventoes", t => t.Evento_ID_Evento)
        .Index(t => t.Evento_ID_Evento);

    CreateTable(
        "dbo.Logins",
        c => new
        {
            ID_Login = c.Int(nullable: false, identity: true),
            autor = c.Int(nullable: false),
            cliente = c.Int(nullable: false),
            Usuario = c.String(nullable: false, maxLength: 20),
            Senha = c.String(nullable: false, maxLength: 24),
        })
        .PrimaryKey(t => t.ID_Login);

    CreateTable(
        "dbo.RedeSocials",
        c => new
        {
            ID_RedeSocial = c.Int(nullable: false, identity: true),
            Email = c.String(),
            Instagram = c.String(),
            Twitter = c.String(),
            Facebook = c.String(),
            Id_aut = c.Int(nullable: false),
            Id_cli = c.Int(nullable: false),
        })
        .PrimaryKey(t => t.ID_RedeSocial);

    CreateTable(
        "dbo.RegistroControleMercadorias",
        c => new
        {
            ID_RegConMerc = c.Int(nullable: false, identity: true),
            Livro = c.Int(nullable: false),
            Quantidade = c.Int(nullable: false),
            Tipo = c.Int(nullable: false),
            DataReg = c.DateTime(nullable: false),
        })
        .PrimaryKey(t => t.ID_RegConMerc);

    CreateTable(
        "dbo.Telefones",
        c => new
        {
            ID_Telefone = c.Int(nullable: false, identity: true),
            Tipo_Telefone = c.String(nullable: false, maxLength: 15),
            Numero = c.String(nullable: false, maxLength: 20),
            Id_a = c.Int(nullable: false),
            Id_c = c.Int(nullable: false),
        })
        .PrimaryKey(t => t.ID_Telefone);

    CreateTable(
        "dbo.Tipoes",
        c => new
        {
            ID_Tipo = c.Int(nullable: false, identity: true),
            Descricao = c.String(nullable: false, maxLength: 50),
        })
        .PrimaryKey(t => t.ID_Tipo);

    CreateTable(
        "dbo.AutorLivroes",
        c => new
        {
            Autor_ID_Autor = c.Int(nullable: false),
            Livro_ID_Livro = c.Int(nullable: false),
        })
        .PrimaryKey(t => new { t.Autor_ID_Autor, t.Livro_ID_Livro })
        .ForeignKey("dbo.Autors", t => t.Autor_ID_Autor, cascadeDelete: true)
        .ForeignKey("dbo.Livroes", t => t.Livro_ID_Livro, cascadeDelete: true)
        .Index(t => t.Autor_ID_Autor)
        .Index(t => t.Livro_ID_Livro);

    CreateTable(
        "dbo.CupomPessoas",
        c => new
        {
            Cupom_ID_Cupom = c.Int(nullable: false),
            Pessoa_ID_Pessoa = c.Int(nullable: false),
        })
        .PrimaryKey(t => new { t.Cupom_ID_Cupom, t.Pessoa_ID_Pessoa })
        .ForeignKey("dbo.Cupoms", t => t.Cupom_ID_Cupom, cascadeDelete: true)
        .ForeignKey("dbo.Pessoas", t => t.Pessoa_ID_Pessoa, cascadeDelete: true)
        .Index(t => t.Cupom_ID_Cupom)
        .Index(t => t.Pessoa_ID_Pessoa);

}

public override void Down()
{
    DropForeignKey("dbo.Clientes", "Telefone_ID_Telefone", "dbo.Telefones");
    DropForeignKey("dbo.Autors", "Telefone_ID_Telefone", "dbo.Telefones");
    DropForeignKey("dbo.Livroes", "RegistroControleMercadoria_ID_RegConMerc", "dbo.RegistroControleMercadorias");
    DropForeignKey("dbo.Clientes", "RedeSocial_ID_RedeSocial", "dbo.RedeSocials");
    DropForeignKey("dbo.Autors", "RedeSocial_ID_RedeSocial", "dbo.RedeSocials");
    DropForeignKey("dbo.Clientes", "Login_ID_Login", "dbo.Logins");
    DropForeignKey("dbo.Autors", "Login_ID_Login", "dbo.Logins");
    DropForeignKey("dbo.Livrarias", "Evento_ID_Evento", "dbo.Eventoes");
    DropForeignKey("dbo.Clientes", "Livraria_ID_Livraria", "dbo.Livrarias");
    DropForeignKey("dbo.Escolas", "Evento_ID_Evento", "dbo.Eventoes");
    DropForeignKey("dbo.Livroes", "Estoque_ID_Estoque", "dbo.Estoques");
    DropForeignKey("dbo.Clientes", "Escola_ID_Escola", "dbo.Escolas");
    DropForeignKey("dbo.Clientes", "Endereco_ID_Endereco", "dbo.Enderecoes");
    DropForeignKey("dbo.Autors", "Endereco_ID_Endereco", "dbo.Enderecoes");
    DropForeignKey("dbo.CupomPessoas", "Pessoa_ID_Pessoa", "dbo.Pessoas");
    DropForeignKey("dbo.CupomPessoas", "Cupom_ID_Cupom", "dbo.Cupoms");
    DropForeignKey("dbo.Clientes", "Pessoa_ID_Pessoa", "dbo.Pessoas");
    DropForeignKey("dbo.Livroes", "Cupom_ID_Cupom", "dbo.Cupoms");
    DropForeignKey("dbo.Livroes", "Classificao_ID_Classificacao", "dbo.Classificaos");
    DropForeignKey("dbo.Clientes", "Classificao_ID_Classificacao", "dbo.Classificaos");
    DropForeignKey("dbo.AutorLivroes", "Livro_ID_Livro", "dbo.Livroes");
    DropForeignKey("dbo.AutorLivroes", "Autor_ID_Autor", "dbo.Autors");
    DropIndex("dbo.CupomPessoas", new[] { "Pessoa_ID_Pessoa" });
    DropIndex("dbo.CupomPessoas", new[] { "Cupom_ID_Cupom" });
    DropIndex("dbo.AutorLivroes", new[] { "Livro_ID_Livro" });
    DropIndex("dbo.AutorLivroes", new[] { "Autor_ID_Autor" });
    DropIndex("dbo.Livrarias", new[] { "Evento_ID_Evento" });
    DropIndex("dbo.Escolas", new[] { "Evento_ID_Evento" });
    DropIndex("dbo.Clientes", new[] { "Telefone_ID_Telefone" });
    DropIndex("dbo.Clientes", new[] { "RedeSocial_ID_RedeSocial" });
    DropIndex("dbo.Clientes", new[] { "Login_ID_Login" });
    DropIndex("dbo.Clientes", new[] { "Livraria_ID_Livraria" });
    DropIndex("dbo.Clientes", new[] { "Escola_ID_Escola" });
    DropIndex("dbo.Clientes", new[] { "Endereco_ID_Endereco" });
    DropIndex("dbo.Clientes", new[] { "Pessoa_ID_Pessoa" });
    DropIndex("dbo.Clientes", new[] { "Classificao_ID_Classificacao" });
    DropIndex("dbo.Livroes", new[] { "RegistroControleMercadoria_ID_RegConMerc" });
    DropIndex("dbo.Livroes", new[] { "Estoque_ID_Estoque" });
    DropIndex("dbo.Livroes", new[] { "Cupom_ID_Cupom" });
    DropIndex("dbo.Livroes", new[] { "Classificao_ID_Classificacao" });
    DropIndex("dbo.Autors", new[] { "Telefone_ID_Telefone" });
    DropIndex("dbo.Autors", new[] { "RedeSocial_ID_RedeSocial" });
    DropIndex("dbo.Autors", new[] { "Login_ID_Login" });
    DropIndex("dbo.Autors", new[] { "Endereco_ID_Endereco" });
    DropTable("dbo.CupomPessoas");
    DropTable("dbo.AutorLivroes");
    DropTable("dbo.Tipoes");
    DropTable("dbo.Telefones");
    DropTable("dbo.RegistroControleMercadorias");
    DropTable("dbo.RedeSocials");
    DropTable("dbo.Logins");
    DropTable("dbo.Livrarias");
    DropTable("dbo.Eventoes");
    DropTable("dbo.Estoques");
    DropTable("dbo.Escolas");
    DropTable("dbo.Enderecoes");
    DropTable("dbo.Pessoas");
    DropTable("dbo.Cupoms");
    DropTable("dbo.Compras");
    DropTable("dbo.Clientes");
    DropTable("dbo.Classificaos");
    DropTable("dbo.Livroes");
    DropTable("dbo.Autors");
}
*/
