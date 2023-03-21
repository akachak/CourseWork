namespace WinFormsApp1
{
    partial class Registration
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
            this.buttonReg = new System.Windows.Forms.Button();
            this.NickNameBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.labelNickName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelErNickName = new System.Windows.Forms.Label();
            this.labelErLogin = new System.Windows.Forms.Label();
            this.labelErNothing = new System.Windows.Forms.Label();
            this.labelRightReg = new System.Windows.Forms.Label();
            this.buttonProd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(313, 340);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(164, 23);
            this.buttonReg.TabIndex = 0;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // NickNameBox
            // 
            this.NickNameBox.Location = new System.Drawing.Point(282, 125);
            this.NickNameBox.Name = "NickNameBox";
            this.NickNameBox.Size = new System.Drawing.Size(215, 23);
            this.NickNameBox.TabIndex = 1;
            this.NickNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NickNameBox_KeyPress);
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(282, 211);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(215, 23);
            this.LoginBox.TabIndex = 3;
            this.LoginBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginBox_KeyPress);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(282, 289);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(215, 23);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordBox_KeyPress);
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(530, 291);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(119, 19);
            this.checkBoxPassword.TabIndex = 5;
            this.checkBoxPassword.Text = "Показать пароль";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // labelNickName
            // 
            this.labelNickName.AutoSize = true;
            this.labelNickName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNickName.Location = new System.Drawing.Point(344, 99);
            this.labelNickName.Name = "labelNickName";
            this.labelNickName.Size = new System.Drawing.Size(102, 23);
            this.labelNickName.TabIndex = 6;
            this.labelNickName.Text = "User Name";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(348, 266);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(88, 23);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(361, 185);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(55, 23);
            this.labelLogin.TabIndex = 8;
            this.labelLogin.Text = "Login";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.Location = new System.Drawing.Point(290, 43);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(196, 29);
            this.labelInfo.TabIndex = 9;
            this.labelInfo.Text = "Введите данные";
            // 
            // labelErNickName
            // 
            this.labelErNickName.AutoSize = true;
            this.labelErNickName.ForeColor = System.Drawing.Color.Red;
            this.labelErNickName.Location = new System.Drawing.Point(332, 154);
            this.labelErNickName.Name = "labelErNickName";
            this.labelErNickName.Size = new System.Drawing.Size(114, 15);
            this.labelErNickName.TabIndex = 10;
            this.labelErNickName.Text = "Это имя уже занято";
            this.labelErNickName.Visible = false;
            // 
            // labelErLogin
            // 
            this.labelErLogin.AutoSize = true;
            this.labelErLogin.ForeColor = System.Drawing.Color.Red;
            this.labelErLogin.Location = new System.Drawing.Point(344, 237);
            this.labelErLogin.Name = "labelErLogin";
            this.labelErLogin.Size = new System.Drawing.Size(99, 15);
            this.labelErLogin.TabIndex = 11;
            this.labelErLogin.Text = "Этот логин занят";
            this.labelErLogin.Visible = false;
            // 
            // labelErNothing
            // 
            this.labelErNothing.AutoSize = true;
            this.labelErNothing.ForeColor = System.Drawing.Color.Red;
            this.labelErNothing.Location = new System.Drawing.Point(348, 322);
            this.labelErNothing.Name = "labelErNothing";
            this.labelErNothing.Size = new System.Drawing.Size(94, 15);
            this.labelErNothing.TabIndex = 12;
            this.labelErNothing.Text = "Введите данные";
            this.labelErNothing.Visible = false;
            // 
            // labelRightReg
            // 
            this.labelRightReg.AutoSize = true;
            this.labelRightReg.ForeColor = System.Drawing.Color.Green;
            this.labelRightReg.Location = new System.Drawing.Point(307, 322);
            this.labelRightReg.Name = "labelRightReg";
            this.labelRightReg.Size = new System.Drawing.Size(177, 15);
            this.labelRightReg.TabIndex = 13;
            this.labelRightReg.Text = "Регистрация прошла успешно";
            this.labelRightReg.Visible = false;
            // 
            // buttonProd
            // 
            this.buttonProd.Location = new System.Drawing.Point(313, 340);
            this.buttonProd.Name = "buttonProd";
            this.buttonProd.Size = new System.Drawing.Size(164, 23);
            this.buttonProd.TabIndex = 14;
            this.buttonProd.Text = "Продолжить";
            this.buttonProd.UseVisualStyleBackColor = true;
            this.buttonProd.Visible = false;
            this.buttonProd.Click += new System.EventHandler(this.buttonProd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(9, 8);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(51, 23);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonProd);
            this.Controls.Add(this.labelRightReg);
            this.Controls.Add(this.labelErNothing);
            this.Controls.Add(this.labelErLogin);
            this.Controls.Add(this.labelErNickName);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelNickName);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.NickNameBox);
            this.Controls.Add(this.buttonReg);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonReg;
        private TextBox NickNameBox;
        private TextBox LoginBox;
        private TextBox PasswordBox;
        private CheckBox checkBoxPassword;
        private Label labelNickName;
        private Label labelPassword;
        private Label labelLogin;
        private Label labelInfo;
        private Label labelErNickName;
        private Label labelErLogin;
        private Label labelErNothing;
        private Label labelRightReg;
        private Button buttonProd;
        private Button buttonBack;
    }
}