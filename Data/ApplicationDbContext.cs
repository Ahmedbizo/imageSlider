using System;
using Microsoft.EntityFrameworkCore;
using FeaturedImageGallery.Models;

namespace FeaturedImageGallery.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        // All the required Dbsets entities
        public DbSet<Gallery> Galleries { get; set; }

        public DbSet<GalleryImage> GalleryImages { get; set; }

    }
}