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
    
    public partial class CT_PX_MH
    {
        public string IdPX { get; set; }
        public string IdMH { get; set; }
        public int IdVT { get; set; }
        public int IdHA { get; set; }
        public Nullable<int> SL { get; set; }
        public string Status { get; set; }
        public Nullable<double> ThanhTien { get; set; }
    
        public virtual HinhAnh HinhAnh { get; set; }
        public virtual MatHang MatHang { get; set; }
        public virtual PhieuXuat PhieuXuat { get; set; }
        public virtual VatTu VatTu { get; set; }
    }
}
