using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessTracker.Migrations
{
    public partial class dataSeed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Fat", "Name", "Protein", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, 119, 0, 3, "Boneless, Skinless Chicken Breast", 23, null, null },
                    { 24, 24, 4, 0, "Asparagus", 2, null, null },
                    { 25, 8, 1, 0, "Spinach", 1, null, null },
                    { 26, 12, 2, 0, "Multi Colored Bell Peppers", 1, null, null },
                    { 27, 20, 4, 0, "Brussels Sprouts", 1, null, null },
                    { 28, 28, 5, 0, "Cauliflower", 2, null, null },
                    { 29, 24, 4, 0, "Zucchini", 2, null, null },
                    { 30, 20, 4, 0, "Cucumber", 1, null, null },
                    { 31, 16, 2, 0, "Mushrooms", 2, null, null },
                    { 23, 32, 6, 0, "Broccoli", 2, null, null },
                    { 32, 60, 15, 0, "Apple", 0, null, null },
                    { 34, 80, 19, 0, "Mango", 1, null, null },
                    { 35, 72, 16, 0, "Navel orange", 2, null, null },
                    { 36, 44, 11, 0, "Blueberries", 0, null, null },
                    { 37, 40, 9, 0, "Strawberries", 1, null, null },
                    { 38, 60, 14, 0, "Blackberries", 1, null, null },
                    { 39, 704, 28, 56, "Almond Butter", 22, null, null },
                    { 40, 1008, 0, 112, "Olive Oil", 0, null, null },
                    { 41, 504, 0, 56, "Clarified or organic butter", 0, null, null },
                    { 33, 112, 27, 0, "Banana", 1, null, null },
                    { 42, 1008, 0, 112, "Coconut oil", 0, null, null },
                    { 22, 12, 2, 0, "Lettuce", 1, null, null },
                    { 20, 360, 84, 0, "White Rice", 6, null, null },
                    { 2, 81, 0, 1, "Tuna(water packed), can", 18, null, null },
                    { 3, 78, 0, 2, "Salmon Filet", 15, null, null },
                    { 4, 123, 0, 3, "Schrimp", 24, null, null },
                    { 5, 121, 0, 4, "Extra Lean Ground Beef or Ground Round", 24, null, null },
                    { 6, 69, 0, 5, "Egg", 6, null, null },
                    { 7, 52, 0, 0, "Egg Whites", 11, null, null },
                    { 8, 235, 0, 15, "Rib eye Steak", 25, null, null },
                    { 9, 212, 0, 8, "Top round Steak", 35, null, null },
                    { 21, 88, 20, 0, "White Potatoes, raw", 2, null, null },
                    { 10, 275, 0, 15, "Sirloin steak", 35, null, null },
                    { 12, 100, 0, 4, "NY Strip Steak", 16, null, null },
                    { 13, 200, 0, 8, "Flank Steak(Stir Fry, Fajita)", 32, null, null },
                    { 14, 146, 0, 6, "Pork Loin", 23, null, null },
                    { 15, 122, 0, 2, "Ground turkey(Turkey Breast Slices or cutlets(fresh meat, not deli cuts)", 26, null, null },
                    { 16, 100, 23, 0, "Sweet Potatoes, raw", 2, null, null },
                    { 17, 272, 62, 0, "Quinoa", 6, null, null },
                    { 18, 347, 60, 7, "Oats", 11, null, null },
                    { 19, 459, 96, 3, "Old Fashioned Grifts", 12, null, null },
                    { 11, 200, 0, 8, "Filet Mignon", 32, null, null }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Fat", "Name", "Protein", "UserId", "UserId1" },
                values: new object[] { 43, 142, 2, 14, "Avocado", 2, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43);
        }
    }
}
