using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class DataContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public Microsoft.EntityFrameworkCore.DbSet<AppUser> Users { get; set; }

    }
}
