using Microsoft.EntityFrameworkCore.Migrations;

namespace SGM.Infrastructure.Migrations
{
    public partial class ConfiguraClassePessoa_pessoaTipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "PessoaTipo",
                type: "Varchar(50",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "PessoaTipo",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(50");
        }
    }
}
