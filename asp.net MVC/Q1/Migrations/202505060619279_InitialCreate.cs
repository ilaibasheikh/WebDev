namespace Q1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Specialty = c.String(),
                    })
                .PrimaryKey(t => t.DoctorID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Diagnosis = c.String(),
                        DoctorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PatientID)
                .ForeignKey("dbo.Doctors", t => t.DoctorID, cascadeDelete: true)
                .Index(t => t.DoctorID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        PasswordHash = c.String(),
                        RoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Roles", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.RoleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleID", "dbo.Roles");
            DropForeignKey("dbo.Patients", "DoctorID", "dbo.Doctors");
            DropIndex("dbo.Users", new[] { "RoleID" });
            DropIndex("dbo.Patients", new[] { "DoctorID" });
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.Patients");
            DropTable("dbo.Doctors");
        }
    }
}
