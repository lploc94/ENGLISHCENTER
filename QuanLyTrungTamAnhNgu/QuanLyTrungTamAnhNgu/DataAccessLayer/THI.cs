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
    
    public partial class THI
    {
        public string MAHV { get; set; }
        public string MAKT { get; set; }
        public string MALOP { get; set; }
        public int MAPHONG { get; set; }
        public Nullable<System.DateTime> NGAYTHI { get; set; }
        public Nullable<int> DIEMTHI { get; set; }
        public Nullable<int> KETQUA { get; set; }
    
        public virtual HOCVIEN HOCVIEN { get; set; }
        public virtual KIEMTRA KIEMTRA { get; set; }
        public virtual LOPHOC LOPHOC { get; set; }
        public virtual PHONGHOC PHONGHOC { get; set; }
    }
}
