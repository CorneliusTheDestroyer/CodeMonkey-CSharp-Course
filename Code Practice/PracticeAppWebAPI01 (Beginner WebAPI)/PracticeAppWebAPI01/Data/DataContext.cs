﻿using Microsoft.EntityFrameworkCore;
using PracticeAppWebAPI01.Entities;

namespace PracticeAppWebAPI01.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
