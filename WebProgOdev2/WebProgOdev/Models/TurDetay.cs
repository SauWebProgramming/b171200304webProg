//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebProgOdev.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TurDetay
    {
        public int turDetayId { get; set; }
        public Nullable<int> familyaId { get; set; }
        public string turDetay1 { get; set; }
        public string dikimYeri { get; set; }
        public string toprak { get; set; }
        public string buyumeHizi { get; set; }
        public string resim { get; set; }
    
        public virtual Familyalar Familyalar { get; set; }
    }
}
