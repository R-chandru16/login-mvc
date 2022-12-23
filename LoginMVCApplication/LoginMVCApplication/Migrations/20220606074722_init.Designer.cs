﻿// <auto-generated />
using LoginMVCApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoginMVCApplication.Migrations
{
    [DbContext(typeof(LoginContext))]
    [Migration("20220606074722_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LoginMVCApplication.Models.Users", b =>
                {
                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmailID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            EmailID = "demogmail.com",
                            Password = "demo"
                        },
                        new
                        {
                            EmailID = "chandru@gmail.com",
                            Password = "chandru2598"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}