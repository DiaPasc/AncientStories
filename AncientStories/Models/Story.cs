using System;
using System.Data.Entity;

namespace AncientStories.Models
{
    public class Story
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Civilization { get; set; }
        public string Period { get; set; }  
        public string Description { get; set; }
    }

    public class StoryDBContext : DbContext
    {
        public DbSet<Story> Stories { get; set; }
    }
}


