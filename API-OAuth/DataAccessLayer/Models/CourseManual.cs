//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseManual
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CourseManual()
        {
            this.EvaluationCriterias = new HashSet<EvaluationCriteria>();
            this.TrackManuals = new HashSet<TrackManual>();
        }
    
        public int courseManualID { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> totalGrade { get; set; }
        public Nullable<int> minGrade { get; set; }
        public Nullable<int> labsNumber { get; set; }
        public Nullable<int> lecturesNumber { get; set; }
        public Nullable<int> lech { get; set; }
        public Nullable<int> selfh { get; set; }
        public Nullable<int> labh { get; set; }
        public Nullable<int> credit { get; set; }
        public string coursenote { get; set; }
        public string swReq { get; set; }
        public string hwReq { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public string CourseObjective { get; set; }
        public string CourseContent { get; set; }
        public Nullable<int> ProgramIntakeID { get; set; }
    
        public virtual Course Course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvaluationCriteria> EvaluationCriterias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackManual> TrackManuals { get; set; }
    }
}