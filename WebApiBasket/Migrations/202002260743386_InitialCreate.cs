namespace WebApiBasket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jugadores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreJugador = c.String(),
                        Pais = c.String(),
                        Valoracion = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Dorsal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jugadores");
        }
    }
}
