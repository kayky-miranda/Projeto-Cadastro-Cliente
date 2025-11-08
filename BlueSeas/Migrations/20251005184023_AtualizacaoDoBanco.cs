using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueSeas.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoDoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cadastros",
                newName: "URL");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Cadastros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Cadastros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CNPJ",
                table: "Cadastros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Cadastros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Cadastros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InscricaoEstadual",
                table: "Cadastros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InscricaoMunicipal",
                table: "Cadastros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InscricaoSocial",
                table: "Cadastros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "Cadastros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeFantasia",
                table: "Cadastros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Cadastros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RazaoSocial",
                table: "Cadastros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "Cadastros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "WhatsApp",
                table: "Cadastros",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Cadastros");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Cadastros");

            migrationBuilder.DropColumn(
                name: "CNPJ",
                table: "Cadastros");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Cadastros");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Cadastros");

            migrationBuilder.DropColumn(
                name: "InscricaoEstadual",
                table: "Cadastros");

            migrationBuilder.DropColumn(
                name: "InscricaoMunicipal",
                table: "Cadastros");

            migrationBuilder.DropColumn(
                name: "InscricaoSocial",
                table: "Cadastros");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "Cadastros");

            migrationBuilder.DropColumn(
                name: "NomeFantasia",
                table: "Cadastros");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Cadastros");

            migrationBuilder.DropColumn(
                name: "RazaoSocial",
                table: "Cadastros");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "Cadastros");

            migrationBuilder.DropColumn(
                name: "WhatsApp",
                table: "Cadastros");

            migrationBuilder.RenameColumn(
                name: "URL",
                table: "Cadastros",
                newName: "Nome");
        }
    }
}
