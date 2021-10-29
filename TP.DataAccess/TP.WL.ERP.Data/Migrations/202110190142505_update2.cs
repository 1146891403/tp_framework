namespace TP.WL.ERP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tpml_ship_carton",
                c => new
                    {
                        CartonId = c.Long(nullable: false, identity: true),
                        JobNumber = c.String(nullable: false, maxLength: 200),
                        DescriptiveName = c.String(maxLength: 200),
                        Edition = c.String(maxLength: 50),
                        CopyRight = c.String(maxLength: 150),
                        Delivery_Date = c.DateTime(nullable: false),
                        Consignee = c.String(maxLength: 200),
                        Notify = c.String(maxLength: 200),
                        Notify1 = c.String(maxLength: 200),
                        WaehouseAddr = c.String(maxLength: 200),
                        Country = c.String(maxLength: 200),
                        Terms = c.String(maxLength: 50),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.CartonId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tpml_ship_carton", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpml_ship_carton", "CreatorId", "dbo.tpwl_admin_Users");
            DropIndex("dbo.tpml_ship_carton", new[] { "ModificatorId" });
            DropIndex("dbo.tpml_ship_carton", new[] { "CreatorId" });
            DropTable("dbo.tpml_ship_carton");
        }
    }
}
