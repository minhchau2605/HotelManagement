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
    
    public partial class TienNghiPhong
    {
        public string LoaiPhong { get; set; }
        public string MaTN { get; set; }
        public Nullable<int> SoLuongTN { get; set; }
    
        public virtual TienNghi TienNghi { get; set; }
        public virtual LoaiPhong LoaiPhong1 { get; set; }
    }
}
