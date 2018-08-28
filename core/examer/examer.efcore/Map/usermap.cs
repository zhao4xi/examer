using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using examer.entities;
namespace examer.efcore.Map
{
    internal class usermap : IEntityTypeConfiguration<userentity>
    {
        public void Configure(EntityTypeBuilder<userentity> builder)
        {
            builder.HasKey(t => t.key).HasName("user_id");
            builder.Property(t => t.key).ValueGeneratedOnAdd();
            builder.ToTable("user");
        }
    }
}
