namespace PeopleProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelBuilderAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PeopleInformation", "Name", c => c.String(maxLength: 40));
            AlterColumn("dbo.PeopleInformation", "Account_AccountNumber", c => c.String(maxLength: 6));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PeopleInformation", "Account_AccountNumber", c => c.String());
            AlterColumn("dbo.PeopleInformation", "Name", c => c.String());
        }
    }
}
