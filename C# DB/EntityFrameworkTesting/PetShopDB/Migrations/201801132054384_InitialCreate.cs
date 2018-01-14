namespace PetShopDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cages",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Notes = c.String(nullable: false, maxLength: 128),
                        IsEmpty = c.Boolean(nullable: false),
                        Matter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Name, t.Notes });
            
            CreateTable(
                "dbo.Cats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockName = c.String(),
                        Breed = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockName = c.String(),
                        Breed = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Cat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cats", t => t.Cat_Id)
                .Index(t => t.Cat_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Cat_Id", "dbo.Cats");
            DropIndex("dbo.People", new[] { "Cat_Id" });
            DropTable("dbo.People");
            DropTable("dbo.Dogs");
            DropTable("dbo.Cats");
            DropTable("dbo.Cages");
        }
    }
}
