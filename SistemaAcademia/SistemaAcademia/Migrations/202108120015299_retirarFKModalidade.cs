namespace SistemaAcademia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class retirarFKModalidade : DbMigration
    {
        public override void Up()
        {
            DropColumn("public.Pessoa", "IdModalidade");
        }
        
        public override void Down()
        {
            AddColumn("public.Pessoa", "IdModalidade", c => c.Int());
        }
    }
}
