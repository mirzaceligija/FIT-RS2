using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectWe.Services.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "Name" },
                values: new object[,]
                {
                    { 1, "Sarajevo" },
                    { 2, "Mostar" },
                    { 3, "Banja Luka" },
                    { 4, "Tuzla" },
                    { 5, "Zenica" },
                    { 6, "Doboj" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "FirstName", "LastName", "Email", "Phone", "Username", "PasswordHash", "PasswordSalt", "CreatedAt", "LastModified" },
                values: new object[,]
                {
                    { 1, "Super", "Administrator", "admin@projectwe.ba", "+38761123456", "administrator", "fW3+zUqS5TZ4noWe5m2Gy2iWl5g=", "I1KBsQAzfLXu9Wi17o7w2A==", DateTime.Now, DateTime.Now },
                    { 2, "Super", "Manager", "manager@projectwe.ba", "+38761123456", "manager", "cs27wnRqprnxUrcTxuogtKXi8Ik=", "+jxsX/YTyvai5u6sYLSfug==", DateTime.Now, DateTime.Now }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Name", "Description", "CreatedAt", "LastModified" },
                values: new object[,]
                {
                    { 1, "Administrator", null, DateTime.Now, DateTime.Now },
                    { 2, "Manager", null, DateTime.Now, DateTime.Now }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRolesID", "CreatedAt", "LastModified", "UserID", "RoleID" },
                values: new object[,]
                {
                    { 1, DateTime.Now, DateTime.Now, 1, 1 },
                    { 2, DateTime.Now, DateTime.Now, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusID", "Name", "Description", "CreatedAt", "LastModified" },
                values: new object[,]
                {
                    { 1, "Draft", null, DateTime.Now, DateTime.Now },
                    { 2, "Rejected", null, DateTime.Now, DateTime.Now },
                    { 3, "Needs Improvement", null, DateTime.Now, DateTime.Now },
                    { 4, "Approved", null, DateTime.Now, DateTime.Now },
                    { 5, "In Progress", null, DateTime.Now, DateTime.Now },
                    { 6, "On hold", null, DateTime.Now, DateTime.Now },
                    { 7, "Completed", null, DateTime.Now, DateTime.Now }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name", "Description", "CreatedAt", "LastModified" },
                values: new object[,]
                {
                    { 1, "Tech & Innovation", null, DateTime.Now, DateTime.Now },
                    { 2, "Community", null, DateTime.Now, DateTime.Now },
                    { 3, "Creative Works", null, DateTime.Now, DateTime.Now }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectID", "Name", "Description", "CreatedAt", "LastModified", "UserID", "StatusID", "CityID", "CategoryID", "StateMachine" },
                values: new object[,]
                {
                    { 1, "Akcija ciscenja parka", "Naselje Bulevar Stup", DateTime.Now, DateTime.Now, 2, 5, 1, 2, "active" },
                    { 2, "Postavljanje kontenjera za reciklazu", "Vojnicko polje", DateTime.Now, DateTime.Now, 2, 5, 1, 2, "draft" },
                    { 3, "Popravka klupa na Vilsonovom setalistu", "Zamjena daski", DateTime.Now, DateTime.Now, 2, 5, 1, 2, "active" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 3);
        }
    }
}
