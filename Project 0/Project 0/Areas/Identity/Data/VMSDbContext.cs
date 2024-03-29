﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_0.Areas.Identity.Data;
using Project_0.Models;

namespace Project_0.Data
{
    public class VMSDbContext : IdentityDbContext<VMSUser>
    {
        public VMSDbContext(DbContextOptions<VMSDbContext> options)
            : base(options)
        {
        }
        //public DbSet<Volunteer> Volunteers { get; set; }
        //public DbSet<Opportunity> Opportunities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
