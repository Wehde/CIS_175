﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlympicGames.Models;

#nullable disable

namespace OlympicGames.Migrations
{
    [DbContext(typeof(CountryContext))]
    partial class CountryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OlympicGames.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "IN",
                            Name = "Indoor"
                        },
                        new
                        {
                            CategoryId = "OUT",
                            Name = "Outdoor"
                        });
                });

            modelBuilder.Entity("OlympicGames.Models.Country", b =>
                {
                    b.Property<string>("CountryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FlagUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("GameId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = "CAN",
                            CategoryId = "IN",
                            FlagUrl = "canada.png",
                            GameId = "WINTER",
                            Name = "Canada",
                            Sport = "Curling"
                        },
                        new
                        {
                            CountryId = "SWE",
                            CategoryId = "IN",
                            FlagUrl = "sweden.png",
                            GameId = "WINTER",
                            Name = "Sweden",
                            Sport = "Curling"
                        },
                        new
                        {
                            CountryId = "GBR",
                            CategoryId = "IN",
                            FlagUrl = "united-kingdom.png",
                            GameId = "WINTER",
                            Name = "Great Britian",
                            Sport = "Curling"
                        },
                        new
                        {
                            CountryId = "JAM",
                            CategoryId = "OUT",
                            FlagUrl = "jamaica.png",
                            GameId = "WINTER",
                            Name = "Jamaica",
                            Sport = "Bobsleigh"
                        },
                        new
                        {
                            CountryId = "ITA",
                            CategoryId = "OUT",
                            FlagUrl = "italy.png",
                            GameId = "WINTER",
                            Name = "Italy",
                            Sport = "Bobsleigh"
                        },
                        new
                        {
                            CountryId = "JPN",
                            CategoryId = "OUT",
                            FlagUrl = "japan.png",
                            GameId = "WINTER",
                            Name = "Japan",
                            Sport = "Bobsleigh"
                        },
                        new
                        {
                            CountryId = "DEU",
                            CategoryId = "IN",
                            FlagUrl = "germany.png",
                            GameId = "SUMMER",
                            Name = "Germany",
                            Sport = "Diving"
                        },
                        new
                        {
                            CountryId = "CHN",
                            CategoryId = "IN",
                            FlagUrl = "china.png",
                            GameId = "SUMMER",
                            Name = "China",
                            Sport = "Diving"
                        },
                        new
                        {
                            CountryId = "MEX",
                            CategoryId = "IN",
                            FlagUrl = "mexico.png",
                            GameId = "SUMMER",
                            Name = "Mexico",
                            Sport = "Diving"
                        },
                        new
                        {
                            CountryId = "BRA",
                            CategoryId = "OUT",
                            FlagUrl = "brazil.png",
                            GameId = "SUMMER",
                            Name = "Brazil",
                            Sport = "Road Cycling"
                        },
                        new
                        {
                            CountryId = "NLD",
                            CategoryId = "OUT",
                            FlagUrl = "netherlands.png",
                            GameId = "SUMMER",
                            Name = "Netherlands",
                            Sport = "Road Cycling"
                        },
                        new
                        {
                            CountryId = "USA",
                            CategoryId = "OUT",
                            FlagUrl = "united-states-of-america.png",
                            GameId = "SUMMER",
                            Name = "United States of America",
                            Sport = "Road Cycling"
                        },
                        new
                        {
                            CountryId = "THA",
                            CategoryId = "IN",
                            FlagUrl = "thailand.png",
                            GameId = "PARA",
                            Name = "Thailand",
                            Sport = "Archery"
                        },
                        new
                        {
                            CountryId = "URY",
                            CategoryId = "IN",
                            FlagUrl = "uruguay.png",
                            GameId = "PARA",
                            Name = "Uruguay",
                            Sport = "Archery"
                        },
                        new
                        {
                            CountryId = "UKR",
                            CategoryId = "IN",
                            FlagUrl = "ukraine.png",
                            GameId = "PARA",
                            Name = "Ukraine",
                            Sport = "Archery"
                        },
                        new
                        {
                            CountryId = "AUT",
                            CategoryId = "OUT",
                            FlagUrl = "austria.png",
                            GameId = "PARA",
                            Name = "Austria",
                            Sport = "Canoe Sprint"
                        },
                        new
                        {
                            CountryId = "PAK",
                            CategoryId = "OUT",
                            FlagUrl = "pakistan.png",
                            GameId = "PARA",
                            Name = "Pakistan",
                            Sport = "Canoe Sprint"
                        },
                        new
                        {
                            CountryId = "ZWE",
                            CategoryId = "OUT",
                            FlagUrl = "zimbabwe.png",
                            GameId = "PARA",
                            Name = "Zimbabwe",
                            Sport = "Canoe Sprint"
                        },
                        new
                        {
                            CountryId = "FRA",
                            CategoryId = "IN",
                            FlagUrl = "france.png",
                            GameId = "YOUTH",
                            Name = "France",
                            Sport = "Breakdancing"
                        },
                        new
                        {
                            CountryId = "CYP",
                            CategoryId = "IN",
                            FlagUrl = "cyprus.png",
                            GameId = "YOUTH",
                            Name = "Cyprus",
                            Sport = "Breakdancing"
                        },
                        new
                        {
                            CountryId = "RUS",
                            CategoryId = "IN",
                            FlagUrl = "russia.png",
                            GameId = "YOUTH",
                            Name = "Russia",
                            Sport = "Breakdancing"
                        },
                        new
                        {
                            CountryId = "FIN",
                            CategoryId = "OUT",
                            FlagUrl = "finland.png",
                            GameId = "YOUTH",
                            Name = "Finland",
                            Sport = "Skateboarding"
                        },
                        new
                        {
                            CountryId = "SVK",
                            CategoryId = "OUT",
                            FlagUrl = "slovakia.png",
                            GameId = "YOUTH",
                            Name = "Slovakia",
                            Sport = "Skateboarding"
                        },
                        new
                        {
                            CountryId = "PRT",
                            CategoryId = "OUT",
                            FlagUrl = "portugal.png",
                            GameId = "YOUTH",
                            Name = "Portugal",
                            Sport = "Skateboarding"
                        });
                });

            modelBuilder.Entity("OlympicGames.Models.Game", b =>
                {
                    b.Property<string>("GameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = "WINTER",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            GameId = "SUMMER",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            GameId = "PARA",
                            Name = "Paralympics"
                        },
                        new
                        {
                            GameId = "YOUTH",
                            Name = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("OlympicGames.Models.Country", b =>
                {
                    b.HasOne("OlympicGames.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OlympicGames.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.Navigation("Category");

                    b.Navigation("Game");
                });
#pragma warning restore 612, 618
        }
    }
}
