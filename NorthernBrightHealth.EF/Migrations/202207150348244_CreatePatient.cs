namespace NorthernBrightHealth.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePatient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientID = c.Int(nullable: false, identity: true),
                        FirstName = c.Int(nullable: false),
                        LastName = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(),
                        WeightInPounds = c.Single(nullable: false),
                        HeightInInches = c.Single(nullable: false),
                        Immortal = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PatientID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patients");
        }
    }
}
