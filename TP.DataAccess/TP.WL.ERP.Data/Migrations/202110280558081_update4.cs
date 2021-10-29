namespace TP.WL.ERP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tpwl_ship_packing",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CartonId = c.Long(nullable: false),
                        PackingAsk = c.String(maxLength: 100),
                        Contents = c.String(maxLength: 500),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .ForeignKey("dbo.tpml_ship_carton", t => t.CartonId, cascadeDelete: true)
                .Index(t => t.CartonId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tpwl_ship_packing", "CartonId", "dbo.tpml_ship_carton");
            DropForeignKey("dbo.tpwl_ship_packing", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_ship_packing", "CreatorId", "dbo.tpwl_admin_Users");
            DropIndex("dbo.tpwl_ship_packing", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_ship_packing", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_ship_packing", new[] { "CartonId" });
            DropTable("dbo.tpwl_ship_packing");
        }
    }
}
