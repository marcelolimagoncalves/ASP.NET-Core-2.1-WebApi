using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiUsuarios.Migrations
{
    public partial class PopulandoTabelaUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Usuarios(Nome,Senha,Email) VALUES('Marcelo','123@mudar','marcelo@bol.com.br')");
            migrationBuilder.Sql("INSERT INTO Usuarios(Nome,Senha,Email) VALUES('Roberto','1qazxsw2','roberto@uol.com.br')");
            migrationBuilder.Sql("INSERT INTO Usuarios(Nome,Senha,Email) VALUES('Marina','12345@@@','marina@outlook.com.br')");
            migrationBuilder.Sql("INSERT INTO Usuarios(Nome,Senha,Email) VALUES('Ronaldo','gent@lh@','ronaldo@gmail.com.br')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Usuarios");
        }
    }
}
