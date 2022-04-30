﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransportationService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ServiceDBEntities : DbContext
    {
        public ServiceDBEntities()
            : base("name=ServiceDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Drivers> Drivers { get; set; }
        public virtual DbSet<Licenses> Licenses { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Transports> Transports { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Vehicle_types> Vehicle_types { get; set; }
        public virtual DbSet<Vehicles> Vehicles { get; set; }
    
        public virtual ObjectResult<LogIn_Result> LogIn(string login)
        {
            var loginParameter = login != null ?
                new ObjectParameter("Login", login) :
                new ObjectParameter("Login", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LogIn_Result>("LogIn", loginParameter);
        }
    }
}
