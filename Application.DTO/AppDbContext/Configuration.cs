using Application.DTO.AppDbContext;
using Application.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.AppDbContext
{
    internal sealed class Configuration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(e => e.ID);

            builder.HasData(new Country[]
            {
                new Country { ID = 1, CountryName = "Cambodia", Permitted = false },
                new Country { ID = 2, CountryName = "Qatar", Permitted = true },
                new Country { ID = 3, CountryName = "South Korea", Permitted = true },
                new Country { ID = 4, CountryName = "North Korea", Permitted = true },
                new Country { ID = 5, CountryName = "Kazakhstan", Permitted = true },
                new Country { ID = 6, CountryName = "Kyrgyzstan", Permitted = true },
                new Country { ID = 7, CountryName = "Kuwait", Permitted = true },
                new Country { ID = 8, CountryName = "Georgia", Permitted = true },
                new Country { ID = 9, CountryName = "Jordan", Permitted = true },
                new Country { ID = 10, CountryName = "China", Permitted = true },
                new Country { ID = 11, CountryName = "Saudi Arabia", Permitted = true },
                new Country { ID = 12, CountryName = "Syria", Permitted = true },
                new Country { ID = 13, CountryName = "Cyprus", Permitted = true },
                new Country { ID = 14, CountryName = "Japan", Permitted = true },
                new Country { ID = 15, CountryName = "Timor-Leste", Permitted = true },
                new Country { ID = 16, CountryName = "Turkey", Permitted = true },
                new Country { ID = 17, CountryName = "Turkmenistan", Permitted = true },
                new Country { ID = 18, CountryName = "Tajikistan", Permitted = true },
                new Country { ID = 19, CountryName = "Thailand", Permitted = true },
                new Country { ID = 20, CountryName = "Nepal", Permitted = true },
                new Country { ID = 21, CountryName = "Brunei Darussalam", Permitted = true },
                new Country { ID = 22, CountryName = "Bangladesh", Permitted = true },
                new Country { ID = 23, CountryName = "Bahrain", Permitted = true },
                new Country { ID = 24, CountryName = "Pakistan", Permitted = false },
                new Country { ID = 25, CountryName = "Palestine", Permitted = true },
                new Country { ID = 26, CountryName = "Myanmar", Permitted = false },
                new Country { ID = 27, CountryName = "Philippines", Permitted = true },
                new Country { ID = 28, CountryName = "Bhutan", Permitted = true },
                new Country { ID = 29, CountryName = "Mongolia", Permitted = true },
                new Country { ID = 30, CountryName = "Maldives", Permitted = true },
                new Country { ID = 31, CountryName = "Malaysia", Permitted = true },
                new Country { ID = 32, CountryName = "Yemen", Permitted = true },
                new Country { ID = 33, CountryName = "Laos", Permitted = true },
                new Country { ID = 34, CountryName = "Lebanon", Permitted = true },
                new Country { ID = 35, CountryName = "Vietnam", Permitted = true },
                new Country { ID = 36, CountryName = "Sri Lanka", Permitted = true },
                new Country { ID = 37, CountryName = "United Arab Emirates", Permitted = true },
                new Country { ID = 38, CountryName = "Singapore", Permitted = true },
                new Country { ID = 39, CountryName = "Afghanistan", Permitted = true },
                new Country { ID = 40, CountryName = "Azerbaijan", Permitted = true },
                new Country { ID = 41, CountryName = "Armenia", Permitted = true },
                new Country { ID = 42, CountryName = "India", Permitted = true },
                new Country { ID = 43, CountryName = "Indonesia", Permitted = true },
                new Country { ID = 44, CountryName = "Iraq", Permitted = true },
                new Country { ID = 45, CountryName = "Israel", Permitted = true },
                new Country { ID = 46, CountryName = "Iran", Permitted = true },
                new Country { ID = 47, CountryName = "Uzbekistan", Permitted = true },
                new Country { ID = 48, CountryName = "Oman", Permitted = true },
                new Country { ID = 49, CountryName = "Kiribati", Permitted = true },
                new Country { ID = 50, CountryName = "Samoa", Permitted = true },
                new Country { ID = 51, CountryName = "Tonga", Permitted = true },
                new Country { ID = 52, CountryName = "Tuvalu", Permitted = true },
                new Country { ID = 53, CountryName = "Nauru", Permitted = true },
                new Country { ID = 54, CountryName = "New Zealand", Permitted = true },
                new Country { ID = 55, CountryName = "Papua New Guinea", Permitted = true },
                new Country { ID = 56, CountryName = "Palau", Permitted = true },
                new Country { ID = 57, CountryName = "Fiji", Permitted = true },
                new Country { ID = 58, CountryName = "Micronesia", Permitted = true },
                new Country { ID = 59, CountryName = "Vanuatu", Permitted = true },
                new Country { ID = 60, CountryName = "Solomon Islands", Permitted = true },
                new Country { ID = 61, CountryName = "Marshall Islands", Permitted = true },
                new Country { ID = 62, CountryName = "Australia", Permitted = true },
                new Country { ID = 63, CountryName = "Greece", Permitted = true },
                new Country { ID = 64, CountryName = "Kosovo", Permitted = true },
                new Country { ID = 65, CountryName = "Croatia", Permitted = true },
                new Country { ID = 66, CountryName = "San Marino", Permitted = true },
                new Country { ID = 67, CountryName = "Serbia", Permitted = true },
                new Country { ID = 68, CountryName = "Denmark", Permitted = true },
                new Country { ID = 69, CountryName = "Vatican City State", Permitted = true },
                new Country { ID = 70, CountryName = "Norway", Permitted = true },
                new Country { ID = 71, CountryName = "Netherlands", Permitted = true },
                new Country { ID = 72, CountryName = "Bosnia and Herzegovina", Permitted = true },
                new Country { ID = 73, CountryName = "Bulgaria", Permitted = true },
                new Country { ID = 74, CountryName = "Belgium", Permitted = true },
                new Country { ID = 75, CountryName = "Belarus", Permitted = true },
                new Country { ID = 76, CountryName = "Portugal", Permitted = true },
                new Country { ID = 77, CountryName = "Poland", Permitted = true },
                new Country { ID = 78, CountryName = "France", Permitted = true },
                new Country { ID = 79, CountryName = "Finland", Permitted = true },
                new Country { ID = 80, CountryName = "Montenegro", Permitted = true },
                new Country { ID = 81, CountryName = "Moldova", Permitted = true },
                new Country { ID = 82, CountryName = "Malta", Permitted = true },
                new Country { ID = 83, CountryName = "Monaco", Permitted = true },
                new Country { ID = 84, CountryName = "Ukraine", Permitted = true },
                new Country { ID = 85, CountryName = "Germany", Permitted = true },
                new Country { ID = 86, CountryName = "Russia", Permitted = true },
                new Country { ID = 87, CountryName = "Romania", Permitted = true },
                new Country { ID = 88, CountryName = "Luxembourg", Permitted = true },
                new Country { ID = 89, CountryName = "Latvia", Permitted = true },
                new Country { ID = 90, CountryName = "Liechtenstein", Permitted = true },
                new Country { ID = 91, CountryName = "Lithuania", Permitted = true },
                new Country { ID = 92, CountryName = "Spain", Permitted = true },
                new Country { ID = 93, CountryName = "Slovakia", Permitted = true },
                new Country { ID = 94, CountryName = "Slovenia", Permitted = true },
                new Country { ID = 95, CountryName = "Switzerland", Permitted = true },
                new Country { ID = 96, CountryName = "Sweden", Permitted = true },
                new Country { ID = 97, CountryName = "United Kingdom", Permitted = true },
                new Country { ID = 98, CountryName = "Czech Republic", Permitted = true },
                new Country { ID = 99, CountryName = "Republic of Macedonia", Permitted = true },
                new Country { ID = 100, CountryName = "Austria", Permitted = true },
                new Country { ID = 101, CountryName = "Andorra", Permitted = true },
                new Country { ID = 102, CountryName = "Italy", Permitted = true },
                new Country { ID = 103, CountryName = "Estonia", Permitted = true },
                new Country { ID = 104, CountryName = "Albania", Permitted = true },
                new Country { ID = 105, CountryName = "Iceland", Permitted = true },
                new Country { ID = 106, CountryName = "Ireland", Permitted = true },
                new Country { ID = 107, CountryName = "Hungary", Permitted = true },
                new Country { ID = 108, CountryName = "Ghana", Permitted = true },
                new Country { ID = 109, CountryName = "Gabon", Permitted = true },
                new Country { ID = 110, CountryName = "Cabo Verde", Permitted = true },
                new Country { ID = 111, CountryName = "Guinea", Permitted = true },
                new Country { ID = 112, CountryName = "Guinea-Bissau", Permitted = true },
                new Country { ID = 113, CountryName = "The Gambia", Permitted = true },
                new Country { ID = 114, CountryName = "Côte d’Ivoire", Permitted = true },
                new Country { ID = 115, CountryName = "Comoros", Permitted = true },
                new Country { ID = 116, CountryName = "Kenya", Permitted = true },
                new Country { ID = 117, CountryName = "Cameroon", Permitted = true },
                new Country { ID = 118, CountryName = "Djibouti", Permitted = true },
                new Country { ID = 119, CountryName = "Chad", Permitted = true },
                new Country { ID = 120, CountryName = "Zimbabwe", Permitted = true },
                new Country { ID = 121, CountryName = "Sudan", Permitted = true },
                new Country { ID = 122, CountryName = "Seychelles", Permitted = true },
                new Country { ID = 123, CountryName = "Senegal", Permitted = true },
                new Country { ID = 124, CountryName = "São Tomé and Príncipe", Permitted = true },
                new Country { ID = 125, CountryName = "South Sudan", Permitted = true },
                new Country { ID = 126, CountryName = "Sierra Leone", Permitted = true },
                new Country { ID = 127, CountryName = "Zambia", Permitted = true },
                new Country { ID = 128, CountryName = "Somalia", Permitted = true },
                new Country { ID = 129, CountryName = "Tunisia", Permitted = true },
                new Country { ID = 130, CountryName = "Togo", Permitted = true },
                new Country { ID = 131, CountryName = "Tanzania", Permitted = true },
                new Country { ID = 132, CountryName = "Namibia", Permitted = true },
                new Country { ID = 133, CountryName = "Nigeria", Permitted = true },
                new Country { ID = 134, CountryName = "Niger", Permitted = true },
                new Country { ID = 135, CountryName = "Botswana", Permitted = true },
                new Country { ID = 136, CountryName = "Burundi", Permitted = true },
                new Country { ID = 137, CountryName = "Burkina Faso", Permitted = true },
                new Country { ID = 138, CountryName = "Benin", Permitted = true },
                new Country { ID = 139, CountryName = "Mauritius", Permitted = true },
                new Country { ID = 140, CountryName = "Mauritania", Permitted = true },
                new Country { ID = 141, CountryName = "Madagascar", Permitted = true },
                new Country { ID = 142, CountryName = "Malawi", Permitted = true },
                new Country { ID = 143, CountryName = "Mali", Permitted = true },
                new Country { ID = 144, CountryName = "Mozambique", Permitted = true },
                new Country { ID = 145, CountryName = "Morocco", Permitted = true },
                new Country { ID = 146, CountryName = "Uganda", Permitted = true },
                new Country { ID = 147, CountryName = "Rwanda", Permitted = true },
                new Country { ID = 148, CountryName = "Libya", Permitted = true },
                new Country { ID = 149, CountryName = "Lesotho", Permitted = true },
                new Country { ID = 150, CountryName = "Liberia", Permitted = true },
                new Country { ID = 151, CountryName = "Swaziland", Permitted = true },
                new Country { ID = 152, CountryName = "Republic of the Congo", Permitted = true },
                new Country { ID = 153, CountryName = "Democratic Republic of the Congo", Permitted = true },
                new Country { ID = 154, CountryName = "Central African Republic", Permitted = true },
                new Country { ID = 155, CountryName = "Equatorial Guinea", Permitted = true },
                new Country { ID = 156, CountryName = "Egypt", Permitted = true },
                new Country { ID = 157, CountryName = "Ethiopia", Permitted = true },
                new Country { ID = 158, CountryName = "Eritrea", Permitted = true },
                new Country { ID = 159, CountryName = "Angola", Permitted = true },
                new Country { ID = 160, CountryName = "South Africa", Permitted = true },
                new Country { ID = 161, CountryName = "Algeria", Permitted = true },
                new Country { ID = 162, CountryName = "Guatemala", Permitted = true },
                new Country { ID = 163, CountryName = "Grenada", Permitted = true },
                new Country { ID = 164, CountryName = "Costa Rica", Permitted = true },
                new Country { ID = 165, CountryName = "Cuba", Permitted = true },
                new Country { ID = 166, CountryName = "Canada", Permitted = true },
                new Country { ID = 167, CountryName = "Jamaica", Permitted = true },
                new Country { ID = 168, CountryName = "Saint Kitts and Nevis", Permitted = true },
                new Country { ID = 169, CountryName = "Saint Lucia", Permitted = true },
                new Country { ID = 170, CountryName = "Saint Vincent and the Grenadines", Permitted = true },
                new Country { ID = 171, CountryName = "Dominica", Permitted = true },
                new Country { ID = 172, CountryName = "Nicaragua", Permitted = true },
                new Country { ID = 173, CountryName = "Barbados", Permitted = true },
                new Country { ID = 174, CountryName = "Bahamas", Permitted = true },
                new Country { ID = 175, CountryName = "Belize", Permitted = true },
                new Country { ID = 176, CountryName = "Panama", Permitted = true },
                new Country { ID = 177, CountryName = "Mexico", Permitted = true },
                new Country { ID = 178, CountryName = "United States of America", Permitted = true },
                new Country { ID = 179, CountryName = "Dominican Republic", Permitted = true },
                new Country { ID = 180, CountryName = "El Salvador", Permitted = true },
                new Country { ID = 181, CountryName = "Antigua and Barbuda", Permitted = true },
                new Country { ID = 182, CountryName = "Honduras", Permitted = true },
                new Country { ID = 183, CountryName = "Haiti", Permitted = true },
                new Country { ID = 184, CountryName = "Guyana", Permitted = true },
                new Country { ID = 185, CountryName = "Colombia", Permitted = true },
                new Country { ID = 186, CountryName = "Chile", Permitted = true },
                new Country { ID = 187, CountryName = "Suriname", Permitted = true },
                new Country { ID = 188, CountryName = "Trinidad and Tobago", Permitted = true },
                new Country { ID = 189, CountryName = "Brazil", Permitted = true },
                new Country { ID = 190, CountryName = "Bolivia", Permitted = true },
                new Country { ID = 191, CountryName = "Paraguay", Permitted = true },
                new Country { ID = 192, CountryName = "Peru", Permitted = true },
                new Country { ID = 193, CountryName = "Venezuela", Permitted = true },
                new Country { ID = 194, CountryName = "Argentina", Permitted = true },
                new Country { ID = 195, CountryName = "Uruguay", Permitted = true },
                new Country { ID = 196, CountryName = "Ecuador", Permitted = true },
                new Country { ID = 197, CountryName = "South Ossetia", Permitted = true },
                new Country { ID = 198, CountryName = "Somaliland", Permitted = true },
                new Country { ID = 199, CountryName = "Northern Cyprus", Permitted = true },
                new Country { ID = 200, CountryName = "Taiwan", Permitted = true },
                new Country { ID = 201, CountryName = "Transnistria", Permitted = true },
                new Country { ID = 202, CountryName = "Nagorno-Karabakh", Permitted = true },
                new Country { ID = 203, CountryName = "Sahrawi Arab Democratic Republic", Permitted = true },
                new Country { ID = 204, CountryName = "Abkhazia", Permitted = true },
            });
        }
    }
}
