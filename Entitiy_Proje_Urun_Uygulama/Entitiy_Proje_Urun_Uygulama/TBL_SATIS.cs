//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entitiy_Proje_Urun_Uygulama
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_SATIS
    {
        public int SATISID { get; set; }
        public Nullable<int> URUN { get; set; }
        public Nullable<int> MUSTERI { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
    
        public virtual TBL_MUSTERI TBL_MUSTERI { get; set; }
        public virtual TBL_URUN TBL_URUN { get; set; }
    }
}
