//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKhoPhongVu
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.DanhSachSanPhams = new HashSet<DanhSachSanPham>();
        }
    
        public long id { get; set; }
        public string tenSanPham { get; set; }
        public Nullable<double> gia { get; set; }
        public Nullable<int> soLuong { get; set; }
        public string maVach { get; set; }
        public string dvt { get; set; }
        public Nullable<int> baoHanh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhSachSanPham> DanhSachSanPhams { get; set; }
    }
}
