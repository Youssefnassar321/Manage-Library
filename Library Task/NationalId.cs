//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Task
{
    using System;
    using System.Collections.Generic;
    
    public partial class NationalId
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int NationalId1 { get; set; }
        public string title { get; set; }
    
        public virtual Book Book { get; set; }
    }
}
