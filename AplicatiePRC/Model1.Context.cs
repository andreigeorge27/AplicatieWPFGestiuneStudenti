﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicatiePRC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Baza_de_date_StudentiEntities1 : DbContext
    {
        public Baza_de_date_StudentiEntities1()
            : base("name=Baza_de_date_StudentiEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Cont> Cont { get; set; }
        public DbSet<Curs> Curs { get; set; }
        public DbSet<Facultate> Facultate { get; set; }
        public DbSet<FormaInvatamant> FormaInvatamant { get; set; }
        public DbSet<Nota> Nota { get; set; }
        public DbSet<Specializare> Specializare { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}