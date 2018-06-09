﻿// <auto-generated />
using Kiddo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kiddo.Migrations
{
    [DbContext(typeof(KiddoContext))]
    partial class KiddoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kiddo.Models.Requisitador", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contacto");

                    b.Property<string>("Email");

                    b.Property<string>("Foto");

                    b.Property<string>("Localizacao");

                    b.Property<string>("Nome");

                    b.Property<string>("Pagamento");

                    b.Property<string>("Password");

                    b.HasKey("ID");

                    b.ToTable("Requisitador");
                });
#pragma warning restore 612, 618
        }
    }
}
