//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SATProject.DATA.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.ScheduledClasses = new HashSet<ScheduledClass>();
        }
    
        public int CoursesId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public byte CreditHours { get; set; }
        public string Curriculum { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScheduledClass> ScheduledClasses { get; set; }
    }
}
