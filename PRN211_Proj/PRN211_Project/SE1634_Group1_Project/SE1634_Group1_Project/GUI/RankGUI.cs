using Microsoft.EntityFrameworkCore;
using SE1634_Group1_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accomplied
{
    public partial class RankGUI : Form
    {
        private Quizz quizz { get; set; }
        private readonly HappyQuizzContext quizzContext;
        public RankGUI(Quizz quizz)
        {
            InitializeComponent();
            quizzContext = new HappyQuizzContext();
            this.quizz = quizz;
            BindingRank();
            this.Show();
        }
        private void BindingRank()
        {
            var rankList = quizzContext.RecordQuizzs
                .Include(rc => rc.User)
                .Where(rc => rc.QuizzId == quizz.QuizzId)
                .OrderByDescending(rc => rc.MaxScore)
                .Select(rc => new {rc.LastTime, rc.User.UserName, rc.MaxScore})
                .ToList();
            dataGridView1.DataSource = rankList;

        }
        private void RankGUI_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
