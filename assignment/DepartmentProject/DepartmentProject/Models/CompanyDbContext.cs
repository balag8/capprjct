using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DepartmentProject.Models
{
    public class CompanyDbContext:DbContext
    {
        public DbSet<Dept> Depts { get; set; }
    

        public CompanyDbContext()
        {

        }
        public CompanyDbContext(DbContextOptions options):base(options)
        {

        }
    }
}
