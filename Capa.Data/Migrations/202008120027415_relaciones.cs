namespace Capa.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relaciones : DbMigration
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
                        RolId = c.Int(nullable: false)                        
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RolId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId)
                .Index(t => t.RolId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolesUsuarios", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.RolesUsuarios", "RolId", "dbo.Roles");
            DropIndex("dbo.RolesUsuarios", new[] { "Roles_Id" });
            DropIndex("dbo.RolesUsuarios", new[] { "UsuarioId" });
            DropTable("dbo.RolesUsuarios");
            DropTable("dbo.Roles");
        }
    }
}
