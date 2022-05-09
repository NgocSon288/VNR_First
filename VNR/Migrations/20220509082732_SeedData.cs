using Microsoft.EntityFrameworkCore.Migrations;

namespace VNR.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "KhoaHocs",
                columns: new[] { "Id", "TenKhoaHoc" },
                values: new object[] { 1, "Front End" });

            migrationBuilder.InsertData(
                table: "KhoaHocs",
                columns: new[] { "Id", "TenKhoaHoc" },
                values: new object[] { 2, "Back End" });

            migrationBuilder.InsertData(
                table: "KhoaHocs",
                columns: new[] { "Id", "TenKhoaHoc" },
                values: new object[] { 3, "Dotnet Core" });

            migrationBuilder.InsertData(
                table: "MonHocs",
                columns: new[] { "Id", "KhoaHocId", "MoTa", "TenMonHoc" },
                values: new object[,]
                {
                    { 1, 1, "Description Bootstrap", "Bootstrap" },
                    { 2, 1, "Description Angular JS", "Angular JS" },
                    { 3, 1, "Description Angular", "Angular" },
                    { 4, 1, "Description React JS", "React JS" },
                    { 5, 2, "Description Dotnet", "Dotnet" },
                    { 6, 2, "Description ASP NET", "ASP NET" },
                    { 7, 3, "Description Net Core", "Net Core" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MonHocs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MonHocs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MonHocs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MonHocs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MonHocs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MonHocs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MonHocs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "KhoaHocs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KhoaHocs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KhoaHocs",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
