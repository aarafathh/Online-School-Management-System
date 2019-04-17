//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineSchool.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SUBJECT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUBJECT()
        {
            this.ATTENDANCEs = new HashSet<ATTENDANCE>();
            this.RESULTs = new HashSet<RESULT>();
        }
    
        public int Subject_ID { get; set; }
        public string SubjectName { get; set; }
        public int Class_ID { get; set; }
        public int Teacher_ID { get; set; }
        public int Admin_ID { get; set; }
    
        public virtual ADMIN ADMIN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTENDANCE> ATTENDANCEs { get; set; }
        public virtual CLASS CLASS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESULT> RESULTs { get; set; }
        public virtual TEACHER TEACHER { get; set; }
    }
}