namespace SistemaAcademia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Pessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        Telefone = c.String(),
                        Turno = c.String(),
                        Pagou = c.String(),
                        Turno1 = c.String(),
                        SalarioHora = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Modalidade_IdModalidade = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Modalidade", t => t.Modalidade_IdModalidade)
                .Index(t => t.Modalidade_IdModalidade);
            
            CreateTable(
                "public.Modalidade",
                c => new
                    {
                        IdModalidade = c.Int(nullable: false, identity: true),
                        VezesSemana = c.Int(nullable: false),
                        PrecoHora = c.Double(nullable: false),
                        Nome = c.String(),
                        Professor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdModalidade)
                .ForeignKey("public.Pessoa", t => t.Professor_Id)
                .Index(t => t.Professor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Pessoa", "Modalidade_IdModalidade", "public.Modalidade");
            DropForeignKey("public.Modalidade", "Professor_Id", "public.Pessoa");
            DropIndex("public.Modalidade", new[] { "Professor_Id" });
            DropIndex("public.Pessoa", new[] { "Modalidade_IdModalidade" });
            DropTable("public.Modalidade");
            DropTable("public.Pessoa");
        }
    }
}
