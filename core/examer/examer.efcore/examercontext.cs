using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using examer.entities.DTO;
using examer.efcore.Map;
using examer.entities;

namespace examer.efcore
{
    public class ExamerContext : DbContext
    {
        public ExamerContext()
        {

        }

        public ExamerContext(DbContextOptions<ExamerContext> contextOptions)
            : base(contextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<UserEntity>(new UserMap());
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            //并发控制
            var entities = this.ChangeTracker.Entries().Where(t => t.State == EntityState.Modified);

            foreach (var entity in entities)
            {
                var e = entity as IConcurrent;
                if (e != null)
                {
                    e.LastChanged++;
                }
            }

            return base.SaveChanges();
        }
    }
}
