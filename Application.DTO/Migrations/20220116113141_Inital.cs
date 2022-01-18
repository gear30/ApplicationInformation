using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.DTO.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseAddressString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkAddressString = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Permitted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Occupations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OccupationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Informations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryOfResidence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InformationAddressID = table.Column<int>(type: "int", nullable: true),
                    InformationOccupationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Informations_Addresses_InformationAddressID",
                        column: x => x.InformationAddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Informations_Occupations_InformationOccupationID",
                        column: x => x.InformationOccupationID,
                        principalTable: "Occupations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "CountryName", "Permitted" },
                values: new object[,]
                {
                    { 1, "Cambodia", false },
                    { 131, "Tanzania", true },
                    { 132, "Namibia", true },
                    { 133, "Nigeria", true },
                    { 134, "Niger", true },
                    { 135, "Botswana", true },
                    { 136, "Burundi", true },
                    { 137, "Burkina Faso", true },
                    { 138, "Benin", true },
                    { 139, "Mauritius", true },
                    { 140, "Mauritania", true },
                    { 141, "Madagascar", true },
                    { 142, "Malawi", true },
                    { 143, "Mali", true },
                    { 144, "Mozambique", true },
                    { 145, "Morocco", true },
                    { 146, "Uganda", true },
                    { 147, "Rwanda", true },
                    { 148, "Libya", true },
                    { 149, "Lesotho", true },
                    { 150, "Liberia", true },
                    { 151, "Swaziland", true },
                    { 130, "Togo", true },
                    { 129, "Tunisia", true },
                    { 128, "Somalia", true },
                    { 127, "Zambia", true },
                    { 105, "Iceland", true },
                    { 106, "Ireland", true },
                    { 107, "Hungary", true },
                    { 108, "Ghana", true },
                    { 109, "Gabon", true },
                    { 110, "Cabo Verde", true },
                    { 111, "Guinea", true },
                    { 112, "Guinea-Bissau", true },
                    { 113, "The Gambia", true },
                    { 114, "Côte d’Ivoire", true },
                    { 152, "Republic of the Congo", true },
                    { 115, "Comoros", true },
                    { 117, "Cameroon", true },
                    { 118, "Djibouti", true },
                    { 119, "Chad", true },
                    { 120, "Zimbabwe", true }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "CountryName", "Permitted" },
                values: new object[,]
                {
                    { 121, "Sudan", true },
                    { 122, "Seychelles", true },
                    { 123, "Senegal", true },
                    { 124, "São Tomé and Príncipe", true },
                    { 125, "South Sudan", true },
                    { 126, "Sierra Leone", true },
                    { 116, "Kenya", true },
                    { 104, "Albania", true },
                    { 153, "Democratic Republic of the Congo", true },
                    { 155, "Equatorial Guinea", true },
                    { 182, "Honduras", true },
                    { 183, "Haiti", true },
                    { 184, "Guyana", true },
                    { 185, "Colombia", true },
                    { 186, "Chile", true },
                    { 187, "Suriname", true },
                    { 188, "Trinidad and Tobago", true },
                    { 189, "Brazil", true },
                    { 190, "Bolivia", true },
                    { 191, "Paraguay", true },
                    { 192, "Peru", true },
                    { 193, "Venezuela", true },
                    { 194, "Argentina", true },
                    { 195, "Uruguay", true },
                    { 196, "Ecuador", true },
                    { 197, "South Ossetia", true },
                    { 198, "Somaliland", true },
                    { 199, "Northern Cyprus", true },
                    { 200, "Taiwan", true },
                    { 201, "Transnistria", true },
                    { 202, "Nagorno-Karabakh", true },
                    { 181, "Antigua and Barbuda", true },
                    { 180, "El Salvador", true },
                    { 179, "Dominican Republic", true },
                    { 178, "United States of America", true },
                    { 156, "Egypt", true },
                    { 157, "Ethiopia", true },
                    { 158, "Eritrea", true },
                    { 159, "Angola", true },
                    { 160, "South Africa", true },
                    { 161, "Algeria", true },
                    { 162, "Guatemala", true }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "CountryName", "Permitted" },
                values: new object[,]
                {
                    { 163, "Grenada", true },
                    { 164, "Costa Rica", true },
                    { 165, "Cuba", true },
                    { 154, "Central African Republic", true },
                    { 166, "Canada", true },
                    { 168, "Saint Kitts and Nevis", true },
                    { 169, "Saint Lucia", true },
                    { 170, "Saint Vincent and the Grenadines", true },
                    { 171, "Dominica", true },
                    { 172, "Nicaragua", true },
                    { 173, "Barbados", true },
                    { 174, "Bahamas", true },
                    { 175, "Belize", true },
                    { 176, "Panama", true },
                    { 177, "Mexico", true },
                    { 167, "Jamaica", true },
                    { 103, "Estonia", true },
                    { 102, "Italy", true },
                    { 101, "Andorra", true },
                    { 28, "Bhutan", true },
                    { 29, "Mongolia", true },
                    { 30, "Maldives", true },
                    { 31, "Malaysia", true },
                    { 32, "Yemen", true },
                    { 33, "Laos", true },
                    { 34, "Lebanon", true },
                    { 35, "Vietnam", true },
                    { 36, "Sri Lanka", true },
                    { 37, "United Arab Emirates", true },
                    { 38, "Singapore", true },
                    { 39, "Afghanistan", true },
                    { 40, "Azerbaijan", true },
                    { 41, "Armenia", true },
                    { 42, "India", true },
                    { 43, "Indonesia", true },
                    { 44, "Iraq", true },
                    { 45, "Israel", true },
                    { 46, "Iran", true },
                    { 47, "Uzbekistan", true },
                    { 48, "Oman", true },
                    { 27, "Philippines", true },
                    { 26, "Myanmar", false }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "CountryName", "Permitted" },
                values: new object[,]
                {
                    { 25, "Palestine", true },
                    { 24, "Pakistan", false },
                    { 2, "Qatar", true },
                    { 3, "South Korea", true },
                    { 4, "North Korea", true },
                    { 5, "Kazakhstan", true },
                    { 6, "Kyrgyzstan", true },
                    { 7, "Kuwait", true },
                    { 8, "Georgia", true },
                    { 9, "Jordan", true },
                    { 10, "China", true },
                    { 11, "Saudi Arabia", true },
                    { 49, "Kiribati", true },
                    { 12, "Syria", true },
                    { 14, "Japan", true },
                    { 15, "Timor-Leste", true },
                    { 16, "Turkey", true },
                    { 17, "Turkmenistan", true },
                    { 18, "Tajikistan", true },
                    { 19, "Thailand", true },
                    { 20, "Nepal", true },
                    { 21, "Brunei Darussalam", true },
                    { 22, "Bangladesh", true },
                    { 23, "Bahrain", true },
                    { 13, "Cyprus", true },
                    { 50, "Samoa", true },
                    { 51, "Tonga", true },
                    { 52, "Tuvalu", true },
                    { 79, "Finland", true },
                    { 80, "Montenegro", true },
                    { 81, "Moldova", true },
                    { 82, "Malta", true },
                    { 83, "Monaco", true },
                    { 84, "Ukraine", true },
                    { 85, "Germany", true },
                    { 86, "Russia", true },
                    { 87, "Romania", true },
                    { 88, "Luxembourg", true },
                    { 78, "France", true },
                    { 89, "Latvia", true },
                    { 91, "Lithuania", true },
                    { 92, "Spain", true }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "CountryName", "Permitted" },
                values: new object[,]
                {
                    { 93, "Slovakia", true },
                    { 94, "Slovenia", true },
                    { 95, "Switzerland", true },
                    { 96, "Sweden", true },
                    { 97, "United Kingdom", true },
                    { 98, "Czech Republic", true },
                    { 99, "Republic of Macedonia", true },
                    { 100, "Austria", true },
                    { 90, "Liechtenstein", true },
                    { 203, "Sahrawi Arab Democratic Republic", true },
                    { 77, "Poland", true },
                    { 75, "Belarus", true },
                    { 53, "Nauru", true },
                    { 54, "New Zealand", true },
                    { 55, "Papua New Guinea", true },
                    { 56, "Palau", true },
                    { 57, "Fiji", true },
                    { 58, "Micronesia", true },
                    { 59, "Vanuatu", true },
                    { 60, "Solomon Islands", true },
                    { 61, "Marshall Islands", true },
                    { 62, "Australia", true },
                    { 76, "Portugal", true },
                    { 63, "Greece", true },
                    { 65, "Croatia", true },
                    { 66, "San Marino", true },
                    { 67, "Serbia", true },
                    { 68, "Denmark", true },
                    { 69, "Vatican City State", true },
                    { 70, "Norway", true },
                    { 71, "Netherlands", true },
                    { 72, "Bosnia and Herzegovina", true },
                    { 73, "Bulgaria", true },
                    { 74, "Belgium", true },
                    { 64, "Kosovo", true },
                    { 204, "Abkhazia", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Informations_InformationAddressID",
                table: "Informations",
                column: "InformationAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Informations_InformationOccupationID",
                table: "Informations",
                column: "InformationOccupationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Informations");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Occupations");
        }
    }
}
