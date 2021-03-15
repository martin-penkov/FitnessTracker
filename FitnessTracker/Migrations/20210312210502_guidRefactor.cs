using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessTracker.Migrations
{
    public partial class guidRefactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_AspNetUsers_UserId1",
                table: "Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_AspNetUsers_UserId1",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_UserId1",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_UserId1",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Exercises");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Foods",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Exercises",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_UserId",
                table: "Foods",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_UserId",
                table: "Exercises",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_AspNetUsers_UserId",
                table: "Exercises",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_AspNetUsers_UserId",
                table: "Foods",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_AspNetUsers_UserId",
                table: "Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_AspNetUsers_UserId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_UserId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_UserId",
                table: "Exercises");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Foods",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Foods",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Exercises",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Exercises",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_UserId1",
                table: "Foods",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_UserId1",
                table: "Exercises",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_AspNetUsers_UserId1",
                table: "Exercises",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_AspNetUsers_UserId1",
                table: "Foods",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
