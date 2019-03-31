﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using twolistapi;

namespace twolistapi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190331184208_AddedIsDueMonday")]
    partial class AddedIsDueMonday
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("TwoListAPI.Models.List", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateOfCompletion");

                    b.Property<bool>("IsDone");

                    b.Property<bool>("IsDueToday");

                    b.Property<string>("ListItem");

                    b.HasKey("Id");

                    b.ToTable("Lists");
                });
#pragma warning restore 612, 618
        }
    }
}
