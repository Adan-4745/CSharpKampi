//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpEgitimKampi301.EFProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblguide
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblguide()
        {
            this.tbllocation = new HashSet<tbllocation>();
        }
    
        public int guideid { get; set; }
        public string guidename { get; set; }
        public string guidesurname { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbllocation> tbllocation { get; set; }
    }
}
