namespace ТТ2 {
    partial class LoginForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.labelLogin = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registrationPage = new System.Windows.Forms.TabPage();
            this.labelLoginReg = new System.Windows.Forms.Label();
            this.closeButton2 = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.passwordBoxReg = new System.Windows.Forms.TextBox();
            this.loginBoxReg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.registrationPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.loginPage);
            this.tabControl1.Controls.Add(this.registrationPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(571, 365);
            this.tabControl1.TabIndex = 0;
            // 
            // loginPage
            // 
            this.loginPage.BackColor = System.Drawing.Color.SkyBlue;
            this.loginPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginPage.Controls.Add(this.labelLogin);
            this.loginPage.Controls.Add(this.closeButton);
            this.loginPage.Controls.Add(this.loginButton);
            this.loginPage.Controls.Add(this.passwordBox);
            this.loginPage.Controls.Add(this.loginBox);
            this.loginPage.Controls.Add(this.label2);
            this.loginPage.Controls.Add(this.label1);
            this.loginPage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginPage.ForeColor = System.Drawing.Color.SkyBlue;
            this.loginPage.Location = new System.Drawing.Point(4, 32);
            this.loginPage.Margin = new System.Windows.Forms.Padding(5);
            this.loginPage.Name = "loginPage";
            this.loginPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginPage.Size = new System.Drawing.Size(563, 329);
            this.loginPage.TabIndex = 0;
            this.loginPage.Text = "Авторизация";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.ForeColor = System.Drawing.Color.Crimson;
            this.labelLogin.Location = new System.Drawing.Point(146, 249);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(0, 23);
            this.labelLogin.TabIndex = 12;
            // 
            // closeButton
            // 
            this.closeButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.closeButton.Location = new System.Drawing.Point(337, 198);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(84, 32);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Выход";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.loginButton.Location = new System.Drawing.Point(146, 198);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(91, 32);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Вход";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.Location = new System.Drawing.Point(243, 137);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(178, 30);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(243, 75);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(178, 30);
            this.loginBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(107, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(107, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // registrationPage
            // 
            this.registrationPage.BackColor = System.Drawing.Color.SkyBlue;
            this.registrationPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registrationPage.Controls.Add(this.labelLoginReg);
            this.registrationPage.Controls.Add(this.closeButton2);
            this.registrationPage.Controls.Add(this.registrationButton);
            this.registrationPage.Controls.Add(this.passwordBoxReg);
            this.registrationPage.Controls.Add(this.loginBoxReg);
            this.registrationPage.Controls.Add(this.label3);
            this.registrationPage.Controls.Add(this.label4);
            this.registrationPage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registrationPage.Location = new System.Drawing.Point(4, 32);
            this.registrationPage.Name = "registrationPage";
            this.registrationPage.Padding = new System.Windows.Forms.Padding(3);
            this.registrationPage.Size = new System.Drawing.Size(563, 329);
            this.registrationPage.TabIndex = 1;
            this.registrationPage.Text = "Регистрация";
            // 
            // labelLoginReg
            // 
            this.labelLoginReg.AutoSize = true;
            this.labelLoginReg.ForeColor = System.Drawing.Color.Crimson;
            this.labelLoginReg.Location = new System.Drawing.Point(162, 254);
            this.labelLoginReg.Name = "labelLoginReg";
            this.labelLoginReg.Size = new System.Drawing.Size(0, 23);
            this.labelLoginReg.TabIndex = 13;
            // 
            // closeButton2
            // 
            this.closeButton2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.closeButton2.Location = new System.Drawing.Point(351, 198);
            this.closeButton2.Name = "closeButton2";
            this.closeButton2.Size = new System.Drawing.Size(84, 32);
            this.closeButton2.TabIndex = 9;
            this.closeButton2.Text = "Выход";
            this.closeButton2.UseVisualStyleBackColor = true;
            this.closeButton2.Click += new System.EventHandler(this.closeButton2_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.registrationButton.Location = new System.Drawing.Point(91, 198);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(212, 32);
            this.registrationButton.TabIndex = 8;
            this.registrationButton.Text = "Добавить пользователя";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // passwordBoxReg
            // 
            this.passwordBoxReg.Location = new System.Drawing.Point(237, 140);
            this.passwordBoxReg.Name = "passwordBoxReg";
            this.passwordBoxReg.PasswordChar = '*';
            this.passwordBoxReg.Size = new System.Drawing.Size(178, 30);
            this.passwordBoxReg.TabIndex = 7;
            this.passwordBoxReg.UseSystemPasswordChar = true;
            // 
            // loginBoxReg
            // 
            this.loginBoxReg.Location = new System.Drawing.Point(237, 78);
            this.loginBoxReg.Name = "loginBoxReg";
            this.loginBoxReg.Size = new System.Drawing.Size(178, 30);
            this.loginBoxReg.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(101, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(101, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Логин:";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(571, 365);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            this.registrationPage.ResumeLayout(false);
            this.registrationPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage loginPage;
        private System.Windows.Forms.TabPage registrationPage;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton2;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.TextBox passwordBoxReg;
        private System.Windows.Forms.TextBox loginBoxReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.Label labelLogin;
        public System.Windows.Forms.Label labelLoginReg;
    }
}

