//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KlinikApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.Examinations = new HashSet<Examination>();
        }
    
        public int Pat_Id { get; set; }
        public string P_Lastname { get; set; }
        public string P_Firstname { get; set; }
        public Nullable<System.DateTime> P_Birthday { get; set; }
        public string P_Address { get; set; }
        public Nullable<int> P_Plz { get; set; }
        public string P_Bundesland { get; set; }
    
        public virtual Bundesland Bundesland { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Examination> Examinations { get; set; }
    }
}
