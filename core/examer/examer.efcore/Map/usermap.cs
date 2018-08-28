using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using examer.entities;
using Microsoft.EntityFrameworkCore.ValueGeneration;
namespace examer.efcore.Map
{
    internal class usermap : IEntityTypeConfiguration<userentity>
    {
        public void Configure(EntityTypeBuilder<userentity> builder)
        {
            builder.HasKey(t => t.key);
            builder.Property(t => t.key).ValueGeneratedOnAdd().HasColumnName("user_id");
            builder.ToTable("user");
        }
    }
}
