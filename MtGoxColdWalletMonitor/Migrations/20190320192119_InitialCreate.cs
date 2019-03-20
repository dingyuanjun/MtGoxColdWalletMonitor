using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MtGoxColdWalletMonitor.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WalletAddresses",
                columns: table => new
                {
                    WalletAddressId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Hash160Address = table.Column<string>(nullable: true),
                    LastKnownBalance = table.Column<decimal>(nullable: true),
                    LastCheckedDateTime = table.Column<DateTime>(nullable: true),
                    LastOperationDateTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletAddresses", x => x.WalletAddressId);
                });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 1, "12KkeeRkiNS13GMbg7zos9KRn9ggvZtZgx", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 58, "1HuPVqz2xvf1rdNFUqd62vRTyxP3jeX9Ch", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 57, "1Hm6XDmhKCHz68wDEYTapN9MEanke8iwUk", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 56, "1HdKXsNQtzDcfB6PGM7DWTgX9vhBWsz1ak", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 55, "1Hb8DmmvvtTYv5RBLuGtDxznkZwVpd5Vjy", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 54, "1H4K3dGfNbAN4AUfyUrpkGpjrd83sntDpV", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 53, "1GyDutntMuYyA2vQGW5HFcKLfx4cbDdbJq", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 52, "1GkZQcDy8V6pmHFZqUBUBCnN9dc2hoWasD", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 59, "1HweN9p41BY2RBunsPqyVuheEq7gVoxA9u", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 51, "1G23Uzwj55k2A9TRwaTknqGav66oDTkWCu", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 49, "1FrV9hv1AW34BGJvobJatyzUWYDWB9epRW", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 48, "1FhRuUkk8Bfx8FJDemtxhKAR4F8GCNKrXG", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 47, "1EK8vW7UYaYHKiW4TZmYJKtwcZLM14VjvP", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 46, "1EiiKCCnFgHjEvPZdu29qqgdBm8zTvpU3U", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 45, "1Drshi4RAuvxk4T6Bkq959ZvLbvy7b1wvD", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 44, "1DedUxzgwErg4ipNi988wPgLk5thwciKcc", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 43, "1CZsoJfkknbnW5fKrt1oR7N1ALE5WmDGP1", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 50, "1Fu4YgM3Y9CxvioGPqkSzkydAC8MVaPN1D", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 42, "1CRjKZJu8LvTutnSKq4zTJ4yiqrzMAArYW", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 60, "1HX4s3JeFU3x1eQgPNQVAdx6FoCtbb1hr8", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 62, "1JtgU6Uo1RAt5eiMf34EehyatUezBQP36C", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 78, "1Pq7hooZbEAz5y3QMnqFY8C5xqTdrjUwcA", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 77, "1NA3Tj4b1jtx9eGELe31Jw4DrzTqKP3ayH", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 76, "1N5X4kcZ56uRh24XrZoztS9Vb8G7j1Joop", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 75, "1MvpYtqgBH7CXbTutrSVCTNHPzm9vakuRy", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 74, "1MPJJzRaT8vLhowNB4dVyWRxxu79dq7WkB", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 73, "1Mm9brripN4RPTzkGnRrbt5uDWdqbfk2iX", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 72, "1MkyfwJf7uhWTmVGGQXfcT5ip31DoHMxsz", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 61, "1HzEPuenagLEWj68igDXBBXrzc293RuR5V", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 71, "1LzwbLgdKd4eFLkpRdeajkH1YJkVCip2zj", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 69, "1LueUjEuBgc7cQhsWT8zAfTjcWmrNBZXaR", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 68, "1LS5EFRRMDgMQusW6zokQUHjzNUfy6HHCQ", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 67, "1LLc8aA9C9LLULGbYCYSFKXgxKP2DXdCqP", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 66, "1KFDUSZuapMv7YaDmL6cyrHTQhma1MtFYs", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 65, "1JztCg7eKSkb1vi7NzGJynXpLZmoaFtYud", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 64, "1JVU43LNKXqa9W5fCh8tppxDDEWgfeNg46", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 63, "1JVmoJT3471FjsX5H4hAeR1RyrDgpkHbpm", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 70, "1LXi3x7hyt17cxncscGE887WCrC6XDNZ4P", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 41, "1C5aU4Xnpd3txbxehk46UZgiuNB8QdpHCH", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 40, "1BzK87zuqidZn489Wb2oLSktrjKrX7TLKe", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 39, "1BXyJc6BVuTFnHQCcjiWX2xmCPNVfaSZeb", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 17, "15U4VsmWG1cdXAtizvQsW4r7iMxzp64Tgu", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 16, "15SeCwVCFx5cWyrcdD1Zp1D1zxjH2SELPg", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 15, "15QcKCa84ZCHxbsqXDoKhi5XbmQB8jPEAd", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 14, "15kNZcrhxeFZgVVLK2Yjzd69tRidbFdJEZ", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 13, "156HpsWfgkWYLT63uhTAGUSUF3ZMnB9WWj", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 12, "155FsTtEFq4eGCcBxDseuwLKPbmtWbyHJR", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 11, "14USZ558Rr28AZwdJQyciSQkN4JT1cEoj2", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 18, "16jZZkMYqjUWUtQ9DfDvHdH5ko5BcnH9XQ", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 10, "14p4w3TRCd6NMRSnzTmgdvQhNnbrAmzXmy", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 8, "1439q4Na8v88kPBqoyg8F4ueL9SYr8ANWj", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 7, "13xGCc4TPSYY9GYxBGVNox82KxyjkFnxMX", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 6, "13Wv5hGhubAWgSPWtXYh6s1s7HX2N1psYg", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 5, "13sXfpp2V16nnxYvW9FHHoBdMa3k98uJw8", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 4, "13dXFMyG22EsUsvaWhCqUo7SXuX7rBPog6", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 3, "13ahgw8sM95EDbugT3tdb8TYoMU46Uw7PX", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 2, "12T4oSNd4t9ty9fodgNd47TWhK35pAxDYN", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 9, "14mP6caC5dFhHdVAPCjPKM8Nm36MBDR5pM", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 19, "16W4XcUAKPmSES9MiUCio28msSCp8rDZgs", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 20, "16w6sZBDP58yyeyZAcvnxcEGJpwR9amM6g", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 21, "17etv2L3nhk6SCcWSNW4eoZkBy84izAm17", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 38, "1BDZBTb4KE5oq6wAgA6EvAe3uCFRrAbPao", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 37, "1B6kJM75iu5ty1HAHMMz6tT1HhjoGNTCa9", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 36, "1AZu7TQmKBAes2duNDctYwjAB9nhHczUnA", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 35, "1Ar6meJQCkNoC9wnPcyRNNpzX5fBDaGcKd", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 34, "19KiFrafXEyJCUDYFEv3B6tBUwyfFo7kNU", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 33, "19eihBKk6e5YD2QXAe4SVUsxRLLnTDKsfv", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 32, "19Cr4zXpKw43xLJhFZW9iv4DDNtQk2TDeB", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 31, "19c8sUa54yQuRTVDfJa3iDkkCaFkzBJLPB", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 30, "199Yxz2TJGtND3QKsHTptTJivqSaUZBvku", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 29, "195HvmjXgoF3M5vFaBC8swZPhwrE7VhxRD", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 28, "18YDgRhxsomuBZ1g9d8Y1JuRmxDhF8Bvff", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 27, "18ok25NTkdrUzdByFJCNVsqVYkujZ8aP45", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 26, "18M1Z337NqLtK9V69bssnQUYsvb7hmfSFS", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 25, "18KDS3q6a4YV9Nn8jcyMvNoVPfcrfemeag", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 24, "18hcZVFPqDNAovJmb9vA6hEJrDz6uWXNGh", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 23, "17Tf4bVQaCzwWrDWGRPC97RLCHnU4LY8Qr", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 22, "17KcBp8g76Ue8pywgjta4q8Ds6wK4bEKp7", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 79, "1PRXQEoL8vzEzoJJ9hbtAP6NaV2daccAUn", null, null, null });

            migrationBuilder.InsertData(
                table: "WalletAddresses",
                columns: new[] { "WalletAddressId", "Hash160Address", "LastCheckedDateTime", "LastKnownBalance", "LastOperationDateTime" },
                values: new object[] { 80, "1PxGTuJzDx1ceFHx4Z5CHaWuhiPBNovmZD", null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WalletAddresses");
        }
    }
}
