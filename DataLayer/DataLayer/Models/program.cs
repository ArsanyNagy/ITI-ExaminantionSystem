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
    
    public partial class program
    {
        public program()
        {
            this.ProgramIntakes = new HashSet<ProgramIntake>();
        }
    
        public int programId { get; set; }
        public string programName { get; set; }
        public string programnotes { get; set; }
    
        public virtual ICollection<ProgramIntake> ProgramIntakes { get; set; }
    }
}
