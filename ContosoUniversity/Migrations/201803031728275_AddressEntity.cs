namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddressEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        PersonID = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.Person", t => t.PersonID)
                .Index(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Address", "PersonID", "dbo.Person");
            DropIndex("dbo.Address", new[] { "PersonID" });
            DropTable("dbo.Address");
        }
    }
}
