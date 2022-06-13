using System;
using EduHome_BE.Models;
using Microsoft.EntityFrameworkCore;

namespace EduHome_BE.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<PageIntro> PageIntros { get; set; }
    }
}
