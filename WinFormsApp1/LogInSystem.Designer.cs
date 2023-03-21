namespace WinFormsApp1
{
    partial class LogInSystem
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
            this.buttonLog = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.labelReg = new System.Windows.Forms.Label();
            this.labelErrorLog = new System.Windows.Forms.Label();
            this.checkPasswordBox = new System.Windows.Forms.CheckBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonLog.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLog.Location = new System.Drawing.Point(303, 218);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(138, 40);
            this.buttonLog.TabIndex = 0;
            this.buttonLog.Text = "Войти";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(219, 108);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(307, 23);
            this.LoginBox.TabIndex = 1;
            this.LoginBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginBox_KeyPress);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(219, 165);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(307, 23);
            this.PasswordBox.TabIndex = 2;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordBox_KeyPress);
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(303, 325);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(138, 23);
            this.buttonReg.TabIndex = 3;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Location = new System.Drawing.Point(243, 307);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(255, 15);
            this.labelReg.TabIndex = 4;
            this.labelReg.Text = "Еще не создали аккаунт? Зарегистрируйтесь!";
            // 
            // labelErrorLog
            // 
            this.labelErrorLog.AutoSize = true;
            this.labelErrorLog.ForeColor = System.Drawing.Color.Red;
            this.labelErrorLog.Location = new System.Drawing.Point(303, 273);
            this.labelErrorLog.Name = "labelErrorLog";
            this.labelErrorLog.Size = new System.Drawing.Size(17, 15);
            this.labelErrorLog.TabIndex = 5;
            this.labelErrorLog.Text = "Er";
            this.labelErrorLog.Visible = false;
            // 
            // checkPasswordBox
            // 
            this.checkPasswordBox.AutoSize = true;
            this.checkPasswordBox.Location = new System.Drawing.Point(549, 167);
            this.checkPasswordBox.Name = "checkPasswordBox";
            this.checkPasswordBox.Size = new System.Drawing.Size(119, 19);
            this.checkPasswordBox.TabIndex = 6;
            this.checkPasswordBox.Text = "Показать пароль";
            this.checkPasswordBox.UseVisualStyleBackColor = true;
            this.checkPasswordBox.CheckedChanged += new System.EventHandler(this.checkPasswordBox_CheckedChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.Color.Black;
            this.labelLogin.Location = new System.Drawing.Point(340, 82);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(55, 23);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(324, 139);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(88, 23);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password";
            // 
            // LogInSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.checkPasswordBox);
            this.Controls.Add(this.labelErrorLog);
            this.Controls.Add(this.labelReg);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.buttonLog);
            this.Name = "LogInSystem";
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogInSystem_FormClosing_1);
            this.Load += new System.EventHandler(this.LogInSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLog;
        private TextBox LoginBox;
        private TextBox PasswordBox;
        private Button buttonReg;
        private Label labelReg;
        private Label labelErrorLog;
        private CheckBox checkPasswordBox;
        private Label labelLogin;
        private Label labelPassword;
    }
}