using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebBot.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    idLanguage = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vcharLanguage = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    vcharAbreveation = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.idLanguage);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    idUser = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idTelegramUser = table.Column<long>(type: "bigint", nullable: false),
                    vcharFirstName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    vcharLastName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    vcharUser = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.idUser);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    idGroup = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    boolActive = table.Column<bool>(type: "boolean", nullable: false),
                    idTelegramGroup = table.Column<long>(type: "bigint", nullable: false),
                    numIdLanguage = table.Column<long>(type: "bigint", nullable: false),
                    vcharCountryName = table.Column<string>(type: "text", nullable: false),
                    vcharGroupName = table.Column<string>(type: "text", nullable: false),
                    vcharGroupAdress = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.idGroup);
                    table.ForeignKey(
                        name: "FK_Language_Group",
                        column: x => x.numIdLanguage,
                        principalTable: "Language",
                        principalColumn: "idLanguage",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    idMessage = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numIdLanguage = table.Column<long>(type: "bigint", nullable: false),
                    numType = table.Column<long>(type: "bigint", nullable: false),
                    vcharMessageText = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.idMessage);
                    table.ForeignKey(
                        name: "FK_Language_Message",
                        column: x => x.numIdLanguage,
                        principalTable: "Language",
                        principalColumn: "idLanguage",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bot",
                columns: table => new
                {
                    idBot = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numIdUser = table.Column<long>(type: "bigint", nullable: false),
                    vcharToken = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bot", x => x.idBot);
                    table.ForeignKey(
                        name: "FK_User_Bot",
                        column: x => x.numIdUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupUserDTO",
                columns: table => new
                {
                    idUserGroup = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    boolActive = table.Column<bool>(type: "boolean", nullable: false),
                    boolBanned = table.Column<bool>(type: "boolean", nullable: false),
                    boolMutted = table.Column<bool>(type: "boolean", nullable: false),
                    boolIsAdmin = table.Column<bool>(type: "boolean", nullable: false),
                    dateEntryDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    dateLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    numIdUser = table.Column<long>(type: "bigint", nullable: false),
                    numIdGroup = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUserDTO", x => x.idUserGroup);
                    table.ForeignKey(
                        name: "FK_Group_GroupUser",
                        column: x => x.numIdGroup,
                        principalTable: "Group",
                        principalColumn: "idGroup",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_GroupUser",
                        column: x => x.numIdUser,
                        principalTable: "User",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HelpCommand",
                columns: table => new
                {
                    idCommand = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    boolActive = table.Column<bool>(type: "boolean", nullable: false),
                    boolOnlyAdmin = table.Column<bool>(type: "boolean", nullable: false),
                    numIdBot = table.Column<long>(type: "bigint", nullable: false),
                    vcharDescription = table.Column<string>(type: "text", nullable: false),
                    vcharHelpCommand = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelpCommand", x => x.idCommand);
                    table.ForeignKey(
                        name: "FK_Bot_Command",
                        column: x => x.numIdBot,
                        principalTable: "Bot",
                        principalColumn: "idBot",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Captcha",
                columns: table => new
                {
                    idCaptcha = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dateGeneration = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    numIdUserGroup = table.Column<long>(type: "bigint", nullable: false),
                    numAction = table.Column<long>(type: "bigint", nullable: false),
                    vcharCaptchaValue = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Captcha", x => x.idCaptcha);
                    table.ForeignKey(
                        name: "FK_GroupUser_Captcha",
                        column: x => x.numIdUserGroup,
                        principalTable: "GroupUserDTO",
                        principalColumn: "idUserGroup",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bot_idBot",
                table: "Bot",
                column: "idBot");

            migrationBuilder.CreateIndex(
                name: "IX_Bot_numIdUser",
                table: "Bot",
                column: "numIdUser",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Captcha_idCaptcha",
                table: "Captcha",
                column: "idCaptcha");

            migrationBuilder.CreateIndex(
                name: "IX_Captcha_numIdUserGroup",
                table: "Captcha",
                column: "numIdUserGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Group_idGroup_idTelegramGroup",
                table: "Group",
                columns: new[] { "idGroup", "idTelegramGroup" });

            migrationBuilder.CreateIndex(
                name: "IX_Group_numIdLanguage",
                table: "Group",
                column: "numIdLanguage");

            migrationBuilder.CreateIndex(
                name: "IX_GroupUserDTO_idUserGroup_numIdGroup_numIdUser",
                table: "GroupUserDTO",
                columns: new[] { "idUserGroup", "numIdGroup", "numIdUser" });

            migrationBuilder.CreateIndex(
                name: "IX_GroupUserDTO_numIdGroup",
                table: "GroupUserDTO",
                column: "numIdGroup");

            migrationBuilder.CreateIndex(
                name: "IX_GroupUserDTO_numIdUser",
                table: "GroupUserDTO",
                column: "numIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_HelpCommand_idCommand",
                table: "HelpCommand",
                column: "idCommand");

            migrationBuilder.CreateIndex(
                name: "IX_HelpCommand_numIdBot",
                table: "HelpCommand",
                column: "numIdBot");

            migrationBuilder.CreateIndex(
                name: "IX_Language_idLanguage",
                table: "Language",
                column: "idLanguage");

            migrationBuilder.CreateIndex(
                name: "IX_Message_idMessage",
                table: "Message",
                column: "idMessage");

            migrationBuilder.CreateIndex(
                name: "IX_Message_numIdLanguage",
                table: "Message",
                column: "numIdLanguage");

            migrationBuilder.CreateIndex(
                name: "IX_User_idUser_idTelegramUser",
                table: "User",
                columns: new[] { "idUser", "idTelegramUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Captcha");

            migrationBuilder.DropTable(
                name: "HelpCommand");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "GroupUserDTO");

            migrationBuilder.DropTable(
                name: "Bot");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Language");
        }
    }
}
