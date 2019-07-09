﻿// <auto-generated />
using System;
using AmateurLeague;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AmateurLeague.Migrations
{
    [DbContext(typeof(AmateurLeagueContext))]
    partial class AmateurLeagueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AmateurLeague.League", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100);

                    b.Property<string>("SportId")
                        .IsRequired();

                    b.HasKey("Name")
                        .HasName("PK_Leagues");

                    b.HasIndex("SportId");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("AmateurLeague.Player", b =>
                {
                    b.Property<string>("EmailAddress")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("EmailAddress")
                        .HasName("PK_Players");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("AmateurLeague.Sport", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Type");

                    b.HasKey("Id")
                        .HasName("PK_Sports");

                    b.ToTable("Sports");
                });

            modelBuilder.Entity("AmateurLeague.Team", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100);

                    b.Property<string>("LeagueName")
                        .IsRequired();

                    b.HasKey("Name")
                        .HasName("PK_Teams");

                    b.HasIndex("LeagueName");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("AmateurLeague.TeamPlayer", b =>
                {
                    b.Property<string>("TeamId");

                    b.Property<string>("PlayerId");

                    b.HasKey("TeamId", "PlayerId");

                    b.HasIndex("PlayerId");

                    b.ToTable("TeamPlayer");
                });

            modelBuilder.Entity("AmateurLeague.League", b =>
                {
                    b.HasOne("AmateurLeague.Sport", "Sport")
                        .WithMany("Leagues")
                        .HasForeignKey("SportId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AmateurLeague.Team", b =>
                {
                    b.HasOne("AmateurLeague.League", "League")
                        .WithMany("Teams")
                        .HasForeignKey("LeagueName")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AmateurLeague.TeamPlayer", b =>
                {
                    b.HasOne("AmateurLeague.Player", "Player")
                        .WithMany("TeamPlayers")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AmateurLeague.Team", "Team")
                        .WithMany("TeamPlayers")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
