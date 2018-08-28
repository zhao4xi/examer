using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using examer.entities.DTO;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace examer.efcore.Map
{
    internal class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(t => t.Key);

            builder.Property(t => t.Key).HasColumnName("User_ID").ValueGeneratedOnAdd();

            builder.Property(t => t.Create_Date).ValueGeneratedOnAdd().HasDefaultValueSql("NOW()").HasColumnType("Datetime");

            builder.Property(t => t.User_Code).HasMaxLength(20).IsUnicode().IsRequired();

            builder.HasIndex(t => t.User_Code).IsUnique();

            builder.Property(t => t.User_Name).IsRequired().HasMaxLength(50);

            builder.Property(t => t.Update_Date).HasColumnType("Datetime");

            builder.ToTable("User", "examer");
        }
    }
}
