//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKhachSan
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiPhong()
        {
            this.PhongKS = new HashSet<PhongKS>();
            this.TienNghiPhongs = new HashSet<TienNghiPhong>();
        }
    
        public string LoaiPhong1 { get; set; }
        public Nullable<int> DonGia { get; set; }
        public Nullable<int> DienTich { get; set; }
        public string KieuPhong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhongKS> PhongKS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TienNghiPhong> TienNghiPhongs { get; set; }
    }
}
