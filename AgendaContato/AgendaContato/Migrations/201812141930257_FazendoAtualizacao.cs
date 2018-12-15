namespace AgendaContato.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FazendoAtualizacao : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Emails", "EmailContato", c => c.String(nullable: false));
            AlterColumn("dbo.Nomes", "NomeContato", c => c.String(nullable: false));
            AlterColumn("dbo.Telefones", "Numero", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Telefones", "Numero", c => c.String());
            AlterColumn("dbo.Nomes", "NomeContato", c => c.String());
            AlterColumn("dbo.Emails", "EmailContato", c => c.String());
        }
    }
}
