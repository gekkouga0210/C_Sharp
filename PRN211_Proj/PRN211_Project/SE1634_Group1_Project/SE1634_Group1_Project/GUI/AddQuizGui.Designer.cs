namespace SE1634_Group1_Project.GUI
{
    partial class AddQuizGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ansCorrect4 = new System.Windows.Forms.RadioButton();
            this.ansCorrect3 = new System.Windows.Forms.RadioButton();
            this.ansCorrect2 = new System.Windows.Forms.RadioButton();
            this.ansCorrect1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.answer4 = new System.Windows.Forms.TextBox();
            this.answer3 = new System.Windows.Forms.TextBox();
            this.answer2 = new System.Windows.Forms.TextBox();
            this.answer1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.question = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.page = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.removeOne = new System.Windows.Forms.Button();
            this.removeAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(101, 19);
            this.title.Name = "title";
            this.title.PlaceholderText = "Quizz Title";
            this.title.Size = new System.Drawing.Size(150, 23);
            this.title.TabIndex = 1;
            this.title.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ansCorrect4);
            this.groupBox1.Controls.Add(this.ansCorrect3);
            this.groupBox1.Controls.Add(this.ansCorrect2);
            this.groupBox1.Controls.Add(this.ansCorrect1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.answer4);
            this.groupBox1.Controls.Add(this.answer3);
            this.groupBox1.Controls.Add(this.answer2);
            this.groupBox1.Controls.Add(this.answer1);
            this.groupBox1.Location = new System.Drawing.Point(54, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 233);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Answer";
            // 
            // ansCorrect4
            // 
            this.ansCorrect4.AutoSize = true;
            this.ansCorrect4.Location = new System.Drawing.Point(285, 194);
            this.ansCorrect4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ansCorrect4.Name = "ansCorrect4";
            this.ansCorrect4.Size = new System.Drawing.Size(14, 13);
            this.ansCorrect4.TabIndex = 12;
            this.ansCorrect4.TabStop = true;
            this.ansCorrect4.Tag = 4;
            this.ansCorrect4.UseVisualStyleBackColor = true;
            // 
            // ansCorrect3
            // 
            this.ansCorrect3.AutoSize = true;
            this.ansCorrect3.Location = new System.Drawing.Point(285, 140);
            this.ansCorrect3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ansCorrect3.Name = "ansCorrect3";
            this.ansCorrect3.Size = new System.Drawing.Size(14, 13);
            this.ansCorrect3.TabIndex = 11;
            this.ansCorrect3.TabStop = true;
            this.ansCorrect3.Tag = 3;
            this.ansCorrect3.UseVisualStyleBackColor = true;
            // 
            // ansCorrect2
            // 
            this.ansCorrect2.AutoSize = true;
            this.ansCorrect2.Location = new System.Drawing.Point(285, 90);
            this.ansCorrect2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ansCorrect2.Name = "ansCorrect2";
            this.ansCorrect2.Size = new System.Drawing.Size(14, 13);
            this.ansCorrect2.TabIndex = 10;
            this.ansCorrect2.TabStop = true;
            this.ansCorrect2.Tag = 2;
            this.ansCorrect2.UseVisualStyleBackColor = true;
            // 
            // ansCorrect1
            // 
            this.ansCorrect1.AutoSize = true;
            this.ansCorrect1.Location = new System.Drawing.Point(285, 37);
            this.ansCorrect1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ansCorrect1.Name = "ansCorrect1";
            this.ansCorrect1.Size = new System.Drawing.Size(14, 13);
            this.ansCorrect1.TabIndex = 9;
            this.ansCorrect1.TabStop = true;
            this.ansCorrect1.Tag = 1;
            this.ansCorrect1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Correct Answer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // answer4
            // 
            this.answer4.Location = new System.Drawing.Point(5, 194);
            this.answer4.Name = "answer4";
            this.answer4.PlaceholderText = "Answer 4";
            this.answer4.Size = new System.Drawing.Size(248, 23);
            this.answer4.TabIndex = 3;
            // 
            // answer3
            // 
            this.answer3.Location = new System.Drawing.Point(5, 138);
            this.answer3.Name = "answer3";
            this.answer3.PlaceholderText = "Answer 3";
            this.answer3.Size = new System.Drawing.Size(248, 23);
            this.answer3.TabIndex = 2;
            // 
            // answer2
            // 
            this.answer2.Location = new System.Drawing.Point(5, 88);
            this.answer2.Name = "answer2";
            this.answer2.PlaceholderText = "Answer 2";
            this.answer2.Size = new System.Drawing.Size(248, 23);
            this.answer2.TabIndex = 1;
            // 
            // answer1
            // 
            this.answer1.Location = new System.Drawing.Point(5, 34);
            this.answer1.Name = "answer1";
            this.answer1.PlaceholderText = "Answer 1";
            this.answer1.Size = new System.Drawing.Size(248, 23);
            this.answer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.question);
            this.groupBox2.Location = new System.Drawing.Point(411, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 233);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Question";
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(6, 34);
            this.question.Multiline = true;
            this.question.Name = "question";
            this.question.PlaceholderText = "Question content";
            this.question.Size = new System.Drawing.Size(248, 193);
            this.question.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(691, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 48);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save all question";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(54, 352);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 5;
            this.btnPre.Text = "<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(611, 352);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // page
            // 
            this.page.AutoSize = true;
            this.page.Location = new System.Drawing.Point(365, 356);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(30, 15);
            this.page.TabIndex = 7;
            this.page.Text = "1/30";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(304, 19);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(150, 23);
            this.id.TabIndex = 1;
            this.id.Visible = false;
            this.id.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // removeOne
            // 
            this.removeOne.Location = new System.Drawing.Point(693, 172);
            this.removeOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeOne.Name = "removeOne";
            this.removeOne.Size = new System.Drawing.Size(96, 39);
            this.removeOne.TabIndex = 8;
            this.removeOne.Text = "Remove this question";
            this.removeOne.UseVisualStyleBackColor = true;
            this.removeOne.Click += new System.EventHandler(this.removeOne_Click);
            // 
            // removeAll
            // 
            this.removeAll.Location = new System.Drawing.Point(694, 223);
            this.removeAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(95, 38);
            this.removeAll.TabIndex = 9;
            this.removeAll.Text = "Remove all question";
            this.removeAll.UseVisualStyleBackColor = true;
            this.removeAll.Click += new System.EventHandler(this.removeAll_Click);
            // 
            // AddQuizGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeAll);
            this.Controls.Add(this.removeOne);
            this.Controls.Add(this.page);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Name = "AddQuizGui";
            this.Text = "AddQuizGui";
            this.Load += new System.EventHandler(this.AddQuizGui_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox id;
        private TextBox title;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox answer4;
        private TextBox answer3;
        private TextBox answer2;
        private TextBox answer1;
        private TextBox question;
        private Button btnSave;
        private Button btnPre;
        private Button btnNext;
        private Label page;
        private Label label2;
        private RadioButton ansCorrect4;
        private RadioButton ansCorrect3;
        private RadioButton ansCorrect2;
        private RadioButton ansCorrect1;
        private Button removeOne;
        private Button removeAll;
    }
}