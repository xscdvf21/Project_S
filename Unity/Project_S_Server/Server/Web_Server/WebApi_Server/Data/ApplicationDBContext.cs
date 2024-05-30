using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedData.Models;
namespace WebApi_Server.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<UserInfo> users{ get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            :base(options)
        {
            
        }
    }
}
