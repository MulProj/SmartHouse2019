using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class SeeningDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Houses (Description) VALUES ('Pierwszy dom testowy')");

            migrationBuilder.Sql("INSERT INTO Sensors (Discriminator, Temperature, IsOn, HouseId) VALUES ('TemperatureSensor', 21, 0, 1)");
            migrationBuilder.Sql("INSERT INTO Sensors (Discriminator, Humidity, IsOn, HouseId) VALUES ('HumiditySensor', 15, 0, 1)");
            migrationBuilder.Sql("INSERT INTO Sensors (Discriminator, Smoke, IsOn, HouseId) VALUES ('SmokeSensor', 12, 0, 1)");
            migrationBuilder.Sql("INSERT INTO Sensors (Discriminator, IsMove, IsOn, HouseId) VALUES ('MotionSensor', 0, 0, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Houses");
            migrationBuilder.Sql("DELETE FROM Sensors");
        }
    }
}
