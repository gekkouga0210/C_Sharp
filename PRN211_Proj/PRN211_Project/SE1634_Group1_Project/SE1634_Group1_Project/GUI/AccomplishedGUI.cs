using SE1634_Group1_Project;
using SE1634_Group1_Project.Models;

namespace accomplied
{
    public partial class AccomplishedGUI : Form
    {
        private readonly HappyQuizzContext quizzContext;
        public AccomplishedGUI()
        {
            InitializeComponent();
            quizzContext = new HappyQuizzContext();
            BindingData();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BindingData()
        {
            int userId = Global.UserId;
            var accom = quizzContext.RecordQuizzs.Where(rc => rc.UserId == userId).Select(rc => new { rc.Quizz.Title, rc.MaxScore, rc.LastTime, rc.Count }).ToList();
            this.dataGridView1.DataSource = accom;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}