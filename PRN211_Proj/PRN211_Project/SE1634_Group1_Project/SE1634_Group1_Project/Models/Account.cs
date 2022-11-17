using System;
using System.Collections.Generic;

namespace SE1634_Group1_Project.Models
{
    public partial class Account
    {
        public Account()
        {
            Quizzs = new HashSet<Quizz>();
            RecordQuizzs = new HashSet<RecordQuizz>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Role { get; set; }

        public virtual ICollection<Quizz> Quizzs { get; set; }
        public virtual ICollection<RecordQuizz> RecordQuizzs { get; set; }
    }
}
