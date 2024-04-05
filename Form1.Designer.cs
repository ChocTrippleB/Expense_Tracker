namespace Expense_Tracker_SideProject_BantuBeya
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnSignUp = new Button();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            lblClose = new Label();
            txtLoginUsername = new TextBox();
            txtLoginPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            loginShowPass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 121, 84);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 498);
            panel1.TabIndex = 0;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(49, 121, 84);
            btnSignUp.FlatAppearance.BorderSize = 2;
            btnSignUp.FlatAppearance.MouseDownBackColor = Color.FromArgb(93, 160, 108);
            btnSignUp.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 160, 108);
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Tahoma", 10F);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(24, 421);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(277, 31);
            btnSignUp.TabIndex = 10;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(80, 390);
            label3.Name = "label3";
            label3.Size = new Size(174, 19);
            label3.TabIndex = 7;
            label3.Text = "Create an account now!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 240);
            label2.Name = "label2";
            label2.Size = new Size(221, 19);
            label2.TabIndex = 4;
            label2.Text = "Income and Expenses Tracker";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(112, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 96);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(49, 121, 84);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(93, 160, 108);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 160, 108);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 10F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(362, 358);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(82, 31);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Cursor = Cursors.Hand;
            lblClose.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClose.Location = new Point(666, 9);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(17, 17);
            lblClose.TabIndex = 2;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Font = new Font("Tahoma", 11F);
            txtLoginUsername.Location = new Point(362, 214);
            txtLoginUsername.Multiline = true;
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(291, 29);
            txtLoginUsername.TabIndex = 3;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Font = new Font("Tahoma", 11F);
            txtLoginPassword.Location = new Point(362, 285);
            txtLoginPassword.Multiline = true;
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.Size = new Size(291, 29);
            txtLoginPassword.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(362, 123);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 6;
            label4.Text = "SIGN IN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11F);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(362, 184);
            label5.Name = "label5";
            label5.Size = new Size(75, 18);
            label5.TabIndex = 7;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11F);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(362, 254);
            label6.Name = "label6";
            label6.Size = new Size(69, 18);
            label6.TabIndex = 8;
            label6.Text = "Password";
            // 
            // loginShowPass
            // 
            loginShowPass.AutoSize = true;
            loginShowPass.Cursor = Cursors.Hand;
            loginShowPass.Location = new Point(545, 320);
            loginShowPass.Name = "loginShowPass";
            loginShowPass.Size = new Size(108, 19);
            loginShowPass.TabIndex = 9;
            loginShowPass.Text = "Show Password";
            loginShowPass.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(695, 498);
            Controls.Add(loginShowPass);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtLoginPassword);
            Controls.Add(txtLoginUsername);
            Controls.Add(lblClose);
            Controls.Add(btnLogin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private Label lblClose;
        private TextBox txtLoginUsername;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtLoginPassword;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox loginShowPass;
        private Label label3;
        private Button btnSignUp;
    }
}
