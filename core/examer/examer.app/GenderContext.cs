using System;
using System.Collections.Generic;
using System.Text;
using examer.efcore;
using Microsoft.EntityFrameworkCore;

namespace examer.app
{
    public class GenderContext : ExamerContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Data Source=localhost;database=Examer;user=root;password=2793751");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
