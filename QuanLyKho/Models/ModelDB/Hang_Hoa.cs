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
    
    public partial class Hang_Hoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hang_Hoa()
        {
            this.Phieu_Nhap_Hang_Hoa = new HashSet<Phieu_Nhap_Hang_Hoa>();
        }
    
        public int Hang_Hoa_Id { get; set; }
        public Nullable<int> Ma_Loai { get; set; }
        public Nullable<decimal> Don_Gia { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Loai_SP Loai_SP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_Nhap_Hang_Hoa> Phieu_Nhap_Hang_Hoa { get; set; }
    }
}
