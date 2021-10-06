using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HoangTrungThong774.Models;

namespace HoangTrungThong774.Data 
{
     public class ApplictionContext : DbContext
    {
        public ApplictionContext (DbContextOptions<ApplictionContext> options)
            : base(options)
        {
        }

        public DbSet<HoangTrungThong774.Models.PersonHTT774> PersonHTT774 { get; set; }

        public DbSet<HoangTrungThong774.Models.HTT0774> HTT0774 { get; set; }
    }
}
   
