using System;
using System.Collections.Generic;

namespace SE1634_Group1_Project.Models
{
    public partial class Quizz
    {
        public Quizz()
        {
            Questions = new HashSet<Question>();
            RecordQuizzs = new HashSet<RecordQuizz>();
        }

        public int QuizzId { get; set; }
        public string Title { get; set; } = null!;
        public int? Author { get; set; }

        public virtual Account? AuthorNavigation { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<RecordQuizz> RecordQuizzs { get; set; }
    }
}
