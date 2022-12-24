namespace Agency.Forms.User_Controls.DirectorUserControls
{
    partial class UCAddNewUser
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbOWNER = new System.Windows.Forms.RadioButton();
            this.rbBuyer = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNomTel = new System.Windows.Forms.TextBox();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.rbSpecialist = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbOWNER
            // 
            this.rbOWNER.AutoSize = true;
            this.rbOWNER.Location = new System.Drawing.Point(360, 322);
            this.rbOWNER.Name = "rbOWNER";
            this.rbOWNER.Size = new System.Drawing.Size(100, 24);
            this.rbOWNER.TabIndex = 25;
            this.rbOWNER.TabStop = true;
            this.rbOWNER.Text = "Продавец";
            this.rbOWNER.UseVisualStyleBackColor = true;
            // 
            // rbBuyer
            // 
            this.rbBuyer.AutoSize = true;
            this.rbBuyer.Location = new System.Drawing.Point(360, 292);
            this.rbBuyer.Name = "rbBuyer";
            this.rbBuyer.Size = new System.Drawing.Size(111, 24);
            this.rbBuyer.TabIndex = 24;
            this.rbBuyer.TabStop = true;
            this.rbBuyer.Text = "Покупатель";
            this.rbBuyer.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(360, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(360, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Паспорт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(360, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Фамилия и имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(357, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Логин";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(357, 382);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(193, 46);
            this.btnReg.TabIndex = 18;
            this.btnReg.Text = "Зарегистрировать";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(357, 47);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(196, 27);
            this.tbLogin.TabIndex = 17;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(357, 153);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(196, 27);
            this.tbName.TabIndex = 16;
            // 
            // tbNomTel
            // 
            this.tbNomTel.Location = new System.Drawing.Point(357, 259);
            this.tbNomTel.Name = "tbNomTel";
            this.tbNomTel.Size = new System.Drawing.Size(196, 27);
            this.tbNomTel.TabIndex = 15;
            // 
            // tbPassport
            // 
            this.tbPassport.Location = new System.Drawing.Point(357, 206);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(196, 27);
            this.tbPassport.TabIndex = 14;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(357, 100);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(196, 27);
            this.tbPassword.TabIndex = 13;
            // 
            // rbSpecialist
            // 
            this.rbSpecialist.AutoSize = true;
            this.rbSpecialist.Location = new System.Drawing.Point(360, 352);
            this.rbSpecialist.Name = "rbSpecialist";
            this.rbSpecialist.Size = new System.Drawing.Size(112, 24);
            this.rbSpecialist.TabIndex = 26;
            this.rbSpecialist.TabStop = true;
            this.rbSpecialist.Text = "Специалист";
            this.rbSpecialist.UseVisualStyleBackColor = true;
            // 
            // UCAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.rbSpecialist);
            this.Controls.Add(this.rbOWNER);
            this.Controls.Add(this.rbBuyer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbNomTel);
            this.Controls.Add(this.tbPassport);
            this.Controls.Add(this.tbPassword);
            this.Name = "UCAddNewUser";
            this.Size = new System.Drawing.Size(920, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbOWNER;
        private RadioButton rbBuyer;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnReg;
        private TextBox tbLogin;
        private TextBox tbName;
        private TextBox tbNomTel;
        private TextBox tbPassport;
        private TextBox tbPassword;
        private RadioButton rbSpecialist;
    }
}
