using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(Select Id from AspNetRoles where Id = '1d27c037-6660-4777-89c6-99274637b98c')
BEGIN
	INSERT AspNetRoles (Id, [Name], [NormalizedName])
	VALUES ('1d27c037-6660-4777-89c6-99274637b98c', 'admin', 'ADMIN')
END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE AspNetRoles where Id = '1d27c037-6660-4777-89c6-99274637b98c'");
        }
    }
}
