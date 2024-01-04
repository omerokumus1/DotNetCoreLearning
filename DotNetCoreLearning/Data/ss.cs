using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotNetCoreLearning.Models;

    public class ss : DbContext
    {
        public ss (DbContextOptions<ss> options)
            : base(options)
        {
        }

        public DbSet<DotNetCoreLearning.Models.Product> Product { get; set; } = default!;
    }
