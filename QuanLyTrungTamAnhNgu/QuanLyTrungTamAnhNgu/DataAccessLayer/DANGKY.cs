//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class DANGKY
    {
        public string MAHV { get; set; }
        public string MAKH { get; set; }
        public string MALOP { get; set; }
    
        public virtual HOCVIEN HOCVIEN { get; set; }
        public virtual KHOAHOC KHOAHOC { get; set; }
        public virtual LOPHOC LOPHOC { get; set; }
    }
}
