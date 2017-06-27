using EscaliTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EscaliTest.DataAccess
{
    public class EscaliDb : DbContext
    {
        public EscaliDb()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(new SeqAsIdConvention());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<tblSecurity> Securities { get; set; }
    }
}