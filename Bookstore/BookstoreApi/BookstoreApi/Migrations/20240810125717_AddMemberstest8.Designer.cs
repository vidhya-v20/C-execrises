﻿// <auto-generated />
using System;
using BookstoreApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookstoreApi.Migrations
{
    [DbContext(typeof(BookstoreContext))]
    [Migration("20240810125717_AddMemberstest8")]
    partial class AddMemberstest8
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookstoreApi.Models.Author", b =>
                {
                    b.Property<int>("author_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("author_id"));

                    b.Property<string>("biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("author_id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            author_id = 1,
                            biography = "British author, best known for the Harry Potter series.",
                            name = "J.K. Rowling"
                        },
                        new
                        {
                            author_id = 2,
                            biography = "American novelist and short story writer, known for A Song of Ice and Fire.",
                            name = "George R.R. Martin"
                        });
                });

            modelBuilder.Entity("BookstoreApi.Models.Book", b =>
                {
                    b.Property<int>("book_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("book_id"));

                    b.Property<int>("author_id")
                        .HasColumnType("int");

                    b.Property<int>("genre_id")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("publication_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("book_id");

                    b.HasIndex("author_id");

                    b.HasIndex("genre_id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            book_id = 1,
                            author_id = 1,
                            genre_id = 1,
                            image = "harry-potter.jpg",
                            price = 19.99m,
                            publication_date = new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            title = "Harry Potter and the Sorcerer's Stone"
                        },
                        new
                        {
                            book_id = 2,
                            author_id = 2,
                            genre_id = 1,
                            image = "game-of-thrones.jpg",
                            price = 15.99m,
                            publication_date = new DateTime(1996, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            title = "A Game of Thrones"
                        });
                });

            modelBuilder.Entity("Genre", b =>
                {
                    b.Property<int>("genre_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("genre_id"));

                    b.Property<string>("genre_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("genre_id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            genre_id = 1,
                            genre_name = "Fantasy"
                        },
                        new
                        {
                            genre_id = 2,
                            genre_name = "Science Fiction"
                        });
                });

            modelBuilder.Entity("BookstoreApi.Models.Book", b =>
                {
                    b.HasOne("BookstoreApi.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("author_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("genre_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BookstoreApi.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Genre", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
