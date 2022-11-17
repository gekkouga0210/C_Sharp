using System;
using System.Collections.Generic;

namespace SE1634_Group1_Project.Models
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        public int QuestionId { get; set; }
        public string Text { get; set; } = null!;
        public int? QuizzId { get; set; }

        public virtual Quizz? Quizz { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
