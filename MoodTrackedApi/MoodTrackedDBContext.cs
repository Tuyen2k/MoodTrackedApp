using Microsoft.EntityFrameworkCore;
using MoodTrackedLib.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodTrackedLib {
    public class MoodTrackedDBContext : DbContext {
        public MoodTrackedDBContext(DbContextOptions<MoodTrackedDBContext> options)
            : base(options) {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Diary> Diaries { get; set; }
    }

}
