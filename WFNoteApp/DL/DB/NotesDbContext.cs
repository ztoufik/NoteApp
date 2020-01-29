using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFNoteApp.DL.DB
{
    public class NotesDbContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string DbFilePath = Path.Combine(Directory.GetCurrentDirectory(), @"NotesDb.db");
            optionsBuilder.UseSqlite($"Data Source = {DbFilePath}");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
