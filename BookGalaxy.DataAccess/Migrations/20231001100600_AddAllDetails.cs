using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookGalaxy.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAllDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 4, 4, "Novel" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Shivaji Sawant", 3, "Karn, the Suryaputra (Son of God) who spends his whole life being mocked as Sutputra. Karn, the Jayshtha Kauntya(Eldest Son of Kunti, the queen mother) who is better known as Radhay. Karn who was equally admired and loved by Panchali (The Empress) and Vrishaali. Karn, the invincible, born with a sheath which could never be penetrated is the most soft hearted philanthropist;Karn,the one who never returned anybody from his door empty handed but could never fill up his own hands .", "CAW777777701", 600.0, 550.0, 500.0, 500.0, "Mrutyunjay" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Chetan Bhagat", 4, "novel by Chetan Bhagat. Its story is concerned with a love triangle, corruption and a journey of self-discovery. R2020 has addressed the issue of how private coaching institutions exploit aspiring engineering students and how parents put their lifetime's earnings on stake for these classes so that their children can crack engineering exams and change the fortune of the family ", "CAW777777702", 200.0, 190.0, 180.0, 180.0, "Revolution 2020" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Rudyard Kipling", "It is set after the Second Afghan War (which ended in 1881), but before the Third (fought in 1919), probably in the period 1893 to 1898.[2] The novel is notable for its detailed portrait of the people, culture, and varied religions of India. \"The book presents a vivid picture of India, its teeming populations, religions, and superstitions, and the life of the bazaars and the road.", 550.0, 500.0, 500.0, 550.0, "Kim" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Harry Lorayne", 220.0, 200.0, 190.0, 190.0, "Secrets of Mind Power" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "M Laxmikanth", "McGraw Hill presents the seventh edition of the consistent best seller and the most celebrated title on the subject – Indian Polity by M Laxmikanth. The book is a must-read for the aspirants appearing for the UPSC – Civil Services Examination as well as the other State Services examinations. It is conceived to cater to the requirements of not just the students appearing for competitive examinations but also postgraduates, research scholars, academicians and general readers who are interested in the country’s political, civil, and constitutional issues. The chapters have been thoroughly revised as per the recent developments with an addition of 12 new chapters in this latest edition.", 800.0, 800.0, 700.0, 750.0, " Indian Polity " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Bernard Schutz", 2, "An accessible introduction to astronomy and general relativity, using only high-school level mathematics to explain the laws of physics governing gravity. Suitable as a university textbook for introductory physics and astronomy courses, the book will also be of interest to general readers wishing to understand the workings of our universe. ", 5999.0, 5999.0, 5550.0, 5555.0, "Gravity from the Ground Up" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Billy Spark", 1, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Nancy Hoover", 1, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "CAW777777701", 40.0, 30.0, 20.0, 25.0, "Dark Skies" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Julian Button", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Abby Muscles", 70.0, 65.0, 55.0, 60.0, "Cotton Candy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Ron Parker", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", 30.0, 27.0, 20.0, 25.0, "Rock in the Ocean" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Laura Phantom", 3, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", 25.0, 23.0, 20.0, 22.0, "Leaves and Wonders" });
        }
    }
}
