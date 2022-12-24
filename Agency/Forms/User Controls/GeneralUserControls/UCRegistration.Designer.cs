namespace Agency
{
    partial class UCRegistration
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.tbNomTel = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbBuyer = new System.Windows.Forms.RadioButton();
            this.rbOWNER = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(86, 76);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(196, 27);
            this.tbPassword.TabIndex = 0;
            // 
            // tbPassport
            // 
            this.tbPassport.Location = new System.Drawing.Point(83, 235);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(196, 27);
            this.tbPassport.TabIndex = 1;
            // 
            // tbNomTel
            // 
            this.tbNomTel.Location = new System.Drawing.Point(83, 288);
            this.tbNomTel.Name = "tbNomTel";
            this.tbNomTel.Size = new System.Drawing.Size(196, 27);
            this.tbNomTel.TabIndex = 2;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(86, 129);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(196, 27);
            this.tbSurname.TabIndex = 3;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(86, 23);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(196, 27);
            this.tbLogin.TabIndex = 4;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(83, 381);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(193, 46);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(86, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(89, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(86, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Паспорт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(86, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номер телефона";
            // 
            // rbBuyer
            // 
            this.rbBuyer.AutoSize = true;
            this.rbBuyer.Location = new System.Drawing.Point(86, 321);
            this.rbBuyer.Name = "rbBuyer";
            this.rbBuyer.Size = new System.Drawing.Size(111, 24);
            this.rbBuyer.TabIndex = 11;
            this.rbBuyer.TabStop = true;
            this.rbBuyer.Text = "Покупатель";
            this.rbBuyer.UseVisualStyleBackColor = true;
            // 
            // rbOWNER
            // 
            this.rbOWNER.AutoSize = true;
            this.rbOWNER.Location = new System.Drawing.Point(86, 351);
            this.rbOWNER.Name = "rbOWNER";
            this.rbOWNER.Size = new System.Drawing.Size(100, 24);
            this.rbOWNER.TabIndex = 12;
            this.rbOWNER.TabStop = true;
            this.rbOWNER.Text = "Продавец";
            this.rbOWNER.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(89, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Имя";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(86, 182);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(196, 27);
            this.tbName.TabIndex = 13;
            // 
            // UCRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.rbOWNER);
            this.Controls.Add(this.rbBuyer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbNomTel);
            this.Controls.Add(this.tbPassport);
            this.Controls.Add(this.tbPassword);
            this.Name = "UCRegistration";
            this.Size = new System.Drawing.Size(282, 436);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbPassword;
        private TextBox tbPassport;
        private TextBox tbNomTel;
        private TextBox tbSurname;
        private TextBox tbLogin;
        private Button btnReg;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton rbBuyer;
        private RadioButton rbOWNER;
        private Label label6;
        private TextBox tbName;
    }
}
