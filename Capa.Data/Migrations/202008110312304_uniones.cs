namespace Capa.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uniones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RolesUsuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UsuarioId = c.Int(nullable: false),
                        RolesId = c.Int(nullable: false),

                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RolesId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId)
                .Index(t => t.RolesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolesUsuarios", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.RolesUsuarios", "RolesId", "dbo.Roles");
            DropIndex("dbo.RolesUsuarios", new[] { "RolesId" });
            DropIndex("dbo.RolesUsuarios", new[] { "UsuarioId" });
            DropTable("dbo.RolesUsuarios");
            DropTable("dbo.Roles");
        }
    }
}
