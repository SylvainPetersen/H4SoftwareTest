using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace H4SoftwareTest.Migrations.TodoDb
{
    /// <inheritdoc />
    public partial class SecondDatabseInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoList_cpr_UserId",
                table: "ToDoList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cpr",
                table: "cpr");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoList",
                table: "ToDoList");

            migrationBuilder.RenameTable(
                name: "cpr",
                newName: "Cpr");

            migrationBuilder.RenameTable(
                name: "ToDoList",
                newName: "Todos");

            migrationBuilder.RenameIndex(
                name: "IX_ToDoList_UserId",
                table: "Todos",
                newName: "IX_Todos_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cpr",
                table: "Cpr",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Todos",
                table: "Todos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Cpr_UserId",
                table: "Todos",
                column: "UserId",
                principalTable: "Cpr",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Cpr_UserId",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cpr",
                table: "Cpr");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Todos",
                table: "Todos");

            migrationBuilder.RenameTable(
                name: "Cpr",
                newName: "cpr");

            migrationBuilder.RenameTable(
                name: "Todos",
                newName: "ToDoList");

            migrationBuilder.RenameIndex(
                name: "IX_Todos_UserId",
                table: "ToDoList",
                newName: "IX_ToDoList_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cpr",
                table: "cpr",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoList",
                table: "ToDoList",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoList_cpr_UserId",
                table: "ToDoList",
                column: "UserId",
                principalTable: "cpr",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
