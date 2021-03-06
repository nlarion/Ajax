using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Ajax.Models;

namespace Ajax.Migrations
{
    [DbContext(typeof(AjaxContext))]
    [Migration("20160503225625_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ajax.Models.Destination", b =>
                {
                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<int>("Id");

                    b.HasKey("City");

                    b.HasAnnotation("Relational:TableName", "Destinations");
                });
        }
    }
}
