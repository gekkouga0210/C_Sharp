using Microsoft.EntityFrameworkCore;
using SE1634_Group1_Project.Models;
using System.Data;

namespace SE1634_Group1_Project.GUI
{
    public partial class DoQuizzGUI : Form
    {
        Quizz quizz;
        HappyQuizzContext quizzContext;
        PageList<Question> pageList;
        IQueryable<Question> questions;
        MyCheckbox lastChecked;
        List<ResumeQuestion> questionAnswered;
        bool isNew;
        public DoQuizzGUI(Quizz _quizz, bool isNew)
        {
            questionAnswered = new List<ResumeQuestion>();
            InitializeComponent();
            quizz = _quizz;
            this.isNew = isNew;
            quizzContext = new HappyQuizzContext();
            questions = quizzContext.Questions
                .Where(a => a.QuizzId == quizz.QuizzId).Include(a => a.Answers);
            var checkLastRecord = quizzContext.RecordQuizzs.Include(rc => rc.ResumeQuestions).FirstOrDefault(rc => rc.QuizzId == quizz.QuizzId && rc.UserId == Global.UserId);
            if (checkLastRecord != null)
            {
                checkLastRecord.LastTime = DateTime.Now;
                checkLastRecord.Status = false;
                quizzContext.RecordQuizzs.Update(checkLastRecord);
                if (!isNew) questionAnswered = checkLastRecord.ResumeQuestions.ToList();
            }
            else
            {
                RecordQuizz rcNew = new RecordQuizz();
                rcNew.QuizzId = quizz.QuizzId;
                rcNew.LastTime = DateTime.Now;
                rcNew.UserId = Global.UserId;
                rcNew.Status = false;
                rcNew.MaxScore = 0;
                rcNew.Count = 0;
                var RcQizzAdded = quizzContext.RecordQuizzs.Add(rcNew).Entity;
            }

            quizzContext.SaveChanges();
            TitleLabel.Text = quizz.Title;

            bindData(1);

        }

        private void bindData(int pageIndex)
        {
            QuestionsLable.Text = pageIndex.ToString() + "/" + questions.Count().ToString();

            pageList = PageList<Question>.Create(questions, pageIndex, 1);

            PreviousButton.Enabled = pageList.HasPreviousPage;
            NextButton.Enabled = pageList.HasNextPage;

            groupBox2.Controls.Clear();

            foreach (Question question in pageList)
            {
                Label lblquestion = new Label();
                lblquestion.AutoSize = true;
                lblquestion.Text = question.Text;
                lblquestion.Location = new Point(10, 20);
                groupBox2.Controls.Add(lblquestion);

                groupBox1.Controls.Clear();
                int i = 1;
                foreach (Answer answer in question.Answers)
                {
                    MyCheckbox lblcheckbox = new MyCheckbox();
                    lblcheckbox.AutoSize = true;
                    lblcheckbox.answer = answer;
                    lblcheckbox.Text = answer.Text;
                    lblcheckbox.Click += CheckboxClickHandler;
                    lblcheckbox.Location = new Point(10, i * 30);
                    int answerId = answer.AnswerId;
                    if (questionAnswered.Find(c => c.AnswerId == answerId) != null) { lblcheckbox.Checked = true; lastChecked = lblcheckbox; }

                    groupBox1.Controls.Add(lblcheckbox);
                    i++;
                }
            }
        }
        async void CheckboxClickHandler(object sender, EventArgs args)
        {
            MyCheckbox activeCheckBox = (sender as MyCheckbox);
            if (lastChecked != null && activeCheckBox.answer.QuestionId==lastChecked.answer.QuestionId && activeCheckBox != lastChecked)
            {
                lastChecked.Checked = false;
                var toRemove = lastChecked.answer;
                var resumeRemove = quizzContext.ResumeQuestions.FirstOrDefault(rq => rq.QuestionId == toRemove.QuestionId && rq.AnswerId == toRemove.AnswerId);
                quizzContext.ResumeQuestions.Remove(resumeRemove);
                quizzContext.SaveChanges();
            }

            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;

            Answer ans = activeCheckBox.answer;
            ResumeQuestion nowAnswer;
            bool nowAnswerNew = false;
            var answered = questionAnswered.Find(c => c.AnswerId == ans.AnswerId);
            if (answered != null)
            {
                nowAnswerNew = false;
                nowAnswer = answered;
                questionAnswered[questionAnswered.IndexOf(answered)].AnswerId = ans.AnswerId;
            }
            else
            {
                var recordQuizz = quizzContext.RecordQuizzs.FirstOrDefault(q => q.QuizzId == quizz.QuizzId && q.UserId == Global.UserId);
                nowAnswerNew = true;
                nowAnswer = new ResumeQuestion();
                nowAnswer.AnswerId = ans.AnswerId;
                nowAnswer.QuestionId = (int)ans.QuestionId;
                nowAnswer.RecordQuizzId = recordQuizz.RecordQuizzId;
                questionAnswered.Add(nowAnswer);
            }
            if (nowAnswerNew) quizzContext.ResumeQuestions.Add(nowAnswer);
            else quizzContext.ResumeQuestions.Update(nowAnswer);
            quizzContext.SaveChanges();


        }
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            bindData(pageList.PageIndex - 1);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            bindData(pageList.PageIndex + 1);
        }

        private void DoQuizzGUI_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var answerlist = new List<Answer>();
            int count = 0;
            foreach (var ans in questionAnswered)
            {
                if ((bool)quizzContext.Answers.Find(ans.AnswerId).IsCorrect) count++;
            }
            var rc = quizzContext.RecordQuizzs.FirstOrDefault(r => r.QuizzId == quizz.QuizzId && r.UserId == Global.UserId);
            if (rc.Count == null) rc.Count = 0;
            if (rc.MaxScore == null) rc.MaxScore = 0;
            rc.LastTime = DateTime.Now;
            rc.MaxScore = count > rc.MaxScore ? count : rc.MaxScore;
            rc.Count += 1;
            rc.Status = true;
            quizzContext.RecordQuizzs.Update(rc);
            if (questionAnswered.Count > 0)
            {
                quizzContext.ResumeQuestions.RemoveRange(questionAnswered);
            }
            quizzContext.SaveChanges();
            this.Close();
            MessageBox.Show($"Your score is {count}/{questions.Count()}", "You are submmited", MessageBoxButtons.OK);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
