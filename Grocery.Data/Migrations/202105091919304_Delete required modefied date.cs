namespace Grocery.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deleterequiredmodefieddate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ingredient", "ModifiedUtc", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ingredient", "ModifiedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
