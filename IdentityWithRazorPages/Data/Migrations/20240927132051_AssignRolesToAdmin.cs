using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityWithRazorPages.Data.Migrations
{
    public partial class AssignRolesToAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into [Security].[UserRoles] (UserId,RoleId) Select '1fc4db9c-947c-4024-82df-0e6a46cd8e7a', Id From [Security].[Roles] ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from [Security].[UserRoles] where UserId = '1fc4db9c-947c-4024-82df-0e6a46cd8e7a'");
        }
    }
}
