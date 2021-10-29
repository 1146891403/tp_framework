namespace TP.WL.ERP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tpwl_admin_RoleInDepartments",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        DepartmentId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.DepartmentId })
                .ForeignKey("dbo.tpwl_admin_Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.tpwl_admin_Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tpwl_admin_RoleInDepartments", "RoleId", "dbo.tpwl_admin_Roles");
            DropForeignKey("dbo.tpwl_admin_RoleInDepartments", "DepartmentId", "dbo.tpwl_admin_Departments");
            DropIndex("dbo.tpwl_admin_RoleInDepartments", new[] { "DepartmentId" });
            DropIndex("dbo.tpwl_admin_RoleInDepartments", new[] { "RoleId" });
            DropTable("dbo.tpwl_admin_RoleInDepartments");
        }
    }
}
