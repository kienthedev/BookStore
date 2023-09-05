using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.BookStore.Core.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Fiction", "Books of imaginative narration" },
                    { 2, "Science Fiction", "Books with futuristic or speculative themes" },
                    { 3, "Mystery", "Books involving puzzles and suspense" },
                    { 4, "History", "Books about past events and civilizations" },
                    { 5, "Self-Help", "Books for personal growth and development" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "One of the world's largest English-language trade book publishers.", "Penguin Random House" },
                    { 2, "A prominent publishing company with a wide range of titles.", "HarperCollins" },
                    { 3, "A major American book publishing company.", "Simon & Schuster" },
                    { 4, "Known for publishing books on technology and programming.", "O'Reilly Media" },
                    { 5, "Publishes self-help, spiritual, and personal growth books.", "Hay House" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "CategoryId", "CreatedDate", "ImgUrl", "IsActive", "ModifiedDate", "Price", "PublisherId", "Quantity", "Summary", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(804), "gatsby.jpg", true, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(812), 12.99m, 1, 20, "A  classic novel depicting the excesses of the Jazz Age.", "The Great Gatsby" },
                    { 2, 2, 1, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(815), "mockingbird.jpg", true, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(816), 14.99m, 2, 15, "A story addressing issues of racial injustice and moral growth.", "To Kill a Mockingbird" },
                    { 3, 3, 2, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(817), "1984.jpg", true, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(818), 10.99m, 3, 25, "A dystopian novel  exploring themes of totalitarianism and surveillance.", "1984" },
                    { 4, 4, 3, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(819), "alchemist.jpg", true, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(820), 9.99m, 4, 30, "A philosophical novel about a shepherd's journey to find his personal legend.", "The Alchemist" },
                    { 5, 5, 4, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(821), "educated.jpg", true, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(822), 18.99m, 5, 10, "A memoir   recounting the author's journey from a survivalist family to education.", "Educated" },
                    { 6, 6, 2, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(823), "lotr.jpg", true, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(824), 29.99m, 1, 18, "Epic fantasy series set in the fictional world of Middle-earth.", "The Lord of the Rings" },
                    { 7, 7, 1, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(826), "pride.jpg", true, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(826), 11.99m, 2, 22, "Classic romantic novel exploring social issues and manners.", "Pride and Prejudice" },
                    { 8, 8, 2, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(828), "harry.jpg", true, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(828), 16.99m, 3, 28, "Start of the fantasy series following the journey of a young wizard.", "Harry Potter and the Sorcerer's Stone" },
                    { 9, 9, 1, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(830), "catcher.jpg", true, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(830), 13.99m, 4, 17, "Coming-of-age novel reflecting on teenage angst and alienation.", "The Catcher in the Rye" },
                    { 10, 10, 5, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(832), "leanin.jpg", true, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(832), 21.99m, 5, 12, "A book    encouraging women to pursue leadership roles and careers.", "Lean In" },
                    { 11, 11, 2, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(834), "hunger.jpg", true, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(834), 14.99m, 1, 20, "Dystopian novel about a young girl's fight for survival in a deadly competition.", "The Hunger Games" },
                    { 12, 12, 3, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(836), "martian.jpg", true, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(836), 17.99m, 2, 15, "Science   fiction novel about an astronaut stranded on Mars.", "The Martian" },
                    { 13, 13, 1, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(838), "gone.jpg", true, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(839), 13.99m, 3, 18, "Psychological thriller about a woman's mysterious disappearance.", "Gone Girl" },
                    { 14, 14, 2, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(840), "davinci.jpg", true, new DateTime(2023, 8, 31, 16, 46, 16, 886, DateTimeKind.Local).AddTicks(841), 15.99m, 4, 25, "Mystery thriller involving a murder and a secret society.", "The Da Vinci Code" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 5);
        }
    }
}
