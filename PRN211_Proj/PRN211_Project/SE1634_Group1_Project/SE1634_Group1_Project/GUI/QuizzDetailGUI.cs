using accomplied;
using Microsoft.EntityFrameworkCore;
using SE1634_Group1_Project.Models;

namespace SE1634_Group1_Project.GUI
{
    public partial class QuizzDetailGUI : Form
    {
        Quizz quizz;
        HappyQuizzContext quizzContext;
        public QuizzDetailGUI(Quizz _quizz)
        {
            InitializeComponent();
            quizz = _quizz;
            quizzContext = new HappyQuizzContext();
            setupLabel();
            var record = quizzContext.RecordQuizzs.FirstOrDefault(rc => rc.QuizzId == quizz.QuizzId && rc.UserId == Global.UserId);
            if(record!=null && !(bool)record.Status)
            {
                this.ResumeButton.Visible = true;
            } else
            {
                this.ResumeButton.Visible = false;
            }
        }

        private void setupLabel()
        {
            quizzContext = new HappyQuizzContext();
            TitleLabel.Text = quizz.Title;
            AuthorValue.Text = quizz.AuthorNavigation.UserName;
            QuestionsValue.Text = quizz.Questions.Count().ToString();
            var record = quizzContext.RecordQuizzs.FirstOrDefault(rc => rc.UserId == Global.UserId);
            if (record != null) { FinishedValue.Text = $"{record.Count} times"; MaxScoreValue.Text = $"{record.MaxScore}/{quizz.Questions.Count}"; }
            else { FinishedValue.Text = $"0 times"; MaxScoreValue.Text = $"0/{quizz.Questions.Count}"; }
            if (Global.UserId != -1)
            {
                FinishedLabel.Visible = true;
                FinishedValue.Visible = true;
                MaxScoreLabel.Visible = true;
                MaxScoreValue.Visible = true;
                RankButton.Visible = true;
            }
            else
            {
                FinishedLabel.Visible = false;
                FinishedValue.Visible = false;
                MaxScoreLabel.Visible = false;
                MaxScoreValue.Visible = false;
                RankButton.Visible = false;
                ResumeButton.Enabled = false;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            if (Global.UserId == -1)
            {
                MessageBox.Show("Please login to do quizz", "", MessageBoxButtons.OK);
            }
            else
            {
                var rcQuiz = quizzContext.RecordQuizzs.Include(rc => rc.ResumeQuestions).FirstOrDefault(q => q.QuizzId == quizz.QuizzId && q.UserId == Global.UserId);
                if(rcQuiz is not null)
                {
                    quizzContext.ResumeQuestions.RemoveRange(rcQuiz.ResumeQuestions);
                }
                DoQuizzGUI doQuizzGUI = new DoQuizzGUI(quizz, true);
                doQuizzGUI.TopLevel = false;
                doQuizzGUI.FormBorderStyle = FormBorderStyle.None;doQuizzGUI.FormClosed += DoQuizzClose; 
                doQuizzGUI.Show();

                Global.toolStripContainer.ContentPanel.Controls.Clear();
                Global.toolStripContainer.ContentPanel.Controls.Add(doQuizzGUI);
                
            }

        }
        private void DoQuizzClose(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RankButton_Click(object sender, EventArgs e)
        {
            RankGUI rank = new RankGUI(quizz);
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            DoQuizzGUI doQuizzGUI = new DoQuizzGUI(quizz, false);
            doQuizzGUI.TopLevel = false;
            doQuizzGUI.FormBorderStyle = FormBorderStyle.None; doQuizzGUI.FormClosed += DoQuizzClose;
            doQuizzGUI.Show();

            Global.toolStripContainer.ContentPanel.Controls.Clear();
            Global.toolStripContainer.ContentPanel.Controls.Add(doQuizzGUI);
        }
    }

}
