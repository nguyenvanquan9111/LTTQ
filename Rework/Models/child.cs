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
    
    public partial class child
    {
        public int id { get; set; }
        public string name { get; set; }
        public string nickname { get; set; }
        public System.DateTime birthdate { get; set; }
        public Nullable<System.DateTime> enrolldate { get; set; }
        public bool sex { get; set; }
        public Nullable<int> id_condition { get; set; }
        public int id_parent { get; set; }
        public Nullable<int> id_class { get; set; }
    
        public virtual @class @class { get; set; }
        public virtual condition condition { get; set; }
        public virtual parent parent { get; set; }
    }
}
