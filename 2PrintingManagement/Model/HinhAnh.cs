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
    
    public partial class HinhAnh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HinhAnh()
        {
            this.CT_PX_MH = new HashSet<CT_PX_MH>();
            this.MatHangs = new HashSet<MatHang>();
        }
    
        public int IdHA { get; set; }
        public string MaSoHinh { get; set; }
        public string HinhAnh1 { get; set; }
        public int IdKH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PX_MH> CT_PX_MH { get; set; }
        public virtual KH KH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatHang> MatHangs { get; set; }
    }
}
