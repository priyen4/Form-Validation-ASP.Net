using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment02.Models;

namespace Assignmnent2.Models
{
    public class Assignmnent2Context : DbContext
    {
        public Assignmnent2Context (DbContextOptions<Assignmnent2Context> options)
            : base(options)
        {
        }

        public DbSet<Assignment02.Models.Member> Member { get; set; }
    }
}
