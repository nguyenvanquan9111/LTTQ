//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rework.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class teaching
    {
        public int id { get; set; }
        public Nullable<int> id_teacher { get; set; }
        public Nullable<int> id_class { get; set; }
    
        public virtual @class @class { get; set; }
        public virtual teacher teacher { get; set; }
    }
}
