namespace SistemaAcademia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Pessoa", "IdModalidade", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("public.Pessoa", "IdModalidade");
        }
    }
}
