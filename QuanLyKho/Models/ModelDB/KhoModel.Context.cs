﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKho.Models.ModelDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KhoEntities : DbContext
    {
        public KhoEntities()
            : base("name=KhoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hang_Hoa> Hang_Hoa { get; set; }
        public virtual DbSet<Loai_SP> Loai_SP { get; set; }
        public virtual DbSet<Nha_Cung_Cap> Nha_Cung_Cap { get; set; }
        public virtual DbSet<Phieu_Nhap_Hang_Hoa> Phieu_Nhap_Hang_Hoa { get; set; }
        public virtual DbSet<Phieu_Xuat> Phieu_Xuat { get; set; }
        public virtual DbSet<Phieu_Xuat_Kho_Chua> Phieu_Xuat_Kho_Chua { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Table_Role> Table_Role { get; set; }
        public virtual DbSet<Table_User> Table_User { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Kho_Chua> Kho_Chua { get; set; }
        public virtual DbSet<Phieu_Nhap> Phieu_Nhap { get; set; }
    }
}
