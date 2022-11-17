using SE1634_Group1_Project.Models;

namespace SE1634_Group1_Project.GUI
{
    public partial class AddQuizGui : Form
    {
        private Quizz quizz;
        private Dictionary<int, Question> questionAddList;
        PageList<Question> pageList;
        private HappyQuizzContext quizzContext;
        public AddQuizGui()
        {
            quizz = new Quizz();
            InitializeComponent();
            questionAddList = new Dictionary<int, Question>();
           
            this.quizzContext = new HappyQuizzContext();
            Bind(1);
            this.Show();
        }
        public AddQuizGui(Quizz quizz)
        {
            InitializeComponent();
            questionAddList = new Dictionary<int, Question>();
            this.quizz = quizz;
            for(int i = 0; i< quizz.Questions.Count; i++)
            {
                questionAddList.Add(i+1, quizz.Questions.ElementAt(i));
            }
            
            this.quizzContext = new HappyQuizzContext();
            Bind(1);
            this.Show();
        }
        private void Bind(int pageIndex)
        {
            quizzContext = new HappyQuizzContext();
            pageList = PageList<Question>.Create(questionAddList.Values.ToList().AsQueryable(), pageIndex, 1);
            this.title.Text = quizz.Title;
            btnPre.Enabled = pageList.HasPreviousPage;
            this.id.Text = pageIndex.ToString();
            if (questionAddList.ContainsKey(pageIndex))
            {
                this.question.Text = questionAddList[pageIndex].Text;
                this.answer1.Text = questionAddList[pageIndex].Answers.ElementAt(0).Text;
                this.answer2.Text = questionAddList[pageIndex].Answers.ElementAt(1).Text;
                this.answer3.Text = questionAddList[pageIndex].Answers.ElementAt(2).Text;
                this.answer4.Text = questionAddList[pageIndex].Answers.ElementAt(3).Text;
                int indexCorrect = questionAddList[pageIndex].Answers.ToList()
                    .IndexOf(questionAddList[pageIndex].Answers.FirstOrDefault(a => (bool)a.IsCorrect));
                setCorrectAnswer(indexCorrect);
            }
            else
            {
                this.question.Text = string.Empty;
                this.answer1.Text = string.Empty;
                this.answer2.Text = string.Empty;
                this.answer3.Text = string.Empty;
                this.answer4.Text = string.Empty;
                setCorrectAnswer(0);
            }
            this.page.Text = pageIndex.ToString() + "/" + (questionAddList.Count()+1).ToString();

        }
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            quizz.Title = title.Text;

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            SaveTemp();
            if (validate()) Bind(pageList.PageIndex - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveTemp();
            if (validate()) Bind(pageList.PageIndex + 1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                SaveTemp();

                if (questionAddList.Count == 0)
                {
                    MessageBox.Show("Please Add A Question", "Invalid", MessageBoxButtons.OK);
                }
                else
                {
                    quizz.Questions = questionAddList.Values;
                    if (quizz.QuizzId != 0)
                    {
                        quizz.Author = Global.UserId;
                        quizzContext.Quizzs.Update(quizz);
                    }
                    else
                    {
                        quizz.Author = Global.UserId;
                        quizzContext.Quizzs.Add(quizz);
                    }

                    quizzContext.SaveChanges();
                    MessageBox.Show("Success", "Success", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            

        }
        private bool validate()
        {
            return (!string.IsNullOrEmpty(this.question.Text)  &&
                !string.IsNullOrEmpty(this.answer1.Text) &&
                !string.IsNullOrEmpty(this.answer2.Text) &&
                !string.IsNullOrEmpty(this.answer3.Text) &&
                !string.IsNullOrEmpty(this.answer4.Text) &&
                !string.IsNullOrEmpty(this.title.Text)) && selectedRadio();
        }
        private void SaveTemp()
        {
            if (!validate())
            {
                MessageBox.Show("Please type in all fields", "Invalid", MessageBoxButtons.OK);
            }
            else
            {
                int id = pageList.PageIndex;
                Question question = new Question();
                question.Text = this.question.Text;
                Answer ans1 = new Answer();
                ans1.Text = this.answer1.Text;
                ans1.IsCorrect = false;
                Answer ans2 = new Answer();
                ans2.Text = this.answer2.Text; ans2.IsCorrect = false;
                Answer ans3 = new Answer();
                ans3.Text = this.answer3.Text; ans3.IsCorrect = false;
                Answer ans4 = new Answer();
                ans4.Text = this.answer4.Text; ans4.IsCorrect = false;
                question.Answers.Add(ans1);
                question.Answers.Add(ans2);
                question.Answers.Add(ans3);
                question.Answers.Add(ans4);

                question.Answers.ElementAt(getCorrectAnswer()).IsCorrect = true;
                if (questionAddList.ContainsKey(id)) questionAddList[id] = question;
                else questionAddList.Add(id, question);
                
            }

        }
        private int getCorrectAnswer()
        {
            int correctAnswer = 0;
            foreach (var r in this.groupBox1.Controls)
            {
                if (typeof(RadioButton).Equals(r.GetType()) && ((RadioButton)r).Checked)
                {
                    correctAnswer = (int)((RadioButton)r).Tag-1;
                }

            }
            return correctAnswer;
        }
        private void setCorrectAnswer(int correctAnswer)
        {
            foreach (var r in this.groupBox1.Controls)
            {
                if (typeof(RadioButton).Equals(r.GetType()))

                {
                    if ((int)((RadioButton)r).Tag == correctAnswer)
                    {
                        ((RadioButton)r).Checked = true;
                    }
                    else
                    {
                        ((RadioButton)r).Checked = false;
                    }
                }

            }
        }
        private bool selectedRadio()
        {
            int count = 0;
            foreach (var r in this.groupBox1.Controls)
            {
                if (typeof(RadioButton).Equals(r.GetType()) && ((RadioButton)r).Checked)
                {
                    count++;
                }
            }
            return count != 0;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void removeOne_Click(object sender, EventArgs e)
        {
            if (questionAddList.ContainsKey(int.Parse(this.id.Text)))
            {
                questionAddList.Remove(int.Parse(this.id.Text));
                Bind(pageList.PageIndex - 1);
            }
        }
        private void removeAll_Click(object sender, EventArgs e)
        {
            questionAddList.Clear();
            Bind(1);
        }

        private void AddQuizGui_Load(object sender, EventArgs e)
        {

        }
    }
}
