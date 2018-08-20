using System;
using System.Data.Entity;

namespace WebApplication3.Models
{
    public class Search
    {
        public int ID { get; set; }
        public string word { get; set; }
    }

    public class SearchDBContext : DbContext
    {
        public DbSet<Search> Searchs { get; set; }
    }
}