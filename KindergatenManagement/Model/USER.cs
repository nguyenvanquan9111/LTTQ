//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KindergatenManagement.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER
    {
        public int ID { get; set; }
        public string DisplayName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int IDUserRoll { get; set; }
    
        public virtual UserRole UserRole { get; set; }
    }
}
