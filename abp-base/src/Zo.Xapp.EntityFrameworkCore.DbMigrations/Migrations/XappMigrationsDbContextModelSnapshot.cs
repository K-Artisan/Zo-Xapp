﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;
using Zo.Xapp.EntityFrameworkCore;

namespace Zo.Xapp.Migrations
{
    [DbContext(typeof(XappMigrationsDbContext))]
    partial class XappMigrationsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.SqlServer)
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");
#pragma warning restore 612, 618
        }
    }
}
