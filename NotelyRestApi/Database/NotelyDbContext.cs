using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotelyRestApi.Models;

namespace NotelyRestApi.Database
{
    public class NotelyDbContext :DbContext
    {
        public NotelyDbContext(DbContextOptions<NotelyDbContext> options) : base(options){ }
        public DbSet<Note> Notes { get; set; } 
    }
}
