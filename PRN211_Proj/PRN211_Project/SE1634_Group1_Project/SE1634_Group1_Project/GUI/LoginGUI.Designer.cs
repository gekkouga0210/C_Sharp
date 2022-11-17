namespace SE1634_Group1_Project.GUI
{
    partial class LoginGUI
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
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameValue = new System.Windows.Forms.TextBox();
            this.PasswordValue = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(131, 63);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(82, 20);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "User name:";
            // 
            // UserNameValue
            // 
            this.UserNameValue.Location = new System.Drawing.Point(219, 60);
            this.UserNameValue.Name = "UserNameValue";
            this.UserNameValue.Size = new System.Drawing.Size(166, 27);
            this.UserNameValue.TabIndex = 1;
            // 
            // PasswordValue
            // 
            this.PasswordValue.Location = new System.Drawing.Point(220, 124);
            this.PasswordValue.Name = "PasswordValue";
            this.PasswordValue.Size = new System.Drawing.Size(166, 27);
            this.PasswordValue.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(132, 127);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(73, 20);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(119, 223);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 29);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(319, 223);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(94, 29);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 313);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PasswordValue);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameValue);
            this.Controls.Add(this.UserNameLabel);
            this.Name = "LoginGUI";
            this.Text = "LoginGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UserNameLabel;
        private TextBox UserNameValue;
        private TextBox PasswordValue;
        private Label PasswordLabel;
        private Button CancelButton;
        private Button LoginButton;
    }
}