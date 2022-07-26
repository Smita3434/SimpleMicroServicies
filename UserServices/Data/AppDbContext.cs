using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserServices.Entities;

namespace UserServices.Data
{
        public class AppDbContext : DbContext
        {
            public DbSet<Users> Users { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=LAPTOP-6IR2U05V\SQLEXPRESS01;Database=ReinSolutionADO.Net];Integrated Security=True;");
            }
        }

    
}
