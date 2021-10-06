namespace TP.WL.ERP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tpwl_admin_Roles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Description = c.String(maxLength: 512),
                        IsEnabled = c.Boolean(nullable: false),
                        SubsidiaryId = c.Long(nullable: false),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .ForeignKey("dbo.tpwl_admin_Subsidiaries", t => t.SubsidiaryId)
                .Index(t => t.SubsidiaryId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.tpwl_admin_Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        AgentId = c.String(maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.AgentId)
                .Index(t => t.AgentId)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.tpwl_admin_UserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.tpwl_admin_UserInGroups",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        GroupId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.GroupId })
                .ForeignKey("dbo.tpwl_admin_Groups", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.tpwl_admin_Groups",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ParentId = c.Long(),
                        DisplayName = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 1024),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Groups", t => t.ParentId)
                .Index(t => t.ParentId)
                .Index(t => t.CreatorId);
            
            CreateTable(
                "dbo.tpwl_admin_RoleInGroups",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        GroupId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.GroupId })
                .ForeignKey("dbo.tpwl_admin_Groups", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.tpwl_admin_Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.tpwl_admin_UserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.tpwl_admin_Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.tpwl_admin_UserProfiles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(maxLength: 256),
                        StaffNumber = c.String(maxLength: 32),
                        Gender = c.Int(nullable: false),
                        Designation = c.String(maxLength: 256),
                        JoinDate = c.DateTime(nullable: false),
                        Tel = c.String(maxLength: 20),
                        Remark = c.String(maxLength: 1024),
                        SubsidiaryId = c.Long(nullable: false),
                        DepartmentId = c.Long(nullable: false),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Departments", t => t.DepartmentId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .ForeignKey("dbo.tpwl_admin_Subsidiaries", t => t.SubsidiaryId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.SubsidiaryId)
                .Index(t => t.DepartmentId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_admin_Departments",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Number = c.String(nullable: false, maxLength: 32),
                        DisplayName = c.String(nullable: false, maxLength: 256),
                        Category = c.String(nullable: false, maxLength: 128),
                        ListOrder = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyDate = c.DateTime(nullable: false),
                        ParentId = c.Long(),
                        SubsidiaryId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Departments", t => t.ParentId)
                .ForeignKey("dbo.tpwl_admin_Subsidiaries", t => t.SubsidiaryId)
                .Index(t => t.ParentId)
                .Index(t => t.SubsidiaryId);
            
            CreateTable(
                "dbo.tpwl_admin_Subsidiaries",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Number = c.String(nullable: false, maxLength: 32),
                        LegalName = c.String(nullable: false, maxLength: 256),
                        Category = c.String(nullable: false, maxLength: 128),
                        ListOrder = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyDate = c.DateTime(nullable: false),
                        ParentId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Subsidiaries", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.tpwl_admin_UserInRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.tpwl_admin_Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.tpwl_admin_RoleInFunctions",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        FunctionId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.FunctionId })
                .ForeignKey("dbo.tpwl_admin_ViewLinkFunctions", t => t.FunctionId, cascadeDelete: true)
                .ForeignKey("dbo.tpwl_admin_Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.FunctionId);
            
            CreateTable(
                "dbo.tpwl_admin_ViewLinkFunctions",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ViewLinkId = c.Long(nullable: false),
                        Number = c.String(nullable: false, maxLength: 32),
                        DisplayName = c.String(nullable: false, maxLength: 256),
                        ListOrder = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_ViewLinks", t => t.ViewLinkId)
                .Index(t => t.ViewLinkId);
            
            CreateTable(
                "dbo.tpwl_admin_ViewLinks",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ParentId = c.Long(nullable: false),
                        Number = c.String(nullable: false, maxLength: 32),
                        ViewName = c.String(nullable: false, maxLength: 128),
                        DisplayName = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 512),
                        IconSource = c.String(maxLength: 256),
                        ListOrder = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_ViewLinkDirectories", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.tpwl_admin_ViewLinkDirectories",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ParentId = c.Long(),
                        Number = c.String(nullable: false, maxLength: 32),
                        DisplayName = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 512),
                        IconSource = c.String(maxLength: 128),
                        ListOrder = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_ViewLinkDirectories", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.tpwl_admin_RoleInViewLinks",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        ViewLinkId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.ViewLinkId })
                .ForeignKey("dbo.tpwl_admin_Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.tpwl_admin_ViewLinks", t => t.ViewLinkId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.ViewLinkId);
            
            CreateTable(
                "dbo.tpwl_wfs_WorkflowStates",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Number = c.String(nullable: false, maxLength: 50),
                        DisplayName = c.String(maxLength: 256),
                        Type = c.Int(nullable: false),
                        DestinagionId = c.Long(),
                        Comment = c.String(maxLength: 512),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_wfs_WorkflowStates", t => t.DestinagionId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .Index(t => t.DestinagionId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_wfs_WorkflowStateOptions",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Priority = c.Int(nullable: false),
                        Eval = c.String(nullable: false, maxLength: 1024),
                        StateId = c.Long(nullable: false),
                        DestinagionId = c.Long(nullable: false),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_wfs_WorkflowStates", t => t.DestinagionId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .ForeignKey("dbo.tpwl_wfs_WorkflowStates", t => t.StateId)
                .Index(t => t.StateId)
                .Index(t => t.DestinagionId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_wfs_SequentialLevels",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SettingId = c.Long(nullable: false),
                        Level = c.Int(nullable: false),
                        CheckerId = c.String(nullable: false, maxLength: 128),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CheckerId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .ForeignKey("dbo.tpwl_wfs_SequentialWorkflowStateSettings", t => t.SettingId)
                .Index(t => t.SettingId)
                .Index(t => t.CheckerId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_wfs_SequentialWorkflowStateSettings",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        StateId = c.Long(nullable: false),
                        ApplicantId = c.String(nullable: false, maxLength: 128),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ApplicantId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .ForeignKey("dbo.tpwl_wfs_SequentialWorkflowStates", t => t.StateId)
                .Index(t => t.StateId)
                .Index(t => t.ApplicantId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_wfs_WorkflowInstances",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Level = c.Int(nullable: false),
                        WorkflowId = c.Long(nullable: false),
                        ApplicantId = c.String(nullable: false, maxLength: 128),
                        StateId = c.Long(),
                        CheckerId = c.String(maxLength: 128),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ApplicantId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CheckerId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .ForeignKey("dbo.tpwl_wfs_WorkflowStates", t => t.StateId)
                .ForeignKey("dbo.tpwl_wfs_Workflows", t => t.WorkflowId)
                .Index(t => t.WorkflowId)
                .Index(t => t.ApplicantId)
                .Index(t => t.StateId)
                .Index(t => t.CheckerId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_wfs_Workflows",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        DisplayName = c.String(nullable: false, maxLength: 50),
                        ApplicationName = c.String(maxLength: 128),
                        InitialStateId = c.Long(nullable: false),
                        Comment = c.String(maxLength: 512),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_wfs_WorkflowStates", t => t.InitialStateId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .Index(t => t.InitialStateId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_est_EstimateComponentItems",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ComponentId = c.Long(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 4),
                        AttritionRate = c.Decimal(nullable: false, precision: 10, scale: 2),
                        PaperQuantity = c.Decimal(nullable: false, precision: 18, scale: 4),
                        PaperWaste = c.Decimal(nullable: false, precision: 10, scale: 2),
                        PrintTime = c.Decimal(nullable: false, precision: 10, scale: 2),
                        PrintPrice = c.Decimal(nullable: false, precision: 18, scale: 4),
                        GrossRate = c.Decimal(nullable: false, precision: 10, scale: 2),
                        CostPrice = c.Decimal(nullable: false, precision: 18, scale: 4),
                        CostPriceOfVAT = c.Decimal(nullable: false, precision: 18, scale: 4),
                        CostAmount = c.Decimal(nullable: false, precision: 18, scale: 4),
                        AdjustmentPrice = c.Decimal(nullable: false, precision: 18, scale: 4),
                        ClientPrice = c.Decimal(nullable: false, precision: 18, scale: 4),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_est_EstimateComponents", t => t.ComponentId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .Index(t => t.ComponentId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_est_EstimateComponents",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        EstimateId = c.Long(nullable: false),
                        Group = c.String(nullable: false, maxLength: 10),
                        SizeH = c.Decimal(nullable: false, precision: 10, scale: 2),
                        SizeV = c.Decimal(nullable: false, precision: 10, scale: 2),
                        SpellingH = c.Decimal(nullable: false, precision: 10, scale: 2),
                        SpellingV = c.Decimal(nullable: false, precision: 10, scale: 2),
                        MarginTop = c.Decimal(nullable: false, precision: 10, scale: 2),
                        MarginRight = c.Decimal(nullable: false, precision: 10, scale: 2),
                        MarginBottom = c.Decimal(nullable: false, precision: 10, scale: 2),
                        MarginLeft = c.Decimal(nullable: false, precision: 10, scale: 2),
                        Color = c.String(maxLength: 20),
                        OtherColor = c.String(maxLength: 256),
                        IsPunch = c.Boolean(nullable: false),
                        IsGild = c.Boolean(nullable: false),
                        LengthMM = c.Decimal(nullable: false, precision: 10, scale: 2),
                        LengthInch = c.Decimal(nullable: false, precision: 10, scale: 2),
                        HeightMM = c.Decimal(nullable: false, precision: 10, scale: 2),
                        HeightInch = c.Decimal(nullable: false, precision: 10, scale: 2),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_est_EstimateRequests", t => t.EstimateId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .Index(t => t.EstimateId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_est_EstimateRequests",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ClientId = c.Long(nullable: false),
                        ClientName = c.String(nullable: false, maxLength: 256),
                        ClientLevel = c.String(nullable: false, maxLength: 10),
                        Currency = c.Int(nullable: false),
                        SalesmanId = c.String(nullable: false, maxLength: 128),
                        Salesman = c.String(nullable: false, maxLength: 256),
                        Number = c.String(nullable: false, maxLength: 32),
                        Status = c.Int(nullable: false),
                        InstanceId = c.Long(),
                        ApplicantId = c.String(nullable: false, maxLength: 128),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ApplicantId)
                .ForeignKey("dbo.tpwl_crm_Clients", t => t.ClientId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.SalesmanId)
                .ForeignKey("dbo.tpwl_wfs_WorkflowInstances", t => t.InstanceId)
                .Index(t => t.ClientId)
                .Index(t => t.SalesmanId)
                .Index(t => t.InstanceId)
                .Index(t => t.ApplicantId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_crm_Clients",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ShortName = c.String(nullable: false, maxLength: 50),
                        ChineseName = c.String(maxLength: 256),
                        EnglishName = c.String(maxLength: 256),
                        Level = c.String(nullable: false, maxLength: 10),
                        OrderType = c.String(maxLength: 10),
                        Industry = c.String(maxLength: 10),
                        InformationSource = c.String(maxLength: 128),
                        Terms = c.String(maxLength: 128),
                        NationalTax = c.Decimal(nullable: false, precision: 18, scale: 4),
                        BusinessNumber = c.String(maxLength: 50),
                        TaxNumber = c.String(maxLength: 50),
                        BankName = c.String(maxLength: 256),
                        BankNumber = c.String(maxLength: 50),
                        InvoiceAddress1 = c.String(maxLength: 256),
                        InvoiceAddress2 = c.String(maxLength: 256),
                        InvoiceAddress3 = c.String(maxLength: 256),
                        LicenseAddress1 = c.String(maxLength: 256),
                        LicenseAddress2 = c.String(maxLength: 256),
                        LicenseAddress3 = c.String(maxLength: 256),
                        Currency = c.Int(nullable: false),
                        IsVAT = c.Boolean(nullable: false),
                        VAT = c.Decimal(nullable: false, precision: 18, scale: 4),
                        IsMonthlyStatement = c.Boolean(nullable: false),
                        IsSample = c.Boolean(nullable: false),
                        IsLiaisonForm = c.Boolean(nullable: false),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 4),
                        EstimateRate = c.Decimal(nullable: false, precision: 18, scale: 4),
                        CreditLimit = c.Decimal(nullable: false, precision: 18, scale: 4),
                        PaymentArea = c.String(maxLength: 128),
                        IsLockedOut = c.Boolean(nullable: false),
                        LockedOutRemark = c.String(maxLength: 1024),
                        SalesmanId = c.String(maxLength: 128),
                        Salesman = c.String(maxLength: 256),
                        MerchandiserId = c.String(maxLength: 128),
                        MerchandiserName = c.String(maxLength: 256),
                        OriginId = c.Long(),
                        GroupId = c.Long(),
                        GroupCreditLimit = c.Decimal(nullable: false, precision: 18, scale: 4),
                        Number = c.String(nullable: false, maxLength: 32),
                        Status = c.Int(nullable: false),
                        InstanceId = c.Long(),
                        ApplicantId = c.String(nullable: false, maxLength: 128),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ApplicantId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_crm_Clients", t => t.GroupId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.MerchandiserId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .ForeignKey("dbo.tpwl_crm_Clients", t => t.OriginId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.SalesmanId)
                .ForeignKey("dbo.tpwl_wfs_WorkflowInstances", t => t.InstanceId)
                .Index(t => t.SalesmanId)
                .Index(t => t.MerchandiserId)
                .Index(t => t.OriginId)
                .Index(t => t.GroupId)
                .Index(t => t.InstanceId)
                .Index(t => t.ApplicantId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_crm_ClientBrands",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ClientId = c.Long(nullable: false),
                        Number = c.String(nullable: false, maxLength: 32),
                        DisplayName = c.String(nullable: false, maxLength: 256),
                        Registration = c.String(maxLength: 256),
                        RegistrationDate = c.DateTime(nullable: false),
                        RegistrationFileId = c.Long(nullable: false),
                        Authorization = c.String(maxLength: 256),
                        AuthorizationDate = c.DateTime(nullable: false),
                        AuthorizationFileId = c.Long(nullable: false),
                        SignDate = c.DateTime(nullable: false),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_util_FileCabinets", t => t.AuthorizationFileId)
                .ForeignKey("dbo.tpwl_crm_Clients", t => t.ClientId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .ForeignKey("dbo.tpwl_util_FileCabinets", t => t.RegistrationFileId)
                .Index(t => t.ClientId)
                .Index(t => t.RegistrationFileId)
                .Index(t => t.AuthorizationFileId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_util_FileCabinets",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        FileName = c.String(nullable: false, maxLength: 256),
                        ContentType = c.String(nullable: false, maxLength: 128),
                        ContentLength = c.Long(nullable: false),
                        LocalFileName = c.String(nullable: false, maxLength: 1024),
                        Status = c.Int(nullable: false),
                        OwnerId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.OwnerId)
                .Index(t => t.OwnerId);
            
            CreateTable(
                "dbo.tpwl_crm_ClientCertificateGroups",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ClientId = c.Long(nullable: false),
                        Number = c.String(nullable: false, maxLength: 50),
                        DisplayName = c.String(nullable: false, maxLength: 128),
                        Remark = c.String(maxLength: 1024),
                        FileId = c.Long(),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_crm_Clients", t => t.ClientId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_util_FileCabinets", t => t.FileId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .Index(t => t.ClientId)
                .Index(t => t.FileId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_crm_ClientCertificateInGroups",
                c => new
                    {
                        GroupId = c.Long(nullable: false),
                        CertificateId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.GroupId, t.CertificateId })
                .ForeignKey("dbo.tpwl_crm_Certificates", t => t.CertificateId, cascadeDelete: true)
                .ForeignKey("dbo.tpwl_crm_ClientCertificateGroups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.GroupId)
                .Index(t => t.CertificateId);
            
            CreateTable(
                "dbo.tpwl_crm_Certificates",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Number = c.String(nullable: false, maxLength: 32),
                        DisplayName = c.String(nullable: false, maxLength: 256),
                        IsGuarantee = c.Boolean(nullable: false),
                        IsTestReport = c.Boolean(nullable: false),
                        IsGuaranteeOrReport = c.Boolean(nullable: false),
                        LifetimeScope = c.Decimal(nullable: false, precision: 5, scale: 2),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        IsDefault = c.Boolean(nullable: false),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_crm_ClientContacts",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ClientId = c.Long(nullable: false),
                        DisplayName = c.String(nullable: false, maxLength: 256),
                        Designation = c.String(maxLength: 256),
                        Phone = c.String(maxLength: 20),
                        Mobile = c.String(maxLength: 20),
                        Email = c.String(maxLength: 256),
                        Remark = c.String(maxLength: 1024),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_crm_Clients", t => t.ClientId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .Index(t => t.ClientId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_crm_ClientExpresses",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ClientId = c.Long(nullable: false),
                        Number = c.String(nullable: false, maxLength: 32),
                        Category = c.Int(nullable: false),
                        Type = c.String(maxLength: 50),
                        State = c.String(maxLength: 50),
                        PostalCode = c.String(maxLength: 20),
                        AddressLine1 = c.String(maxLength: 256),
                        AddressLine2 = c.String(maxLength: 256),
                        AddressLine3 = c.String(maxLength: 256),
                        Contact = c.String(nullable: false, maxLength: 256),
                        Phone = c.String(maxLength: 20),
                        Fax = c.String(maxLength: 20),
                        IsDefault = c.Boolean(nullable: false),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_crm_Clients", t => t.ClientId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .Index(t => t.ClientId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_crm_ClientOpenFiles",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ClientId = c.Long(nullable: false),
                        Type = c.String(nullable: false, maxLength: 128),
                        EffectiveDate = c.DateTime(nullable: false),
                        UnTakeRemark = c.String(maxLength: 1024),
                        FileId = c.Long(),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_crm_Clients", t => t.ClientId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_util_FileCabinets", t => t.FileId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .Index(t => t.ClientId)
                .Index(t => t.FileId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_crm_ClientProfiles",
                c => new
                    {
                        ClientId = c.Long(nullable: false),
                        Nature = c.String(maxLength: 128),
                        AreaCovered = c.String(maxLength: 50),
                        EmployeeCount = c.String(maxLength: 128),
                        Website = c.String(),
                        Customer = c.String(maxLength: 1024),
                        Supplier = c.String(maxLength: 1024),
                        Product = c.String(maxLength: 1024),
                        SalesAmount = c.Decimal(nullable: false, precision: 18, scale: 4),
                        CapitalCurrency = c.Int(nullable: false),
                        CapitalAmount = c.Decimal(nullable: false, precision: 18, scale: 4),
                        OrderQuantity = c.Int(nullable: false),
                        ISOStatus = c.String(maxLength: 20),
                        ProductionDescription = c.String(maxLength: 1024),
                        PackageDescription = c.String(maxLength: 1024),
                        DeliveryDescription = c.String(maxLength: 1024),
                        Remark = c.String(maxLength: 1024),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.tpwl_crm_Clients", t => t.ClientId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.tpwl_crm_ClientSignFiles",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ClientId = c.Long(nullable: false),
                        Type = c.String(nullable: false, maxLength: 128),
                        SignDate = c.DateTime(nullable: false),
                        FileId = c.Long(nullable: false),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_crm_Clients", t => t.ClientId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_util_FileCabinets", t => t.FileId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .Index(t => t.ClientId)
                .Index(t => t.FileId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_est_EstimateMaterials",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ComponentId = c.Long(nullable: false),
                        MaterialNumber = c.String(nullable: false, maxLength: 32),
                        DisplayName = c.String(nullable: false, maxLength: 256),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 4),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_est_EstimateComponents", t => t.ComponentId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .Index(t => t.ComponentId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_est_EstimateCosts",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ComponentItemId = c.Long(nullable: false),
                        Type = c.String(nullable: false, maxLength: 128),
                        DisplayName = c.String(nullable: false, maxLength: 512),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 4),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 4),
                        Remark = c.String(maxLength: 1024),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_est_EstimateComponentItems", t => t.ComponentItemId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .Index(t => t.ComponentItemId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_admin_LoginActivities",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(nullable: false, maxLength: 256),
                        FullName = c.String(nullable: false, maxLength: 256),
                        Memo = c.String(maxLength: 512),
                        IPAddress = c.String(nullable: false, maxLength: 50),
                        MacAddress = c.String(nullable: false, maxLength: 50),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tpwl_admin_SystemChangesetItems",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ChangesetId = c.Long(nullable: false),
                        EntityName = c.String(nullable: false, maxLength: 100),
                        FieldName = c.String(nullable: false, maxLength: 50),
                        OldValue = c.String(maxLength: 1024),
                        NewValue = c.String(maxLength: 1024),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_SystemChangesets", t => t.ChangesetId)
                .Index(t => t.ChangesetId);
            
            CreateTable(
                "dbo.tpwl_admin_SystemChangesets",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(nullable: false, maxLength: 256),
                        FullName = c.String(nullable: false, maxLength: 256),
                        Memo = c.String(maxLength: 512),
                        IPAddress = c.String(nullable: false, maxLength: 50),
                        MacAddress = c.String(nullable: false, maxLength: 50),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tpwl_util_FileShareInRoles",
                c => new
                    {
                        FileId = c.Long(nullable: false),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FileId, t.RoleId })
                .ForeignKey("dbo.tpwl_util_FileCabinets", t => t.FileId, cascadeDelete: true)
                .ForeignKey("dbo.tpwl_admin_Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.FileId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.tpwl_util_FileShareInUsers",
                c => new
                    {
                        FileId = c.Long(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FileId, t.UserId })
                .ForeignKey("dbo.tpwl_util_FileCabinets", t => t.FileId, cascadeDelete: true)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.FileId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.tpwl_util_Cities",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Number = c.String(nullable: false, maxLength: 32),
                        DisplayName = c.String(nullable: false, maxLength: 128),
                        ZipCode = c.String(nullable: false, maxLength: 32),
                        ProvinceId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_util_Provinces", t => t.ProvinceId)
                .Index(t => t.ProvinceId);
            
            CreateTable(
                "dbo.tpwl_util_Provinces",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Number = c.String(nullable: false, maxLength: 32),
                        DisplayName = c.String(nullable: false, maxLength: 128),
                        CountryId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_util_Countries", t => t.CountryId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.tpwl_util_Countries",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Number = c.String(nullable: false, maxLength: 32),
                        DisplayName = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tpwl_util_ClientTokens",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Name = c.String(nullable: false, maxLength: 128),
                        Secret = c.String(nullable: false, maxLength: 128),
                        IsActive = c.Boolean(nullable: false),
                        RefreshTokenLifeTime = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tpwl_util_DateFormattedNumberInstances",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        TemplateId = c.Long(nullable: false),
                        ApplicationName = c.String(nullable: false, maxLength: 128),
                        Prefix = c.String(nullable: false, maxLength: 32),
                        Seed = c.Int(nullable: false),
                        LastGenerateDate = c.DateTime(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        SubsidiaryId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Subsidiaries", t => t.SubsidiaryId)
                .ForeignKey("dbo.tpwl_util_DateFormattedNumberTemplates", t => t.TemplateId)
                .Index(t => t.TemplateId)
                .Index(t => t.SubsidiaryId);
            
            CreateTable(
                "dbo.tpwl_util_NumberTemplates",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Number = c.String(nullable: false, maxLength: 32),
                        Description = c.String(maxLength: 256),
                        Body = c.String(nullable: false, maxLength: 128),
                        Seed = c.Int(nullable: false),
                        Format = c.Int(nullable: false),
                        Comment = c.String(maxLength: 1024),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tpwl_util_DictionaryDatas",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        TypeId = c.Long(nullable: false),
                        DisplayName = c.String(nullable: false, maxLength: 128),
                        Value = c.String(nullable: false, maxLength: 128),
                        ListOrder = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        Remark = c.String(maxLength: 1024),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .ForeignKey("dbo.tpwl_util_DictionaryTypes", t => t.TypeId)
                .Index(t => t.TypeId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_util_DictionaryTypes",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Number = c.String(nullable: false, maxLength: 32),
                        DisplayName = c.String(nullable: false, maxLength: 128),
                        ListOrder = c.Int(nullable: false),
                        Remark = c.String(maxLength: 1024),
                        ParentId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_util_DictionaryTypes", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.tpwl_util_MailTemplates",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Number = c.String(nullable: false, maxLength: 32),
                        Description = c.String(maxLength: 256),
                        Recipients = c.String(nullable: false, maxLength: 1024),
                        CopyRecipients = c.String(maxLength: 1024),
                        BlindCopyRecipients = c.String(maxLength: 1024),
                        Subject = c.String(nullable: false, maxLength: 512),
                        Body = c.String(nullable: false),
                        IsBodyHtml = c.Boolean(nullable: false),
                        Priority = c.Int(nullable: false),
                        Comment = c.String(maxLength: 1024),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tpwl_util_RefreshTokens",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 128),
                        ClientId = c.Guid(nullable: false),
                        IssuedUtc = c.DateTime(nullable: false),
                        ExpiresUtc = c.DateTime(nullable: false),
                        ProtectedTicket = c.String(nullable: false, maxLength: 1024),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tpwl_crm_ClientWorkflowLogs",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        InstanceId = c.Long(nullable: false),
                        Comment = c.String(maxLength: 1024),
                        OriginId = c.Long(nullable: false),
                        DestinagionId = c.Long(),
                        CheckerId = c.String(nullable: false, maxLength: 128),
                        AgentId = c.String(maxLength: 128),
                        Status = c.Int(nullable: false),
                        IpAddress = c.String(maxLength: 20),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.AgentId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CheckerId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_wfs_WorkflowStates", t => t.DestinagionId)
                .ForeignKey("dbo.tpwl_wfs_WorkflowInstances", t => t.InstanceId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .ForeignKey("dbo.tpwl_wfs_WorkflowStates", t => t.OriginId)
                .Index(t => t.InstanceId)
                .Index(t => t.OriginId)
                .Index(t => t.DestinagionId)
                .Index(t => t.CheckerId)
                .Index(t => t.AgentId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_crm_SalesTargets",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        SalesNumber = c.String(nullable: false, maxLength: 32),
                        SalesName = c.String(nullable: false, maxLength: 256),
                        Year = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 4),
                        Remark = c.String(maxLength: 1024),
                        OwnerId = c.String(nullable: false, maxLength: 128),
                        CreatorId = c.String(nullable: false, maxLength: 128),
                        CreateDate = c.DateTime(nullable: false),
                        ModificatorId = c.String(nullable: false, maxLength: 128),
                        ModifyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CreatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.ModificatorId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.OwnerId)
                .Index(t => t.OwnerId)
                .Index(t => t.CreatorId)
                .Index(t => t.ModificatorId);
            
            CreateTable(
                "dbo.tpwl_wfs_BasicWorkflowStates",
                c => new
                    {
                        WorkflowStateId = c.Long(nullable: false),
                        CheckerId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.WorkflowStateId)
                .ForeignKey("dbo.tpwl_wfs_WorkflowStates", t => t.WorkflowStateId)
                .ForeignKey("dbo.tpwl_admin_Users", t => t.CheckerId)
                .Index(t => t.WorkflowStateId)
                .Index(t => t.CheckerId);
            
            CreateTable(
                "dbo.tpwl_wfs_SequentialWorkflowStates",
                c => new
                    {
                        WorkflowStateId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.WorkflowStateId)
                .ForeignKey("dbo.tpwl_wfs_WorkflowStates", t => t.WorkflowStateId)
                .Index(t => t.WorkflowStateId);
            
            CreateTable(
                "dbo.tpwl_util_DateFormattedNumberTemplates",
                c => new
                    {
                        TemplateId = c.Long(nullable: false),
                        ResetCriterion = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.TemplateId)
                .ForeignKey("dbo.tpwl_util_NumberTemplates", t => t.TemplateId)
                .Index(t => t.TemplateId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tpwl_util_DateFormattedNumberTemplates", "TemplateId", "dbo.tpwl_util_NumberTemplates");
            DropForeignKey("dbo.tpwl_wfs_SequentialWorkflowStates", "WorkflowStateId", "dbo.tpwl_wfs_WorkflowStates");
            DropForeignKey("dbo.tpwl_wfs_BasicWorkflowStates", "CheckerId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_BasicWorkflowStates", "WorkflowStateId", "dbo.tpwl_wfs_WorkflowStates");
            DropForeignKey("dbo.tpwl_crm_SalesTargets", "OwnerId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_SalesTargets", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_SalesTargets", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientWorkflowLogs", "OriginId", "dbo.tpwl_wfs_WorkflowStates");
            DropForeignKey("dbo.tpwl_crm_ClientWorkflowLogs", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientWorkflowLogs", "InstanceId", "dbo.tpwl_wfs_WorkflowInstances");
            DropForeignKey("dbo.tpwl_crm_ClientWorkflowLogs", "DestinagionId", "dbo.tpwl_wfs_WorkflowStates");
            DropForeignKey("dbo.tpwl_crm_ClientWorkflowLogs", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientWorkflowLogs", "CheckerId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientWorkflowLogs", "AgentId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_util_DictionaryDatas", "TypeId", "dbo.tpwl_util_DictionaryTypes");
            DropForeignKey("dbo.tpwl_util_DictionaryTypes", "ParentId", "dbo.tpwl_util_DictionaryTypes");
            DropForeignKey("dbo.tpwl_util_DictionaryDatas", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_util_DateFormattedNumberInstances", "TemplateId", "dbo.tpwl_util_DateFormattedNumberTemplates");
            DropForeignKey("dbo.tpwl_util_DateFormattedNumberInstances", "SubsidiaryId", "dbo.tpwl_admin_Subsidiaries");
            DropForeignKey("dbo.tpwl_util_Cities", "ProvinceId", "dbo.tpwl_util_Provinces");
            DropForeignKey("dbo.tpwl_util_Provinces", "CountryId", "dbo.tpwl_util_Countries");
            DropForeignKey("dbo.tpwl_util_FileShareInUsers", "UserId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_util_FileShareInUsers", "FileId", "dbo.tpwl_util_FileCabinets");
            DropForeignKey("dbo.tpwl_util_FileShareInRoles", "RoleId", "dbo.tpwl_admin_Roles");
            DropForeignKey("dbo.tpwl_util_FileShareInRoles", "FileId", "dbo.tpwl_util_FileCabinets");
            DropForeignKey("dbo.tpwl_admin_SystemChangesetItems", "ChangesetId", "dbo.tpwl_admin_SystemChangesets");
            DropForeignKey("dbo.tpwl_est_EstimateComponentItems", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_est_EstimateComponentItems", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_est_EstimateCosts", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_est_EstimateCosts", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_est_EstimateCosts", "ComponentItemId", "dbo.tpwl_est_EstimateComponentItems");
            DropForeignKey("dbo.tpwl_est_EstimateComponentItems", "ComponentId", "dbo.tpwl_est_EstimateComponents");
            DropForeignKey("dbo.tpwl_est_EstimateComponents", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_est_EstimateMaterials", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_est_EstimateMaterials", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_est_EstimateMaterials", "ComponentId", "dbo.tpwl_est_EstimateComponents");
            DropForeignKey("dbo.tpwl_est_EstimateComponents", "EstimateId", "dbo.tpwl_est_EstimateRequests");
            DropForeignKey("dbo.tpwl_est_EstimateRequests", "InstanceId", "dbo.tpwl_wfs_WorkflowInstances");
            DropForeignKey("dbo.tpwl_est_EstimateRequests", "SalesmanId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_est_EstimateRequests", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_est_EstimateRequests", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_est_EstimateRequests", "ClientId", "dbo.tpwl_crm_Clients");
            DropForeignKey("dbo.tpwl_crm_Clients", "InstanceId", "dbo.tpwl_wfs_WorkflowInstances");
            DropForeignKey("dbo.tpwl_crm_ClientSignFiles", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientSignFiles", "FileId", "dbo.tpwl_util_FileCabinets");
            DropForeignKey("dbo.tpwl_crm_ClientSignFiles", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientSignFiles", "ClientId", "dbo.tpwl_crm_Clients");
            DropForeignKey("dbo.tpwl_crm_Clients", "SalesmanId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientProfiles", "ClientId", "dbo.tpwl_crm_Clients");
            DropForeignKey("dbo.tpwl_crm_Clients", "OriginId", "dbo.tpwl_crm_Clients");
            DropForeignKey("dbo.tpwl_crm_ClientOpenFiles", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientOpenFiles", "FileId", "dbo.tpwl_util_FileCabinets");
            DropForeignKey("dbo.tpwl_crm_ClientOpenFiles", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientOpenFiles", "ClientId", "dbo.tpwl_crm_Clients");
            DropForeignKey("dbo.tpwl_crm_Clients", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_Clients", "MerchandiserId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_Clients", "GroupId", "dbo.tpwl_crm_Clients");
            DropForeignKey("dbo.tpwl_crm_ClientExpresses", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientExpresses", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientExpresses", "ClientId", "dbo.tpwl_crm_Clients");
            DropForeignKey("dbo.tpwl_crm_Clients", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientContacts", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientContacts", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientContacts", "ClientId", "dbo.tpwl_crm_Clients");
            DropForeignKey("dbo.tpwl_crm_ClientCertificateGroups", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientCertificateGroups", "FileId", "dbo.tpwl_util_FileCabinets");
            DropForeignKey("dbo.tpwl_crm_ClientCertificateGroups", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientCertificateGroups", "ClientId", "dbo.tpwl_crm_Clients");
            DropForeignKey("dbo.tpwl_crm_ClientCertificateInGroups", "GroupId", "dbo.tpwl_crm_ClientCertificateGroups");
            DropForeignKey("dbo.tpwl_crm_ClientCertificateInGroups", "CertificateId", "dbo.tpwl_crm_Certificates");
            DropForeignKey("dbo.tpwl_crm_Certificates", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_Certificates", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientBrands", "RegistrationFileId", "dbo.tpwl_util_FileCabinets");
            DropForeignKey("dbo.tpwl_crm_ClientBrands", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientBrands", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_ClientBrands", "ClientId", "dbo.tpwl_crm_Clients");
            DropForeignKey("dbo.tpwl_crm_ClientBrands", "AuthorizationFileId", "dbo.tpwl_util_FileCabinets");
            DropForeignKey("dbo.tpwl_util_FileCabinets", "OwnerId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_crm_Clients", "ApplicantId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_est_EstimateRequests", "ApplicantId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_est_EstimateComponents", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_WorkflowInstances", "WorkflowId", "dbo.tpwl_wfs_Workflows");
            DropForeignKey("dbo.tpwl_wfs_Workflows", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_Workflows", "InitialStateId", "dbo.tpwl_wfs_WorkflowStates");
            DropForeignKey("dbo.tpwl_wfs_Workflows", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_WorkflowInstances", "StateId", "dbo.tpwl_wfs_WorkflowStates");
            DropForeignKey("dbo.tpwl_wfs_WorkflowInstances", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_WorkflowInstances", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_WorkflowInstances", "CheckerId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_WorkflowInstances", "ApplicantId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_SequentialLevels", "SettingId", "dbo.tpwl_wfs_SequentialWorkflowStateSettings");
            DropForeignKey("dbo.tpwl_wfs_SequentialWorkflowStateSettings", "StateId", "dbo.tpwl_wfs_SequentialWorkflowStates");
            DropForeignKey("dbo.tpwl_wfs_SequentialWorkflowStateSettings", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_SequentialWorkflowStateSettings", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_SequentialWorkflowStateSettings", "ApplicantId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_SequentialLevels", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_SequentialLevels", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_SequentialLevels", "CheckerId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_WorkflowStateOptions", "StateId", "dbo.tpwl_wfs_WorkflowStates");
            DropForeignKey("dbo.tpwl_wfs_WorkflowStateOptions", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_WorkflowStateOptions", "DestinagionId", "dbo.tpwl_wfs_WorkflowStates");
            DropForeignKey("dbo.tpwl_wfs_WorkflowStateOptions", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_WorkflowStates", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_wfs_WorkflowStates", "DestinagionId", "dbo.tpwl_wfs_WorkflowStates");
            DropForeignKey("dbo.tpwl_wfs_WorkflowStates", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_admin_Roles", "SubsidiaryId", "dbo.tpwl_admin_Subsidiaries");
            DropForeignKey("dbo.tpwl_admin_Roles", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_admin_RoleInFunctions", "RoleId", "dbo.tpwl_admin_Roles");
            DropForeignKey("dbo.tpwl_admin_ViewLinkFunctions", "ViewLinkId", "dbo.tpwl_admin_ViewLinks");
            DropForeignKey("dbo.tpwl_admin_RoleInViewLinks", "ViewLinkId", "dbo.tpwl_admin_ViewLinks");
            DropForeignKey("dbo.tpwl_admin_RoleInViewLinks", "RoleId", "dbo.tpwl_admin_Roles");
            DropForeignKey("dbo.tpwl_admin_ViewLinks", "ParentId", "dbo.tpwl_admin_ViewLinkDirectories");
            DropForeignKey("dbo.tpwl_admin_ViewLinkDirectories", "ParentId", "dbo.tpwl_admin_ViewLinkDirectories");
            DropForeignKey("dbo.tpwl_admin_RoleInFunctions", "FunctionId", "dbo.tpwl_admin_ViewLinkFunctions");
            DropForeignKey("dbo.tpwl_admin_Roles", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_admin_UserInRoles", "UserId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_admin_UserInRoles", "RoleId", "dbo.tpwl_admin_Roles");
            DropForeignKey("dbo.tpwl_admin_UserProfiles", "UserId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_admin_UserProfiles", "SubsidiaryId", "dbo.tpwl_admin_Subsidiaries");
            DropForeignKey("dbo.tpwl_admin_UserProfiles", "ModificatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_admin_UserProfiles", "DepartmentId", "dbo.tpwl_admin_Departments");
            DropForeignKey("dbo.tpwl_admin_Departments", "SubsidiaryId", "dbo.tpwl_admin_Subsidiaries");
            DropForeignKey("dbo.tpwl_admin_Subsidiaries", "ParentId", "dbo.tpwl_admin_Subsidiaries");
            DropForeignKey("dbo.tpwl_admin_Departments", "ParentId", "dbo.tpwl_admin_Departments");
            DropForeignKey("dbo.tpwl_admin_UserProfiles", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_admin_UserLogins", "UserId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_admin_UserInGroups", "UserId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_admin_UserInGroups", "GroupId", "dbo.tpwl_admin_Groups");
            DropForeignKey("dbo.tpwl_admin_RoleInGroups", "RoleId", "dbo.tpwl_admin_Roles");
            DropForeignKey("dbo.tpwl_admin_RoleInGroups", "GroupId", "dbo.tpwl_admin_Groups");
            DropForeignKey("dbo.tpwl_admin_Groups", "ParentId", "dbo.tpwl_admin_Groups");
            DropForeignKey("dbo.tpwl_admin_Groups", "CreatorId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_admin_UserClaims", "UserId", "dbo.tpwl_admin_Users");
            DropForeignKey("dbo.tpwl_admin_Users", "AgentId", "dbo.tpwl_admin_Users");
            DropIndex("dbo.tpwl_util_DateFormattedNumberTemplates", new[] { "TemplateId" });
            DropIndex("dbo.tpwl_wfs_SequentialWorkflowStates", new[] { "WorkflowStateId" });
            DropIndex("dbo.tpwl_wfs_BasicWorkflowStates", new[] { "CheckerId" });
            DropIndex("dbo.tpwl_wfs_BasicWorkflowStates", new[] { "WorkflowStateId" });
            DropIndex("dbo.tpwl_crm_SalesTargets", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_crm_SalesTargets", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_crm_SalesTargets", new[] { "OwnerId" });
            DropIndex("dbo.tpwl_crm_ClientWorkflowLogs", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_crm_ClientWorkflowLogs", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_crm_ClientWorkflowLogs", new[] { "AgentId" });
            DropIndex("dbo.tpwl_crm_ClientWorkflowLogs", new[] { "CheckerId" });
            DropIndex("dbo.tpwl_crm_ClientWorkflowLogs", new[] { "DestinagionId" });
            DropIndex("dbo.tpwl_crm_ClientWorkflowLogs", new[] { "OriginId" });
            DropIndex("dbo.tpwl_crm_ClientWorkflowLogs", new[] { "InstanceId" });
            DropIndex("dbo.tpwl_util_DictionaryTypes", new[] { "ParentId" });
            DropIndex("dbo.tpwl_util_DictionaryDatas", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_util_DictionaryDatas", new[] { "TypeId" });
            DropIndex("dbo.tpwl_util_DateFormattedNumberInstances", new[] { "SubsidiaryId" });
            DropIndex("dbo.tpwl_util_DateFormattedNumberInstances", new[] { "TemplateId" });
            DropIndex("dbo.tpwl_util_Provinces", new[] { "CountryId" });
            DropIndex("dbo.tpwl_util_Cities", new[] { "ProvinceId" });
            DropIndex("dbo.tpwl_util_FileShareInUsers", new[] { "UserId" });
            DropIndex("dbo.tpwl_util_FileShareInUsers", new[] { "FileId" });
            DropIndex("dbo.tpwl_util_FileShareInRoles", new[] { "RoleId" });
            DropIndex("dbo.tpwl_util_FileShareInRoles", new[] { "FileId" });
            DropIndex("dbo.tpwl_admin_SystemChangesetItems", new[] { "ChangesetId" });
            DropIndex("dbo.tpwl_est_EstimateCosts", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_est_EstimateCosts", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_est_EstimateCosts", new[] { "ComponentItemId" });
            DropIndex("dbo.tpwl_est_EstimateMaterials", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_est_EstimateMaterials", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_est_EstimateMaterials", new[] { "ComponentId" });
            DropIndex("dbo.tpwl_crm_ClientSignFiles", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_crm_ClientSignFiles", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_crm_ClientSignFiles", new[] { "FileId" });
            DropIndex("dbo.tpwl_crm_ClientSignFiles", new[] { "ClientId" });
            DropIndex("dbo.tpwl_crm_ClientProfiles", new[] { "ClientId" });
            DropIndex("dbo.tpwl_crm_ClientOpenFiles", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_crm_ClientOpenFiles", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_crm_ClientOpenFiles", new[] { "FileId" });
            DropIndex("dbo.tpwl_crm_ClientOpenFiles", new[] { "ClientId" });
            DropIndex("dbo.tpwl_crm_ClientExpresses", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_crm_ClientExpresses", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_crm_ClientExpresses", new[] { "ClientId" });
            DropIndex("dbo.tpwl_crm_ClientContacts", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_crm_ClientContacts", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_crm_ClientContacts", new[] { "ClientId" });
            DropIndex("dbo.tpwl_crm_Certificates", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_crm_Certificates", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_crm_ClientCertificateInGroups", new[] { "CertificateId" });
            DropIndex("dbo.tpwl_crm_ClientCertificateInGroups", new[] { "GroupId" });
            DropIndex("dbo.tpwl_crm_ClientCertificateGroups", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_crm_ClientCertificateGroups", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_crm_ClientCertificateGroups", new[] { "FileId" });
            DropIndex("dbo.tpwl_crm_ClientCertificateGroups", new[] { "ClientId" });
            DropIndex("dbo.tpwl_util_FileCabinets", new[] { "OwnerId" });
            DropIndex("dbo.tpwl_crm_ClientBrands", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_crm_ClientBrands", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_crm_ClientBrands", new[] { "AuthorizationFileId" });
            DropIndex("dbo.tpwl_crm_ClientBrands", new[] { "RegistrationFileId" });
            DropIndex("dbo.tpwl_crm_ClientBrands", new[] { "ClientId" });
            DropIndex("dbo.tpwl_crm_Clients", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_crm_Clients", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_crm_Clients", new[] { "ApplicantId" });
            DropIndex("dbo.tpwl_crm_Clients", new[] { "InstanceId" });
            DropIndex("dbo.tpwl_crm_Clients", new[] { "GroupId" });
            DropIndex("dbo.tpwl_crm_Clients", new[] { "OriginId" });
            DropIndex("dbo.tpwl_crm_Clients", new[] { "MerchandiserId" });
            DropIndex("dbo.tpwl_crm_Clients", new[] { "SalesmanId" });
            DropIndex("dbo.tpwl_est_EstimateRequests", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_est_EstimateRequests", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_est_EstimateRequests", new[] { "ApplicantId" });
            DropIndex("dbo.tpwl_est_EstimateRequests", new[] { "InstanceId" });
            DropIndex("dbo.tpwl_est_EstimateRequests", new[] { "SalesmanId" });
            DropIndex("dbo.tpwl_est_EstimateRequests", new[] { "ClientId" });
            DropIndex("dbo.tpwl_est_EstimateComponents", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_est_EstimateComponents", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_est_EstimateComponents", new[] { "EstimateId" });
            DropIndex("dbo.tpwl_est_EstimateComponentItems", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_est_EstimateComponentItems", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_est_EstimateComponentItems", new[] { "ComponentId" });
            DropIndex("dbo.tpwl_wfs_Workflows", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_wfs_Workflows", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_wfs_Workflows", new[] { "InitialStateId" });
            DropIndex("dbo.tpwl_wfs_WorkflowInstances", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_wfs_WorkflowInstances", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_wfs_WorkflowInstances", new[] { "CheckerId" });
            DropIndex("dbo.tpwl_wfs_WorkflowInstances", new[] { "StateId" });
            DropIndex("dbo.tpwl_wfs_WorkflowInstances", new[] { "ApplicantId" });
            DropIndex("dbo.tpwl_wfs_WorkflowInstances", new[] { "WorkflowId" });
            DropIndex("dbo.tpwl_wfs_SequentialWorkflowStateSettings", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_wfs_SequentialWorkflowStateSettings", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_wfs_SequentialWorkflowStateSettings", new[] { "ApplicantId" });
            DropIndex("dbo.tpwl_wfs_SequentialWorkflowStateSettings", new[] { "StateId" });
            DropIndex("dbo.tpwl_wfs_SequentialLevels", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_wfs_SequentialLevels", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_wfs_SequentialLevels", new[] { "CheckerId" });
            DropIndex("dbo.tpwl_wfs_SequentialLevels", new[] { "SettingId" });
            DropIndex("dbo.tpwl_wfs_WorkflowStateOptions", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_wfs_WorkflowStateOptions", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_wfs_WorkflowStateOptions", new[] { "DestinagionId" });
            DropIndex("dbo.tpwl_wfs_WorkflowStateOptions", new[] { "StateId" });
            DropIndex("dbo.tpwl_wfs_WorkflowStates", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_wfs_WorkflowStates", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_wfs_WorkflowStates", new[] { "DestinagionId" });
            DropIndex("dbo.tpwl_admin_RoleInViewLinks", new[] { "ViewLinkId" });
            DropIndex("dbo.tpwl_admin_RoleInViewLinks", new[] { "RoleId" });
            DropIndex("dbo.tpwl_admin_ViewLinkDirectories", new[] { "ParentId" });
            DropIndex("dbo.tpwl_admin_ViewLinks", new[] { "ParentId" });
            DropIndex("dbo.tpwl_admin_ViewLinkFunctions", new[] { "ViewLinkId" });
            DropIndex("dbo.tpwl_admin_RoleInFunctions", new[] { "FunctionId" });
            DropIndex("dbo.tpwl_admin_RoleInFunctions", new[] { "RoleId" });
            DropIndex("dbo.tpwl_admin_UserInRoles", new[] { "RoleId" });
            DropIndex("dbo.tpwl_admin_UserInRoles", new[] { "UserId" });
            DropIndex("dbo.tpwl_admin_Subsidiaries", new[] { "ParentId" });
            DropIndex("dbo.tpwl_admin_Departments", new[] { "SubsidiaryId" });
            DropIndex("dbo.tpwl_admin_Departments", new[] { "ParentId" });
            DropIndex("dbo.tpwl_admin_UserProfiles", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_admin_UserProfiles", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_admin_UserProfiles", new[] { "DepartmentId" });
            DropIndex("dbo.tpwl_admin_UserProfiles", new[] { "SubsidiaryId" });
            DropIndex("dbo.tpwl_admin_UserProfiles", new[] { "UserId" });
            DropIndex("dbo.tpwl_admin_UserLogins", new[] { "UserId" });
            DropIndex("dbo.tpwl_admin_RoleInGroups", new[] { "GroupId" });
            DropIndex("dbo.tpwl_admin_RoleInGroups", new[] { "RoleId" });
            DropIndex("dbo.tpwl_admin_Groups", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_admin_Groups", new[] { "ParentId" });
            DropIndex("dbo.tpwl_admin_UserInGroups", new[] { "GroupId" });
            DropIndex("dbo.tpwl_admin_UserInGroups", new[] { "UserId" });
            DropIndex("dbo.tpwl_admin_UserClaims", new[] { "UserId" });
            DropIndex("dbo.tpwl_admin_Users", "UserNameIndex");
            DropIndex("dbo.tpwl_admin_Users", new[] { "AgentId" });
            DropIndex("dbo.tpwl_admin_Roles", "RoleNameIndex");
            DropIndex("dbo.tpwl_admin_Roles", new[] { "ModificatorId" });
            DropIndex("dbo.tpwl_admin_Roles", new[] { "CreatorId" });
            DropIndex("dbo.tpwl_admin_Roles", new[] { "SubsidiaryId" });
            DropTable("dbo.tpwl_util_DateFormattedNumberTemplates");
            DropTable("dbo.tpwl_wfs_SequentialWorkflowStates");
            DropTable("dbo.tpwl_wfs_BasicWorkflowStates");
            DropTable("dbo.tpwl_crm_SalesTargets");
            DropTable("dbo.tpwl_crm_ClientWorkflowLogs");
            DropTable("dbo.tpwl_util_RefreshTokens");
            DropTable("dbo.tpwl_util_MailTemplates");
            DropTable("dbo.tpwl_util_DictionaryTypes");
            DropTable("dbo.tpwl_util_DictionaryDatas");
            DropTable("dbo.tpwl_util_NumberTemplates");
            DropTable("dbo.tpwl_util_DateFormattedNumberInstances");
            DropTable("dbo.tpwl_util_ClientTokens");
            DropTable("dbo.tpwl_util_Countries");
            DropTable("dbo.tpwl_util_Provinces");
            DropTable("dbo.tpwl_util_Cities");
            DropTable("dbo.tpwl_util_FileShareInUsers");
            DropTable("dbo.tpwl_util_FileShareInRoles");
            DropTable("dbo.tpwl_admin_SystemChangesets");
            DropTable("dbo.tpwl_admin_SystemChangesetItems");
            DropTable("dbo.tpwl_admin_LoginActivities");
            DropTable("dbo.tpwl_est_EstimateCosts");
            DropTable("dbo.tpwl_est_EstimateMaterials");
            DropTable("dbo.tpwl_crm_ClientSignFiles");
            DropTable("dbo.tpwl_crm_ClientProfiles");
            DropTable("dbo.tpwl_crm_ClientOpenFiles");
            DropTable("dbo.tpwl_crm_ClientExpresses");
            DropTable("dbo.tpwl_crm_ClientContacts");
            DropTable("dbo.tpwl_crm_Certificates");
            DropTable("dbo.tpwl_crm_ClientCertificateInGroups");
            DropTable("dbo.tpwl_crm_ClientCertificateGroups");
            DropTable("dbo.tpwl_util_FileCabinets");
            DropTable("dbo.tpwl_crm_ClientBrands");
            DropTable("dbo.tpwl_crm_Clients");
            DropTable("dbo.tpwl_est_EstimateRequests");
            DropTable("dbo.tpwl_est_EstimateComponents");
            DropTable("dbo.tpwl_est_EstimateComponentItems");
            DropTable("dbo.tpwl_wfs_Workflows");
            DropTable("dbo.tpwl_wfs_WorkflowInstances");
            DropTable("dbo.tpwl_wfs_SequentialWorkflowStateSettings");
            DropTable("dbo.tpwl_wfs_SequentialLevels");
            DropTable("dbo.tpwl_wfs_WorkflowStateOptions");
            DropTable("dbo.tpwl_wfs_WorkflowStates");
            DropTable("dbo.tpwl_admin_RoleInViewLinks");
            DropTable("dbo.tpwl_admin_ViewLinkDirectories");
            DropTable("dbo.tpwl_admin_ViewLinks");
            DropTable("dbo.tpwl_admin_ViewLinkFunctions");
            DropTable("dbo.tpwl_admin_RoleInFunctions");
            DropTable("dbo.tpwl_admin_UserInRoles");
            DropTable("dbo.tpwl_admin_Subsidiaries");
            DropTable("dbo.tpwl_admin_Departments");
            DropTable("dbo.tpwl_admin_UserProfiles");
            DropTable("dbo.tpwl_admin_UserLogins");
            DropTable("dbo.tpwl_admin_RoleInGroups");
            DropTable("dbo.tpwl_admin_Groups");
            DropTable("dbo.tpwl_admin_UserInGroups");
            DropTable("dbo.tpwl_admin_UserClaims");
            DropTable("dbo.tpwl_admin_Users");
            DropTable("dbo.tpwl_admin_Roles");
        }
    }
}
