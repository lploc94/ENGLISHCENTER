﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLTTEntities : DbContext
    {
        public QLTTEntities()
            : base("name=QLTTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GIANGVIEN> GIANGVIENs { get; set; }
        public virtual DbSet<HOCPHI> HOCPHIs { get; set; }
        public virtual DbSet<HOCVIEN> HOCVIENs { get; set; }
        public virtual DbSet<KHOAHOC> KHOAHOCs { get; set; }
        public virtual DbSet<KIEMTRA> KIEMTRAs { get; set; }
        public virtual DbSet<LICHHOC> LICHHOCs { get; set; }
        public virtual DbSet<LOPHOC> LOPHOCs { get; set; }
        public virtual DbSet<PHONGHOC> PHONGHOCs { get; set; }
        public virtual DbSet<THI> THIs { get; set; }
        public virtual DbSet<THONGTINHOCPHI> THONGTINHOCPHIs { get; set; }
        public virtual DbSet<TKB> TKBs { get; set; }
        public virtual DbSet<TT_LUONGGV> TT_LUONGGV { get; set; }
        public virtual DbSet<THAMSO> THAMSOes { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHANQUYEN> PHANQUYENs { get; set; }
    }
}
