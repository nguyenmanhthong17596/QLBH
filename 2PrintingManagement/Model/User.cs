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
    
    public partial class User
    {
        public int IdUser { get; set; }
        public string HoTen { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IdRoles { get; set; }
    
        public virtual UserRole UserRole { get; set; }
    }
}
