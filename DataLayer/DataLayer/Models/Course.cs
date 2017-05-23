//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public Course()
        {
            this.CourseManuals = new HashSet<CourseManual>();
            this.TopicsInCourses = new HashSet<TopicsInCourse>();
        }
    
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public Nullable<int> CategoryID { get; set; }
    
        public virtual ICollection<CourseManual> CourseManuals { get; set; }
        public virtual ICollection<TopicsInCourse> TopicsInCourses { get; set; }
    }
}
