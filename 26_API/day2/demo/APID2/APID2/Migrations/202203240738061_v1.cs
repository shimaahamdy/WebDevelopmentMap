namespace APID2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        location = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.students",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        age = c.Int(nullable: false),
                        address = c.String(),
                        deptid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Departments", t => t.deptid, cascadeDelete: true)
                .Index(t => t.deptid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.students", "deptid", "dbo.Departments");
            DropIndex("dbo.students", new[] { "deptid" });
            DropTable("dbo.students");
            DropTable("dbo.Departments");
        }
    }
}
