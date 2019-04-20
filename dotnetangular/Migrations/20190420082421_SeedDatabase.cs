using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetangular.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('make 1')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('make 2')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('make 3')");

            migrationBuilder.Sql("INSERT INTO Models (Name,MakeID) VALUES ('make 1 - model A',(SELECT ID FROM Makes WHERE Name ='make 1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name,MakeID) VALUES ('make 1 - model B',(SELECT ID FROM Makes WHERE Name ='make 1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name,MakeID) VALUES ('make 1 - model C',(SELECT ID FROM Makes WHERE Name ='make 1'))");

            migrationBuilder.Sql("INSERT INTO Models (Name,MakeID) VALUES ('make 2 - model A',(SELECT ID FROM Makes WHERE Name ='make 2'))");
            migrationBuilder.Sql("INSERT INTO Models (Name,MakeID) VALUES ('make 2 - model B',(SELECT ID FROM Makes WHERE Name ='make 2'))");
            migrationBuilder.Sql("INSERT INTO Models (Name,MakeID) VALUES ('make 2 - model C',(SELECT ID FROM Makes WHERE Name ='make 2'))");

            migrationBuilder.Sql("INSERT INTO Models (Name,MakeID) VALUES ('make 3 - model A',(SELECT ID FROM Makes WHERE Name ='make 3'))");
            migrationBuilder.Sql("INSERT INTO Models (Name,MakeID) VALUES ('make 3 - model B',(SELECT ID FROM Makes WHERE Name ='make 3'))");
            migrationBuilder.Sql("INSERT INTO Models (Name,MakeID) VALUES ('make 3 - model C',(SELECT ID FROM Makes WHERE Name ='make 3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
