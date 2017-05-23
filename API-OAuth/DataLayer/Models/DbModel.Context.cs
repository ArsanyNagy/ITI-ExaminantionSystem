﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class DbContext : DbContext
    {
        public DbContext()
            : base("name=DbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseManual> CourseManual { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<InstructorCourse> InstructorCourse { get; set; }
        public DbSet<InstructorType> InstructorType { get; set; }
        public DbSet<Intake> Intake { get; set; }
        public DbSet<PlatfromIntake> PlatfromIntake { get; set; }
        public DbSet<ProgramIntake> ProgramIntake { get; set; }
        public DbSet<programs> programs { get; set; }
        public DbSet<StudentBasicData> StudentBasicData { get; set; }
        public DbSet<subTrack> subTrack { get; set; }
        public DbSet<TrackManager> TrackManager { get; set; }
        public DbSet<TrackSupervisor> TrackSupervisor { get; set; }
        public DbSet<TrainBranch> TrainBranch { get; set; }
        public DbSet<UserDevices> UserDevices { get; set; }
        public DbSet<DepartmentsExam> DepartmentsExam { get; set; }
        public DbSet<Exams> Exams { get; set; }
        public DbSet<ExternalInstructorAuthorization> ExternalInstructorAuthorization { get; set; }
        public DbSet<InstructorsConnectionIds> InstructorsConnectionIds { get; set; }
        public DbSet<NewDateExamForPermittedStudent> NewDateExamForPermittedStudent { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<QuestionAnswers> QuestionAnswers { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<QuestionsInExam> QuestionsInExam { get; set; }
        public DbSet<StudentAnswerQuestionInExam> StudentAnswerQuestionInExam { get; set; }
        public DbSet<StudentMultiAnswersQuestion> StudentMultiAnswersQuestion { get; set; }
        public DbSet<StudentPermissionInExam> StudentPermissionInExam { get; set; }
        public DbSet<StudentsConnectionIds> StudentsConnectionIds { get; set; }
        public DbSet<SupervisiorsConnectionIds> SupervisiorsConnectionIds { get; set; }
        public DbSet<TopicsInCourse> TopicsInCourse { get; set; }
    
        public virtual ObjectResult<GetEmployeeByBranch_Result> GetEmployeeByBranch(Nullable<int> branchID)
        {
            var branchIDParameter = branchID.HasValue ?
                new ObjectParameter("BranchID", branchID) :
                new ObjectParameter("BranchID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEmployeeByBranch_Result>("GetEmployeeByBranch", branchIDParameter);
        }
    }
}