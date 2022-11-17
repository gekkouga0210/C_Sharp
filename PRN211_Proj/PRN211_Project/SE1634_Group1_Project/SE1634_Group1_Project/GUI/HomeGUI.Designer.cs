namespace SE1634_Group1_Project.GUI
{
    partial class HomeGUI
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
            this.TitleValue = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleValue
            // 
            this.TitleValue.Location = new System.Drawing.Point(96, 25);
            this.TitleValue.Name = "TitleValue";
            this.TitleValue.Size = new System.Drawing.Size(225, 27);
            this.TitleValue.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(49, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(41, 20);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(337, 24);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(121, 29);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 251);
            this.panel1.TabIndex = 3;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(49, 333);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(94, 29);
            this.PreviousButton.TabIndex = 4;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(189, 333);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(94, 29);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // HomeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 367);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.TitleValue);
            this.Name = "HomeGUI";
            this.Text = "HomeGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TitleValue;
        private Label Title;
        private Button SearchButton;
        private Panel panel1;
        private Button PreviousButton;
        private Button NextButton;
    }
}