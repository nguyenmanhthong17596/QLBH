//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2PrintingManagement.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatHang()
        {
            this.CT_PX_MH = new HashSet<CT_PX_MH>();
        }
    
        public string IdMH { get; set; }
        public string TenMH { get; set; }
        public Nullable<double> Gia { get; set; }
        public Nullable<double> GiaCu { get; set; }
        public string DVT { get; set; }
        public int IdVT { get; set; }
        public int IdHA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PX_MH> CT_PX_MH { get; set; }
        public virtual HinhAnh HinhAnh { get; set; }
        public virtual VatTu VatTu { get; set; }
    }
}