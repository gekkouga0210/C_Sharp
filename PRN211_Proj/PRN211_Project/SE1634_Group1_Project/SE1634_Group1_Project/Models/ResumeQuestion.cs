using System;
using System.Collections.Generic;

namespace SE1634_Group1_Project.Models
{
    public partial class ResumeQuestion
    {
        public int ResumeQuestionId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public int? RecordQuizzId { get; set; }

        public virtual RecordQuizz? RecordQuizz { get; set; }
    }
}
