﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DatabaseManager
{
    public partial class PriceCompareDataBaseEntities : DbContext
    {
        public PriceCompareDataBaseEntities()
            : base("name=PriceCompareDataBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
    }
}
