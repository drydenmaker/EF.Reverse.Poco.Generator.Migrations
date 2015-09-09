namespace aPocoModel.Generated
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.logger_entries",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        logger_operation_id = c.Int(nullable: false),
                        event_id = c.Int(),
                        priority = c.Int(),
                        severity = c.String(maxLength: 50),
                        title = c.String(maxLength: 250),
                        message = c.String(nullable: false, unicode: false, storeType: "text"),
                        timestamp = c.DateTime(nullable: false),
                        machine_name = c.String(maxLength: 250),
                        process_id = c.String(maxLength: 255),
                        process_name = c.String(maxLength: 512),
                        thread_name = c.String(maxLength: 512),
                        win32_thread = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.logger_operations", t => t.logger_operation_id, cascadeDelete: true)
                .Index(t => t.logger_operation_id);
            
            CreateTable(
                "dbo.logger_operations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(maxLength: 150),
                        logger_thread_id = c.Int(),
                        description = c.String(maxLength: 500),
                        created = c.DateTime(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.logger_threads", t => t.logger_thread_id)
                .Index(t => t.logger_thread_id);
            
            CreateTable(
                "dbo.logger_threads",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(maxLength: 250),
                        log_status_id = c.Int(),
                        parent_id = c.Int(),
                        guid = c.String(nullable: false, maxLength: 120),
                        created = c.DateTime(),
                        updated = c.DateTime(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.logger_thread_statuses", t => t.log_status_id)
                .Index(t => t.log_status_id);
            
            CreateTable(
                "dbo.logger_thread_statuses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(maxLength: 150),
                        name = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.logger_entries", "logger_operation_id", "dbo.logger_operations");
            DropForeignKey("dbo.logger_operations", "logger_thread_id", "dbo.logger_threads");
            DropForeignKey("dbo.logger_threads", "log_status_id", "dbo.logger_thread_statuses");
            DropIndex("dbo.logger_threads", new[] { "log_status_id" });
            DropIndex("dbo.logger_operations", new[] { "logger_thread_id" });
            DropIndex("dbo.logger_entries", new[] { "logger_operation_id" });
            DropTable("dbo.logger_thread_statuses");
            DropTable("dbo.logger_threads");
            DropTable("dbo.logger_operations");
            DropTable("dbo.logger_entries");
        }
    }
}
