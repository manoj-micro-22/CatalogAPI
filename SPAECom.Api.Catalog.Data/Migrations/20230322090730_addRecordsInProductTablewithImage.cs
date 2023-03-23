using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SPAECom.Api.Catalog.Data.Migrations
{
    public partial class addRecordsInProductTablewithImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://spaecommicroservices.blob.core.windows.net/spaecom/14.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImageUrl",
                value: "\"https://spaecommicroservices.blob.core.windows.net/spaecom/12.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://spaecommicroservices.blob.core.windows.net/spaecom/11.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://spaecommicroservices.blob.core.windows.net/spaecom/13.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://spaecommicroservices.blob.core.windows.net/spaecom/14.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://spaecommicroservices.blob.core.windows.net/spaecom/12.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://spaecommicroservices.blob.core.windows.net/spaecom/11.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://spaecommicroservices.blob.core.windows.net/spaecom/13.jpg");
        }
    }
}
