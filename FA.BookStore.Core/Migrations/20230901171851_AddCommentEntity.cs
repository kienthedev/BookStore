using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.BookStore.Core.Migrations
{
    public partial class AddCommentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comment_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6212), new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6228), new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6230), new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6232), new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6234), new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6236), new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6238), new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6241), new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6243), new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6245), new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6247), new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6249), new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6251), new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 9, 2, 0, 18, 51, 369, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Description",
                value: "Books of imaginative  narration");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Description",
                value: "Books with futuristic or speculative themes");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Description",
                value: "Books involving puzzles and suspense");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "Description",
                value: "Books about past events and civilizations");

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "BookId", "Content", "CreatedDate", "IsActive" },
                values: new object[,]
                {
                    { 1, 1, "This book is a masterpiece! I couldn't put it down.", new DateTime(2023, 8, 23, 0, 18, 51, 371, DateTimeKind.Local).AddTicks(30), true },
                    { 2, 1, "I loved the characters and the plot twists. Highly recommended.", new DateTime(2023, 8, 24, 0, 18, 51, 371, DateTimeKind.Local).AddTicks(41), true },
                    { 3, 2, "A thought-provoking read. It really makes you reflect on life.", new DateTime(2023, 8, 25, 0, 18, 51, 371, DateTimeKind.Local).AddTicks(42), true },
                    { 4, 2, "The author's writing style is beautiful. I'm a fan!", new DateTime(2023, 8, 26, 0, 18, 51, 371, DateTimeKind.Local).AddTicks(44), true },
                    { 5, 3, "I couldn't stop reading until the very end. Amazing!", new DateTime(2023, 8, 27, 0, 18, 51, 371, DateTimeKind.Local).AddTicks(45), true },
                    { 6, 3, "This book taught me so much about history. Engaging storytelling.", new DateTime(2023, 8, 28, 0, 18, 51, 371, DateTimeKind.Local).AddTicks(47), true },
                    { 7, 4, "The suspense in this book is incredible. Kept me on the edge of my seat.", new DateTime(2023, 8, 29, 0, 18, 51, 371, DateTimeKind.Local).AddTicks(48), true },
                    { 8, 4, "I'm recommending this book to all my friends. It's a must-read.", new DateTime(2023, 8, 30, 0, 18, 51, 371, DateTimeKind.Local).AddTicks(50), true },
                    { 9, 5, "This book changed my perspective on life. Profound and touching.", new DateTime(2023, 8, 31, 0, 18, 51, 371, DateTimeKind.Local).AddTicks(51), true },
                    { 10, 5, "I shed tears while reading this. Beautifully written and emotionally powerful.", new DateTime(2023, 9, 1, 0, 18, 51, 371, DateTimeKind.Local).AddTicks(52), true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_BookId",
                table: "Comment",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(804), new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(815), new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(817), new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(819), new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(821), new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(823), new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(826), new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(828), new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(830), new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(832), new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(834), new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(836), new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(838), new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(840), new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Description",
                value: "Books of imaginative narration");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Description",
                value: "Books with futuristic or    speculative themes");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Description",
                value: "Books involving puzzles and     suspense");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "Description",
                value: "Books about past events and     civilizations");
        }
    }
}
