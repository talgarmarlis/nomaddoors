﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nomaddoors
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_A095E6_nomaddoorsEntities : DbContext
    {
        public DB_A095E6_nomaddoorsEntities()
            : base("name=DB_A095E6_nomaddoorsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Join> Joins { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Subtitle> Subtitles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
