//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANGHANH2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhiemVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhiemVu()
        {
            this.ChiTiet_NhiemVu_NhanVien = new HashSet<ChiTiet_NhiemVu_NhanVien>();
        }
    
        public string Loai { get; set; }
        public string TenNhiemVu { get; set; }
        public Nullable<int> MaBangCap { get; set; }
    
        public virtual BangCap BangCap { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTiet_NhiemVu_NhanVien> ChiTiet_NhiemVu_NhanVien { get; set; }
    }
}