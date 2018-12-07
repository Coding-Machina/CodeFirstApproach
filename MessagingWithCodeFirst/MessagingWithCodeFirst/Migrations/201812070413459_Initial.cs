namespace MessagingWithCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ThreadUsersMap",
                c => new
                    {
                        ThreadUsersMapId = c.Int(nullable: false, identity: true),
                        ThreadId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ThreadUsersMapId)
                .ForeignKey("dbo.Thread", t => t.ThreadId, cascadeDelete: true)
                .ForeignKey("dbo.UsersGroups", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ThreadId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Thread",
                c => new
                    {
                        ThreadId = c.Int(nullable: false, identity: true),
                        CreatedDate = c.String(),
                    })
                .PrimaryKey(t => t.ThreadId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessagesId = c.Int(nullable: false, identity: true),
                        MeassageContent = c.String(),
                        ThreadId = c.Int(nullable: false),
                        CreatorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MessagesId)
                .ForeignKey("dbo.UsersGroups", t => t.CreatorId, cascadeDelete: true)
                .ForeignKey("dbo.Thread", t => t.ThreadId, cascadeDelete: true)
                .Index(t => t.ThreadId)
                .Index(t => t.CreatorId);
            
            CreateTable(
                "dbo.UsersGroups",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ThreadUsersMap", "UserId", "dbo.UsersGroups");
            DropForeignKey("dbo.ThreadUsersMap", "ThreadId", "dbo.Thread");
            DropForeignKey("dbo.Messages", "ThreadId", "dbo.Thread");
            DropForeignKey("dbo.Messages", "CreatorId", "dbo.UsersGroups");
            DropIndex("dbo.Messages", new[] { "CreatorId" });
            DropIndex("dbo.Messages", new[] { "ThreadId" });
            DropIndex("dbo.ThreadUsersMap", new[] { "UserId" });
            DropIndex("dbo.ThreadUsersMap", new[] { "ThreadId" });
            DropTable("dbo.UsersGroups");
            DropTable("dbo.Messages");
            DropTable("dbo.Thread");
            DropTable("dbo.ThreadUsersMap");
        }
    }
}
