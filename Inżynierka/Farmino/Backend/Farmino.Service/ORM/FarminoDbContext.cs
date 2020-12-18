﻿using Farmino.Data.Models.Aggregations;
using Farmino.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Farmino.Service.ORM
{
    public class FarminoDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public FarminoDbContext(DbContextOptions<FarminoDbContext> options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Profile>(x =>
            {
                x.OwnsOne(y => y.Address, z =>
                {
                    z.Property(q => q.City).HasColumnName("City");
                    z.Property(q => q.HouseNumber).HasColumnName("HouseNumber");
                    z.Property(q => q.PostalCode).HasColumnName("PostalCode");
                    z.Property(q => q.Street).HasColumnName("Street");
                });
            });
        }
    }
}
