using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Server.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<UserInfo> userInfo { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
