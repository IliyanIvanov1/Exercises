namespace PetShopDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonRequiredFN : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "FirstName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "FirstName", c => c.String());
        }
    }
}
