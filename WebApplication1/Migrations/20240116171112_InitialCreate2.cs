using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PanierId",
                table: "Produit",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_description",
                table: "Produit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "_name",
                table: "Produit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "_price",
                table: "Produit",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "_quantity",
                table: "Produit",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "adresse",
                table: "Commande",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "panierId",
                table: "Commande",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produit_PanierId",
                table: "Produit",
                column: "PanierId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_panierId",
                table: "Commande",
                column: "panierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_Panier_panierId",
                table: "Commande",
                column: "panierId",
                principalTable: "Panier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produit_Panier_PanierId",
                table: "Produit",
                column: "PanierId",
                principalTable: "Panier",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commande_Panier_panierId",
                table: "Commande");

            migrationBuilder.DropForeignKey(
                name: "FK_Produit_Panier_PanierId",
                table: "Produit");

            migrationBuilder.DropIndex(
                name: "IX_Produit_PanierId",
                table: "Produit");

            migrationBuilder.DropIndex(
                name: "IX_Commande_panierId",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "PanierId",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "_description",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "_name",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "_price",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "_quantity",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "adresse",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "panierId",
                table: "Commande");
        }
    }
}
