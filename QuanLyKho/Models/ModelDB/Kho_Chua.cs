//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Kho_Chua
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kho_Chua()
        {
            this.Phieu_Xuat_Kho_Chua = new HashSet<Phieu_Xuat_Kho_Chua>();
            this.Phieu_Nhap_Hang_Hoa = new HashSet<Phieu_Nhap_Hang_Hoa>();
        }
    
        public int Hang_Hoa_Id { get; set; }
        public Nullable<int> So_Luong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_Xuat_Kho_Chua> Phieu_Xuat_Kho_Chua { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_Nhap_Hang_Hoa> Phieu_Nhap_Hang_Hoa { get; set; }
    }
}
