namespace PetShopDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonRequiredLN : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "LastName", c => c.String());
        }
    }
}
