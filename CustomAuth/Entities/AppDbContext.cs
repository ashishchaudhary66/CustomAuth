﻿using Microsoft.EntityFrameworkCore;

namespace CustomAuth.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<UserAccount> UserAccounts { get; set; }
    }
}