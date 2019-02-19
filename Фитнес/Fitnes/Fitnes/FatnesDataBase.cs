using Fitnes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnes
{
   public  class FatnesDataBase : DbContext
   {
        private readonly string _schema;

        public FatnesDataBase(string schema) : base("DatabaseConnectionString")
        {
            _schema = schema;
        }

        public DbSet<Day> Days { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.HasDefaultSchema(_schema);
            base.OnModelCreating(builder);
        }
   }
}
