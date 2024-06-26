﻿// <auto-generated />
using System;
using Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240417084428_CreateInitilize")]
    partial class CreateInitilize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entity.Anime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int?>("CommentId")
                        .HasColumnType("int");

                    b.Property<int>("DateOfSsue")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CommentId");

                    b.HasIndex("GenreId");

                    b.ToTable("Anime");
                });

            modelBuilder.Entity("Domain.Entity.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("YearOfDirth")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Domain.Entity.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Domain.Entity.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Domain.Entity.Manga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DateOfSsue")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.ToTable("Manga");
                });

            modelBuilder.Entity("Domain.Entity.Reading", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<int>("MangaId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("MangaId");

                    b.HasIndex("UserId");

                    b.ToTable("Reading");
                });

            modelBuilder.Entity("Domain.Entity.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnimeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantities")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("SeriesQuantities")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnimeId");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("Domain.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entity.Vewing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnimeId")
                        .HasColumnType("int");

                    b.Property<int>("CommentsId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnimeId");

                    b.HasIndex("CommentsId");

                    b.HasIndex("UserId");

                    b.ToTable("Vewing");
                });

            modelBuilder.Entity("Domain.Entity.Volume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChaptersQuantities")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("MandaId")
                        .HasColumnType("int");

                    b.Property<int>("Quantities")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MandaId");

                    b.ToTable("Volumes");
                });

            modelBuilder.Entity("Domain.Entity.Anime", b =>
                {
                    b.HasOne("Domain.Entity.Author", "Author")
                        .WithMany("Animes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.Comment", null)
                        .WithMany("Animes")
                        .HasForeignKey("CommentId");

                    b.HasOne("Domain.Entity.Genre", "Genre")
                        .WithMany("Animes")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Domain.Entity.Manga", b =>
                {
                    b.HasOne("Domain.Entity.Author", "Author")
                        .WithMany("Mangas")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.Genre", "Genre")
                        .WithMany("Mangas")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Domain.Entity.Reading", b =>
                {
                    b.HasOne("Domain.Entity.Comment", "Comment")
                        .WithMany("Readings")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.Manga", "Manga")
                        .WithMany("Readings")
                        .HasForeignKey("MangaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.User", "User")
                        .WithMany("Readings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("Manga");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entity.Season", b =>
                {
                    b.HasOne("Domain.Entity.Anime", "Animes")
                        .WithMany("Seasons")
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animes");
                });

            modelBuilder.Entity("Domain.Entity.Vewing", b =>
                {
                    b.HasOne("Domain.Entity.Anime", "Animes")
                        .WithMany("Vewings")
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.Comment", "Comment")
                        .WithMany("Vewings")
                        .HasForeignKey("CommentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.User", "User")
                        .WithMany("Vewings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animes");

                    b.Navigation("Comment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entity.Volume", b =>
                {
                    b.HasOne("Domain.Entity.Manga", "Manga")
                        .WithMany("Volumes")
                        .HasForeignKey("MandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manga");
                });

            modelBuilder.Entity("Domain.Entity.Anime", b =>
                {
                    b.Navigation("Seasons");

                    b.Navigation("Vewings");
                });

            modelBuilder.Entity("Domain.Entity.Author", b =>
                {
                    b.Navigation("Animes");

                    b.Navigation("Mangas");
                });

            modelBuilder.Entity("Domain.Entity.Comment", b =>
                {
                    b.Navigation("Animes");

                    b.Navigation("Readings");

                    b.Navigation("Vewings");
                });

            modelBuilder.Entity("Domain.Entity.Genre", b =>
                {
                    b.Navigation("Animes");

                    b.Navigation("Mangas");
                });

            modelBuilder.Entity("Domain.Entity.Manga", b =>
                {
                    b.Navigation("Readings");

                    b.Navigation("Volumes");
                });

            modelBuilder.Entity("Domain.Entity.User", b =>
                {
                    b.Navigation("Readings");

                    b.Navigation("Vewings");
                });
#pragma warning restore 612, 618
        }
    }
}
