using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeeDraw.Database.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CurrencyTbl",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LotteryTbl",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskTbl",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RewardAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTbl",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelegramUserId = table.Column<long>(type: "bigint", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    WalletAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RefererId = table.Column<long>(type: "bigint", nullable: false),
                    DateJoined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsBot = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LotteryPrizeTbl",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LotteryId = table.Column<int>(type: "int", nullable: false),
                    LotteryId1 = table.Column<long>(type: "bigint", nullable: true),
                    PrizeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrizeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumberOfPrizes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryPrizeTbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryPrizeTbl_LotteryTbl_LotteryId1",
                        column: x => x.LotteryId1,
                        principalTable: "LotteryTbl",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompletionTbl",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<long>(type: "bigint", nullable: true),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    TaskId1 = table.Column<long>(type: "bigint", nullable: true),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRewardClaimed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletionTbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompletionTbl_TaskTbl_TaskId1",
                        column: x => x.TaskId1,
                        principalTable: "TaskTbl",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompletionTbl_UserTbl_UserId1",
                        column: x => x.UserId1,
                        principalTable: "UserTbl",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FriendshipTbl",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<long>(type: "bigint", nullable: false),
                    ReceiverId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendshipTbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FriendshipTbl_UserTbl_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "UserTbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FriendshipTbl_UserTbl_SenderId",
                        column: x => x.SenderId,
                        principalTable: "UserTbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LotteryTicketTbl",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsWinner = table.Column<bool>(type: "bit", nullable: false),
                    LotteryId = table.Column<int>(type: "int", nullable: false),
                    LotteryId1 = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<long>(type: "bigint", nullable: true),
                    TicketCount = table.Column<int>(type: "int", nullable: false),
                    DatePurchased = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryTicketTbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryTicketTbl_LotteryTbl_LotteryId1",
                        column: x => x.LotteryId1,
                        principalTable: "LotteryTbl",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LotteryTicketTbl_UserTbl_UserId1",
                        column: x => x.UserId1,
                        principalTable: "UserTbl",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WalletTbl",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletTbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WalletTbl_UserTbl_UserId1",
                        column: x => x.UserId1,
                        principalTable: "UserTbl",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WalletBalanceTbl",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WalletId = table.Column<int>(type: "int", nullable: false),
                    WalletId1 = table.Column<long>(type: "bigint", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId1 = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletBalanceTbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WalletBalanceTbl_CurrencyTbl_CurrencyId1",
                        column: x => x.CurrencyId1,
                        principalTable: "CurrencyTbl",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WalletBalanceTbl_WalletTbl_WalletId1",
                        column: x => x.WalletId1,
                        principalTable: "WalletTbl",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompletionTbl_TaskId1",
                table: "CompletionTbl",
                column: "TaskId1");

            migrationBuilder.CreateIndex(
                name: "IX_CompletionTbl_UserId1",
                table: "CompletionTbl",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_FriendshipTbl_ReceiverId",
                table: "FriendshipTbl",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_FriendshipTbl_SenderId",
                table: "FriendshipTbl",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryPrizeTbl_LotteryId1",
                table: "LotteryPrizeTbl",
                column: "LotteryId1");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryTicketTbl_LotteryId1",
                table: "LotteryTicketTbl",
                column: "LotteryId1");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryTicketTbl_UserId1",
                table: "LotteryTicketTbl",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_WalletBalanceTbl_CurrencyId1",
                table: "WalletBalanceTbl",
                column: "CurrencyId1");

            migrationBuilder.CreateIndex(
                name: "IX_WalletBalanceTbl_WalletId1",
                table: "WalletBalanceTbl",
                column: "WalletId1");

            migrationBuilder.CreateIndex(
                name: "IX_WalletTbl_UserId1",
                table: "WalletTbl",
                column: "UserId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompletionTbl");

            migrationBuilder.DropTable(
                name: "FriendshipTbl");

            migrationBuilder.DropTable(
                name: "LotteryPrizeTbl");

            migrationBuilder.DropTable(
                name: "LotteryTicketTbl");

            migrationBuilder.DropTable(
                name: "WalletBalanceTbl");

            migrationBuilder.DropTable(
                name: "TaskTbl");

            migrationBuilder.DropTable(
                name: "LotteryTbl");

            migrationBuilder.DropTable(
                name: "CurrencyTbl");

            migrationBuilder.DropTable(
                name: "WalletTbl");

            migrationBuilder.DropTable(
                name: "UserTbl");
        }
    }
}
