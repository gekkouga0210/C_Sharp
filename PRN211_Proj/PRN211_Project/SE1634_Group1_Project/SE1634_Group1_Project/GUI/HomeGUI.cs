using Microsoft.EntityFrameworkCore;
using SE1634_Group1_Project.Models;
using System.Data;

namespace SE1634_Group1_Project.GUI
{
    public partial class HomeGUI : Form
    {
        HappyQuizzContext context;
        PageList<Quizz> pageList;
        public HomeGUI(bool isResume)
        {
            InitializeComponent();
            context = new HappyQuizzContext();
            bindPanel(1, isResume);
        }

        private void bindPanel(int pageIndex, bool isResume = false)
        {
            context = new HappyQuizzContext();
            IQueryable<Quizz> quizzs;
            
            if (isResume)
            {
                var rcq = context.RecordQuizzs
                    .Where(rc => rc.UserId == Global.UserId && rc.Status == false).Select(rq => rq.QuizzId).ToList();
                var quiz = context.Quizzs.Where(q => rcq.Contains(q.QuizzId)).Where(a => a.Title.Contains(TitleValue.Text.Trim())).Include(a => a.AuthorNavigation).Include(a => a.Questions);
                quizzs = quiz;

            }
            else
            {
                quizzs = context.Quizzs.Where(a => a.Title.Contains(TitleValue.Text.Trim())).Include(a => a.AuthorNavigation).Include(a => a.Questions);

            }
            pageList = PageList<Quizz>.Create(quizzs, pageIndex, 3);
            PreviousButton.Enabled = pageList.HasPreviousPage;
            NextButton.Enabled = pageList.HasNextPage;

            panel1.Controls.Clear();
            int height = panel1.Height - 20;
            int width = (panel1.Width - 40) / 3;
            int i = 0;

            foreach (Quizz quizz in pageList)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Height = height;
                groupBox.Width = width;
                groupBox.Location = new Point(10 + i * (width + 10), 10);

                Label lbltitle = new Label();
                lbltitle.AutoSize = true;
                lbltitle.Text = quizz.Title;
                lbltitle.Location = new Point(10, 0);
                groupBox.Controls.Add(lbltitle);

                Label lblauthor = new Label();
                lblauthor.Height = 20;
                lblauthor.Width = 200;
                lblauthor.TextAlign = ContentAlignment.MiddleLeft;
                lblauthor.Text = $"Teacher: {quizz.AuthorNavigation.UserName}";
                lblauthor.Location = new Point((groupBox.Width - lblauthor.Width) / 2, 75);
                groupBox.Controls.Add(lblauthor);

                Label lblquestion = new Label();
                lblquestion.Height = 20;
                lblquestion.Width = 200;
                lblquestion.TextAlign = ContentAlignment.MiddleLeft;
                lblquestion.Text = $"Number of questions: {quizz.Questions.Count()} questions";
                lblquestion.Location = new Point((groupBox.Width - lblquestion.Width) / 2, 95);
                groupBox.Controls.Add(lblquestion);

                MyButton myButton = new MyButton();
                myButton.AutoSize = true;
                myButton.Text = "Take Quizz";
                myButton.BackColor = Color.Blue;
                myButton.ForeColor = Color.White;
                myButton.Click += ButtonClickHandler;
                myButton.quizz = quizz;
                myButton.Show();
                myButton.Location = new Point((groupBox.Width - myButton.Width) / 2, 120);
                groupBox.Controls.Add(myButton);
                if (quizz.Author == Global.UserId && !isResume && Global.Role == 1)
                {
                    MyButton removeButton = new MyButton();
                    removeButton.AutoSize = true;
                    removeButton.Text = "Remove Quizz";
                    removeButton.BackColor = Color.Red;
                    removeButton.ForeColor = Color.White;
                    removeButton.Click += removeQuizBtn;
                    removeButton.quizz = quizz;
                    removeButton.Show();
                    removeButton.Location = new Point(0, 120);
                    groupBox.Controls.Add(removeButton);

                    MyButton editButton = new MyButton();
                    editButton.AutoSize = true;
                    editButton.Text = "Edit Quizz";
                    editButton.BackColor = Color.Yellow;
                    editButton.ForeColor = Color.Black;
                    editButton.Click += editQuizBtn;
                    editButton.quizz = quizz;
                    editButton.Show();
                    editButton.Location = new Point(215, 120);
                    groupBox.Controls.Add(editButton);

                }
                panel1.Controls.Add(groupBox);

                i++;
            }
        }

        void ButtonClickHandler(object sender, EventArgs args)
        {
            if (Global.UserId == -1)
            {
                MessageBox.Show("Please login to do quizz", "", MessageBoxButtons.OK);
            }
            else
            {
                MyButton mb = (sender as MyButton);

                QuizzDetailGUI quizzDetailGUI = new QuizzDetailGUI(mb.quizz);
                quizzDetailGUI.TopLevel = false;
                quizzDetailGUI.FormBorderStyle = FormBorderStyle.None; quizzDetailGUI.FormClosed += qDetailClosed;
                quizzDetailGUI.Show();
               
                Global.toolStripContainer.ContentPanel.Controls.Clear();
                Global.toolStripContainer.ContentPanel.Controls.Add(quizzDetailGUI);
            }

        }
        void qDetailClosed(object sender, EventArgs args)
        {
            this.Close();
        }
        void removeQuizBtn(object sender, EventArgs args)
        {
           
            if (Global.UserId == -1)
            {
                MessageBox.Show("Please login", "", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Delete this quizz?", "Delete confirm", MessageBoxButtons.OKCancel);
                if (dr.Equals(DialogResult.OK))
                {
                    context.Quizzs.Remove((sender as MyButton).quizz);
                    context.SaveChanges();
                    bindPanel(pageList.PageIndex);
                }

            }

        }
        void editQuizBtn(object sender, EventArgs args)
        {
            if (Global.UserId == -1)
            {
                MessageBox.Show("Please login", "", MessageBoxButtons.OK);
            }
            else
            {
                Quizz q = (sender as MyButton).quizz;
                var quizWithQuestionAndAnswer = context.Quizzs.Include(qui => qui.Questions).ThenInclude(ques => ques.Answers).FirstOrDefault(qui => qui.QuizzId == q.QuizzId);
                AddQuizGui editQuiz = new AddQuizGui(quizWithQuestionAndAnswer);
                context.SaveChanges();
                editQuiz.FormClosed += ClosedForm;
            }
        }
        private void ClosedForm(object sender, EventArgs e)
        {
            bindPanel(pageList.PageIndex);
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            bindPanel(pageList.PageIndex + 1);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            bindPanel(1);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            bindPanel(pageList.PageIndex - 1);
        }
    }
}
