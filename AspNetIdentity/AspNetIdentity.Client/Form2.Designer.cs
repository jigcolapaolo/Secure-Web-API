namespace AspNetIdentity.Client
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
            loginLbl = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnLogin = new Button();
            lstWeatherForecast = new ListView();
            btnRegisterForm = new Button();
            btnForgetPw = new Button();
            txtPwEmail = new TextBox();
            SuspendLayout();
            // 
            // loginLbl
            // 
            loginLbl.AutoSize = true;
            loginLbl.Font = new Font("ROG Fonts", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLbl.ForeColor = SystemColors.Control;
            loginLbl.Location = new Point(113, 68);
            loginLbl.Name = "loginLbl";
            loginLbl.Size = new Size(136, 38);
            loginLbl.TabIndex = 10;
            loginLbl.Text = "Login";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(130, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(130, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(141, 206);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lstWeatherForecast
            // 
            lstWeatherForecast.Location = new Point(375, 68);
            lstWeatherForecast.Name = "lstWeatherForecast";
            lstWeatherForecast.Size = new Size(389, 311);
            lstWeatherForecast.TabIndex = 11;
            lstWeatherForecast.UseCompatibleStateImageBehavior = false;
            // 
            // btnRegisterForm
            // 
            btnRegisterForm.Location = new Point(130, 305);
            btnRegisterForm.Name = "btnRegisterForm";
            btnRegisterForm.Size = new Size(100, 23);
            btnRegisterForm.TabIndex = 12;
            btnRegisterForm.Text = "Go to Register";
            btnRegisterForm.UseVisualStyleBackColor = true;
            btnRegisterForm.Click += btnRegisterForm_Click;
            // 
            // btnForgetPw
            // 
            btnForgetPw.Location = new Point(113, 266);
            btnForgetPw.Name = "btnForgetPw";
            btnForgetPw.Size = new Size(136, 23);
            btnForgetPw.TabIndex = 13;
            btnForgetPw.Text = "Forgot Password?";
            btnForgetPw.UseVisualStyleBackColor = true;
            btnForgetPw.Click += btnForgetPw_Click;
            // 
            // txtPwEmail
            // 
            txtPwEmail.Location = new Point(130, 237);
            txtPwEmail.Name = "txtPwEmail";
            txtPwEmail.PlaceholderText = "Only Email";
            txtPwEmail.Size = new Size(100, 23);
            txtPwEmail.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPwEmail);
            Controls.Add(btnForgetPw);
            Controls.Add(btnRegisterForm);
            Controls.Add(lstWeatherForecast);
            Controls.Add(loginLbl);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnLogin);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLbl;
        private Label label1;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnLogin;
        private ListView lstWeatherForecast;
        private Button btnRegisterForm;
        private Button btnForgetPw;
        private TextBox txtPwEmail;
    }
}