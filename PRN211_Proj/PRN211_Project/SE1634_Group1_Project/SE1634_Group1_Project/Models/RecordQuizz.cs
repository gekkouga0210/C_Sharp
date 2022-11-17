using System;
using System.Collections.Generic;

namespace SE1634_Group1_Project.Models
{
    public partial class RecordQuizz
    {
        public RecordQuizz()
        {
            ResumeQuestions = new HashSet<ResumeQuestion>();
        }

        public int RecordQuizzId { get; set; }
        public DateTime? LastTime { get; set; }
        public int? Count { get; set; }
        public int? MaxScore { get; set; }
        public bool? Status { get; set; }
        public int? UserId { get; set; }
        public int? QuizzId { get; set; }

        public virtual Quizz? Quizz { get; set; }
        public virtual Account? User { get; set; }
        public virtual ICollection<ResumeQuestion> ResumeQuestions { get; set; }
    }
}
