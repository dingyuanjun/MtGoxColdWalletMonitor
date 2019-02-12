using Microsoft.EntityFrameworkCore;
using MtGoxColdWalletMonitor.Model.Dtos;

namespace MtGoxColdWalletMonitor.Model
{
    public class MtGoxAddressesContext : DbContext
    {
        public DbSet<WalletAddress> WalletAddresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mtgox_wallet_addresses.db");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WalletAddress>().HasData(new[] {
                new { WalletAddressId = 1, Hash160Address = "12KkeeRkiNS13GMbg7zos9KRn9ggvZtZgx" },
                new { WalletAddressId = 2, Hash160Address = "12T4oSNd4t9ty9fodgNd47TWhK35pAxDYN" },
                new { WalletAddressId = 3, Hash160Address = "13ahgw8sM95EDbugT3tdb8TYoMU46Uw7PX" },
                new { WalletAddressId = 4, Hash160Address = "13dXFMyG22EsUsvaWhCqUo7SXuX7rBPog6" },
                new { WalletAddressId = 5, Hash160Address = "13sXfpp2V16nnxYvW9FHHoBdMa3k98uJw8" },
                new { WalletAddressId = 6, Hash160Address = "13Wv5hGhubAWgSPWtXYh6s1s7HX2N1psYg" },
                new { WalletAddressId = 7, Hash160Address = "13xGCc4TPSYY9GYxBGVNox82KxyjkFnxMX" },
                new { WalletAddressId = 8, Hash160Address = "1439q4Na8v88kPBqoyg8F4ueL9SYr8ANWj" },
                new { WalletAddressId = 9, Hash160Address = "14mP6caC5dFhHdVAPCjPKM8Nm36MBDR5pM" },
                new { WalletAddressId = 10, Hash160Address = "14p4w3TRCd6NMRSnzTmgdvQhNnbrAmzXmy" },
                new { WalletAddressId = 11, Hash160Address = "14USZ558Rr28AZwdJQyciSQkN4JT1cEoj2" },
                new { WalletAddressId = 12, Hash160Address = "155FsTtEFq4eGCcBxDseuwLKPbmtWbyHJR" },
                new { WalletAddressId = 13, Hash160Address = "156HpsWfgkWYLT63uhTAGUSUF3ZMnB9WWj" },
                new { WalletAddressId = 14, Hash160Address = "15kNZcrhxeFZgVVLK2Yjzd69tRidbFdJEZ" },
                new { WalletAddressId = 15, Hash160Address = "15QcKCa84ZCHxbsqXDoKhi5XbmQB8jPEAd" },
                new { WalletAddressId = 16, Hash160Address = "15SeCwVCFx5cWyrcdD1Zp1D1zxjH2SELPg" },
                new { WalletAddressId = 17, Hash160Address = "15U4VsmWG1cdXAtizvQsW4r7iMxzp64Tgu" },
                new { WalletAddressId = 18, Hash160Address = "16jZZkMYqjUWUtQ9DfDvHdH5ko5BcnH9XQ" },
                new { WalletAddressId = 19, Hash160Address = "16W4XcUAKPmSES9MiUCio28msSCp8rDZgs" },
                new { WalletAddressId = 20, Hash160Address = "16w6sZBDP58yyeyZAcvnxcEGJpwR9amM6g" },
                new { WalletAddressId = 21, Hash160Address = "17etv2L3nhk6SCcWSNW4eoZkBy84izAm17" },
                new { WalletAddressId = 22, Hash160Address = "17KcBp8g76Ue8pywgjta4q8Ds6wK4bEKp7" },
                new { WalletAddressId = 23, Hash160Address = "17Tf4bVQaCzwWrDWGRPC97RLCHnU4LY8Qr" },
                new { WalletAddressId = 24, Hash160Address = "18hcZVFPqDNAovJmb9vA6hEJrDz6uWXNGh" },
                new { WalletAddressId = 25, Hash160Address = "18KDS3q6a4YV9Nn8jcyMvNoVPfcrfemeag" },
                new { WalletAddressId = 26, Hash160Address = "18M1Z337NqLtK9V69bssnQUYsvb7hmfSFS" },
                new { WalletAddressId = 27, Hash160Address = "18ok25NTkdrUzdByFJCNVsqVYkujZ8aP45" },
                new { WalletAddressId = 28, Hash160Address = "18YDgRhxsomuBZ1g9d8Y1JuRmxDhF8Bvff" },
                new { WalletAddressId = 29, Hash160Address = "195HvmjXgoF3M5vFaBC8swZPhwrE7VhxRD" },
                new { WalletAddressId = 30, Hash160Address = "199Yxz2TJGtND3QKsHTptTJivqSaUZBvku" },
                new { WalletAddressId = 31, Hash160Address = "19c8sUa54yQuRTVDfJa3iDkkCaFkzBJLPB" },
                new { WalletAddressId = 32, Hash160Address = "19Cr4zXpKw43xLJhFZW9iv4DDNtQk2TDeB" },
                new { WalletAddressId = 33, Hash160Address = "19eihBKk6e5YD2QXAe4SVUsxRLLnTDKsfv" },
                new { WalletAddressId = 34, Hash160Address = "19KiFrafXEyJCUDYFEv3B6tBUwyfFo7kNU" },
                new { WalletAddressId = 35, Hash160Address = "1Ar6meJQCkNoC9wnPcyRNNpzX5fBDaGcKd" },
                new { WalletAddressId = 36, Hash160Address = "1AZu7TQmKBAes2duNDctYwjAB9nhHczUnA" },
                new { WalletAddressId = 37, Hash160Address = "1B6kJM75iu5ty1HAHMMz6tT1HhjoGNTCa9" },
                new { WalletAddressId = 38, Hash160Address = "1BDZBTb4KE5oq6wAgA6EvAe3uCFRrAbPao" },
                new { WalletAddressId = 39, Hash160Address = "1BXyJc6BVuTFnHQCcjiWX2xmCPNVfaSZeb" },
                new { WalletAddressId = 40, Hash160Address = "1BzK87zuqidZn489Wb2oLSktrjKrX7TLKe" },
                new { WalletAddressId = 41, Hash160Address = "1C5aU4Xnpd3txbxehk46UZgiuNB8QdpHCH" },
                new { WalletAddressId = 42, Hash160Address = "1CRjKZJu8LvTutnSKq4zTJ4yiqrzMAArYW" },
                new { WalletAddressId = 43, Hash160Address = "1CZsoJfkknbnW5fKrt1oR7N1ALE5WmDGP1" },
                new { WalletAddressId = 44, Hash160Address = "1DedUxzgwErg4ipNi988wPgLk5thwciKcc" },
                new { WalletAddressId = 45, Hash160Address = "1Drshi4RAuvxk4T6Bkq959ZvLbvy7b1wvD" },
                new { WalletAddressId = 46, Hash160Address = "1EiiKCCnFgHjEvPZdu29qqgdBm8zTvpU3U" },
                new { WalletAddressId = 47, Hash160Address = "1EK8vW7UYaYHKiW4TZmYJKtwcZLM14VjvP" },
                new { WalletAddressId = 48, Hash160Address = "1FhRuUkk8Bfx8FJDemtxhKAR4F8GCNKrXG" },
                new { WalletAddressId = 49, Hash160Address = "1FrV9hv1AW34BGJvobJatyzUWYDWB9epRW" },
                new { WalletAddressId = 50, Hash160Address = "1Fu4YgM3Y9CxvioGPqkSzkydAC8MVaPN1D" },
                new { WalletAddressId = 51, Hash160Address = "1G23Uzwj55k2A9TRwaTknqGav66oDTkWCu" },
                new { WalletAddressId = 52, Hash160Address = "1GkZQcDy8V6pmHFZqUBUBCnN9dc2hoWasD" },
                new { WalletAddressId = 53, Hash160Address = "1GyDutntMuYyA2vQGW5HFcKLfx4cbDdbJq" },
                new { WalletAddressId = 54, Hash160Address = "1H4K3dGfNbAN4AUfyUrpkGpjrd83sntDpV" },
                new { WalletAddressId = 55, Hash160Address = "1Hb8DmmvvtTYv5RBLuGtDxznkZwVpd5Vjy" },
                new { WalletAddressId = 56, Hash160Address = "1HdKXsNQtzDcfB6PGM7DWTgX9vhBWsz1ak" },
                new { WalletAddressId = 57, Hash160Address = "1Hm6XDmhKCHz68wDEYTapN9MEanke8iwUk" },
                new { WalletAddressId = 58, Hash160Address = "1HuPVqz2xvf1rdNFUqd62vRTyxP3jeX9Ch" },
                new { WalletAddressId = 59, Hash160Address = "1HweN9p41BY2RBunsPqyVuheEq7gVoxA9u" },
                new { WalletAddressId = 60, Hash160Address = "1HX4s3JeFU3x1eQgPNQVAdx6FoCtbb1hr8" },
                new { WalletAddressId = 61, Hash160Address = "1HzEPuenagLEWj68igDXBBXrzc293RuR5V" },
                new { WalletAddressId = 62, Hash160Address = "1JtgU6Uo1RAt5eiMf34EehyatUezBQP36C" },
                new { WalletAddressId = 63, Hash160Address = "1JVmoJT3471FjsX5H4hAeR1RyrDgpkHbpm" },
                new { WalletAddressId = 64, Hash160Address = "1JVU43LNKXqa9W5fCh8tppxDDEWgfeNg46" },
                new { WalletAddressId = 65, Hash160Address = "1JztCg7eKSkb1vi7NzGJynXpLZmoaFtYud" },
                new { WalletAddressId = 66, Hash160Address = "1KFDUSZuapMv7YaDmL6cyrHTQhma1MtFYs" },
                new { WalletAddressId = 67, Hash160Address = "1LLc8aA9C9LLULGbYCYSFKXgxKP2DXdCqP" },
                new { WalletAddressId = 68, Hash160Address = "1LS5EFRRMDgMQusW6zokQUHjzNUfy6HHCQ" },
                new { WalletAddressId = 69, Hash160Address = "1LueUjEuBgc7cQhsWT8zAfTjcWmrNBZXaR" },
                new { WalletAddressId = 70, Hash160Address = "1LXi3x7hyt17cxncscGE887WCrC6XDNZ4P" },
                new { WalletAddressId = 71, Hash160Address = "1LzwbLgdKd4eFLkpRdeajkH1YJkVCip2zj" },
                new { WalletAddressId = 72, Hash160Address = "1MkyfwJf7uhWTmVGGQXfcT5ip31DoHMxsz" },
                new { WalletAddressId = 73, Hash160Address = "1Mm9brripN4RPTzkGnRrbt5uDWdqbfk2iX" },
                new { WalletAddressId = 74, Hash160Address = "1MPJJzRaT8vLhowNB4dVyWRxxu79dq7WkB" },
                new { WalletAddressId = 75, Hash160Address = "1MvpYtqgBH7CXbTutrSVCTNHPzm9vakuRy" },
                new { WalletAddressId = 76, Hash160Address = "1N5X4kcZ56uRh24XrZoztS9Vb8G7j1Joop" },
                new { WalletAddressId = 77, Hash160Address = "1NA3Tj4b1jtx9eGELe31Jw4DrzTqKP3ayH" },
                new { WalletAddressId = 78, Hash160Address = "1Pq7hooZbEAz5y3QMnqFY8C5xqTdrjUwcA" },
                new { WalletAddressId = 79, Hash160Address = "1PRXQEoL8vzEzoJJ9hbtAP6NaV2daccAUn" },
                new { WalletAddressId = 80, Hash160Address = "1PxGTuJzDx1ceFHx4Z5CHaWuhiPBNovmZD" }
            });
        }
    }
}