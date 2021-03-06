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
    
    public partial class Question
    {
        public Question()
        {
            this.QuestionAnswers = new HashSet<QuestionAnswer>();
            this.QuestionsInExams = new HashSet<QuestionsInExam>();
            this.StudentMultiAnswersQuestions = new HashSet<StudentMultiAnswersQuestion>();
            this.Questions1 = new HashSet<Question>();
            this.Questions = new HashSet<Question>();
        }
    
        public int Ques_Id { get; set; }
        public int Ques_Type { get; set; }
        public string Ques_Content { get; set; }
        public Nullable<bool> Ques_Activation { get; set; }
        public Nullable<int> Ques_Level { get; set; }
        public Nullable<int> Ques_Repetation { get; set; }
        public Nullable<int> Topic_Id { get; set; }
        public Nullable<int> Ins_Id { get; set; }
        public Nullable<bool> Points_Indicator { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
        public virtual TopicsInCourse TopicsInCourse { get; set; }
        public virtual ICollection<QuestionsInExam> QuestionsInExams { get; set; }
        public virtual ICollection<StudentMultiAnswersQuestion> StudentMultiAnswersQuestions { get; set; }
        public virtual ICollection<Question> Questions1 { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
