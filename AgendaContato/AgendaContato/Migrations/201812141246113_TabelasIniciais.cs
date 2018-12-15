namespace AgendaContato.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelasIniciais : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmailContato = c.String(),
                        NomeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nomes", t => t.NomeId, cascadeDelete: true)
                .Index(t => t.NomeId);
            
            CreateTable(
                "dbo.Nomes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeContato = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Telefones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.String(),
                        NomeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nomes", t => t.NomeId, cascadeDelete: true)
                .Index(t => t.NomeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telefones", "NomeId", "dbo.Nomes");
            DropForeignKey("dbo.Emails", "NomeId", "dbo.Nomes");
            DropIndex("dbo.Telefones", new[] { "NomeId" });
            DropIndex("dbo.Emails", new[] { "NomeId" });
            DropTable("dbo.Telefones");
            DropTable("dbo.Nomes");
            DropTable("dbo.Emails");
        }
    }
}
