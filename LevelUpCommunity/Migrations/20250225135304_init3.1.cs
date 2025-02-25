using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LevelUpCommunity.Migrations
{
    /// <inheritdoc />
    public partial class init31 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberEvent_Events_EventIdFk",
                table: "MemberEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberEvent_Members_MemberIdFk",
                table: "MemberEvent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MemberEvent",
                table: "MemberEvent");

            migrationBuilder.RenameTable(
                name: "MemberEvent",
                newName: "MemberEvents");

            migrationBuilder.RenameIndex(
                name: "IX_MemberEvent_MemberIdFk",
                table: "MemberEvents",
                newName: "IX_MemberEvents_MemberIdFk");

            migrationBuilder.RenameIndex(
                name: "IX_MemberEvent_EventIdFk",
                table: "MemberEvents",
                newName: "IX_MemberEvents_EventIdFk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MemberEvents",
                table: "MemberEvents",
                column: "MemberEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberEvents_Events_EventIdFk",
                table: "MemberEvents",
                column: "EventIdFk",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberEvents_Members_MemberIdFk",
                table: "MemberEvents",
                column: "MemberIdFk",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberEvents_Events_EventIdFk",
                table: "MemberEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberEvents_Members_MemberIdFk",
                table: "MemberEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MemberEvents",
                table: "MemberEvents");

            migrationBuilder.RenameTable(
                name: "MemberEvents",
                newName: "MemberEvent");

            migrationBuilder.RenameIndex(
                name: "IX_MemberEvents_MemberIdFk",
                table: "MemberEvent",
                newName: "IX_MemberEvent_MemberIdFk");

            migrationBuilder.RenameIndex(
                name: "IX_MemberEvents_EventIdFk",
                table: "MemberEvent",
                newName: "IX_MemberEvent_EventIdFk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MemberEvent",
                table: "MemberEvent",
                column: "MemberEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberEvent_Events_EventIdFk",
                table: "MemberEvent",
                column: "EventIdFk",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberEvent_Members_MemberIdFk",
                table: "MemberEvent",
                column: "MemberIdFk",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
