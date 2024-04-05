namespace Expense_Tracker_SideProject_BantuBeya
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            btnSignInRegister = new Button();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            registerShowPass = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtRegisterPassword = new TextBox();
            txtRegUsername = new TextBox();
            lblClose = new Label();
            btnSignup = new Button();
            label1 = new Label();
            txtRegisterConfirmPass = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 121, 84);
            panel1.Controls.Add(btnSignInRegister);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 498);
            panel1.TabIndex = 10;
            // 
            // btnSignInRegister
            // 
            btnSignInRegister.BackColor = Color.FromArgb(49, 121, 84);
            btnSignInRegister.FlatAppearance.BorderSize = 2;
            btnSignInRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(93, 160, 108);
            btnSignInRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 160, 108);
            btnSignInRegister.FlatStyle = FlatStyle.Flat;
            btnSignInRegister.Font = new Font("Tahoma", 10F);
            btnSignInRegister.ForeColor = Color.White;
            btnSignInRegister.Location = new Point(26, 422);
            btnSignInRegister.Name = "btnSignInRegister";
            btnSignInRegister.Size = new Size(277, 31);
            btnSignInRegister.TabIndex = 10;
            btnSignInRegister.Text = "SIGN IN";
            btnSignInRegister.UseVisualStyleBackColor = false;
            btnSignInRegister.Click += btnSignUp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(71, 391);
            label3.Name = "label3";
            label3.Size = new Size(195, 19);
            label3.TabIndex = 7;
            label3.Text = "Already have an account ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 248);
            label2.Name = "label2";
            label2.Size = new Size(221, 19);
            label2.TabIndex = 4;
            label2.Text = "Income and Expenses Tracker";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(113, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 96);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // registerShowPass
            // 
            registerShowPass.AutoSize = true;
            registerShowPass.Cursor = Cursors.Hand;
            registerShowPass.Location = new Point(543, 358);
            registerShowPass.Name = "registerShowPass";
            registerShowPass.Size = new Size(108, 19);
            registerShowPass.TabIndex = 18;
            registerShowPass.Text = "Show Password";
            registerShowPass.UseVisualStyleBackColor = true;
            registerShowPass.CheckedChanged += loginShowPass_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11F);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(360, 215);
            label6.Name = "label6";
            label6.Size = new Size(69, 18);
            label6.TabIndex = 17;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11F);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(360, 146);
            label5.Name = "label5";
            label5.Size = new Size(75, 18);
            label5.TabIndex = 16;
            label5.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(360, 89);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 15;
            label4.Text = "REGISTER";
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Font = new Font("Tahoma", 11F);
            txtRegisterPassword.Location = new Point(360, 246);
            txtRegisterPassword.Multiline = true;
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.PasswordChar = '*';
            txtRegisterPassword.Size = new Size(291, 29);
            txtRegisterPassword.TabIndex = 14;
            // 
            // txtRegUsername
            // 
            txtRegUsername.Font = new Font("Tahoma", 11F);
            txtRegUsername.Location = new Point(360, 176);
            txtRegUsername.Multiline = true;
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.Size = new Size(291, 29);
            txtRegUsername.TabIndex = 13;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Cursor = Cursors.Hand;
            lblClose.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClose.Location = new Point(650, 9);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(17, 17);
            lblClose.TabIndex = 12;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(49, 121, 84);
            btnSignup.FlatAppearance.MouseDownBackColor = Color.FromArgb(93, 160, 108);
            btnSignup.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 160, 108);
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Tahoma", 10F);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(360, 387);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(82, 31);
            btnSignup.TabIndex = 11;
            btnSignup.Text = "SIGN UP";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(360, 292);
            label1.Name = "label1";
            label1.Size = new Size(124, 18);
            label1.TabIndex = 20;
            label1.Text = "Confirm Password";
            // 
            // txtRegisterConfirmPass
            // 
            txtRegisterConfirmPass.Font = new Font("Tahoma", 11F);
            txtRegisterConfirmPass.Location = new Point(360, 323);
            txtRegisterConfirmPass.Multiline = true;
            txtRegisterConfirmPass.Name = "txtRegisterConfirmPass";
            txtRegisterConfirmPass.PasswordChar = '*';
            txtRegisterConfirmPass.Size = new Size(291, 29);
            txtRegisterConfirmPass.TabIndex = 19;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 498);
            Controls.Add(label1);
            Controls.Add(txtRegisterConfirmPass);
            Controls.Add(panel1);
            Controls.Add(registerShowPass);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtRegisterPassword);
            Controls.Add(txtRegUsername);
            Controls.Add(lblClose);
            Controls.Add(btnSignup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSignInRegister;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private CheckBox registerShowPass;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtLoginPassword;
        private TextBox txtRegUsername;
        private Label lblClose;
        private Button btnSignup;
        private Label label1;
        private TextBox textBox1;
        private TextBox txtRegisterPassword;
        private TextBox txtRegisterConfirmPass;
    }
}