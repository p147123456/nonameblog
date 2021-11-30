﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nonameblog.Models;

namespace Nonameblog.Migrations
{
    [DbContext(typeof(NonameblogContext))]
    [Migration("20190909053251_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Nonameblog.Models.Artcile", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorID");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(3000);

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Tittle")
                        .IsRequired();

                    b.Property<int>("Type");

                    b.HasKey("ID");

                    b.ToTable("Artcile");
                });

            modelBuilder.Entity("Nonameblog.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CommentTime");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("PKID");

                    b.HasKey("ID");

                    b.ToTable("Comment");
                });
#pragma warning restore 612, 618
        }
    }
}
