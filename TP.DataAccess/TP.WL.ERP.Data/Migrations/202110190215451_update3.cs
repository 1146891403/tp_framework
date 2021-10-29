namespace TP.WL.ERP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.tpml_ship_carton");
            AlterColumn("dbo.tpml_ship_carton", "Id", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.tpml_ship_carton", "Id");
            DropColumn("dbo.tpml_ship_carton", "CartonId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tpml_ship_carton", "CartonId", c => c.Long(nullable: false, identity: true));
            DropPrimaryKey("dbo.tpml_ship_carton");
            AlterColumn("dbo.tpml_ship_carton", "Id", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.tpml_ship_carton", "CartonId");
        }
    }
}
