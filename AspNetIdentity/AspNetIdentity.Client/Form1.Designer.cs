namespace AspNetIdentity.Client
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
            btnRegister = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Location = new Point(358, 248);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(349, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(349, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(349, 219);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(100, 23);
            txtConfirmPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(344, 123);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 4;
            label1.Text = "Create an Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("ROG Fonts", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(323, 9);
            label2.Name = "label2";
            label2.Size = new Size(136, 38);
            label2.TabIndex = 5;
            label2.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnRegister);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label label1;
        private Label label2;
    }
}
