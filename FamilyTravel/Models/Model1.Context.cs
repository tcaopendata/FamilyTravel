﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShareTravel.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class openTCLEntities : DbContext
    {
        public openTCLEntities()
            : base("name=openTCLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ShareTravelPackage> ShareTravelPackage { get; set; }
        public virtual DbSet<ShareTravelPlace> ShareTravelPlace { get; set; }
        public virtual DbSet<CWDUVI> CWDUVI { get; set; }
        public virtual DbSet<CWDWeatherDescription> CWDWeatherDescription { get; set; }
        public virtual DbSet<CWBCityRegionLocation> CWBCityRegionLocation { get; set; }
        public virtual DbSet<EPAAQI> EPAAQI { get; set; }
        public virtual DbSet<EPACityRegionLocation> EPACityRegionLocation { get; set; }
        public virtual DbSet<AllFeedingRoom> AllFeedingRoom { get; set; }
    }
}
