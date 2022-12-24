namespace Agency.Forms.User_Controls.DirectorUserControls
{
    partial class UCUsersList
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
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.tbNomTel = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Покупатель",
            "Продавец",
            "Специалист"});
            this.cbRole.Location = new System.Drawing.Point(555, 35);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(157, 28);
            this.cbRole.TabIndex = 0;
            // 
            // tbID
            // 
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbID.Location = new System.Drawing.Point(23, 0);
            this.tbID.Name = "tbID";
            this.tbID.PlaceholderText = "Идентификатор";
            this.tbID.Size = new System.Drawing.Size(157, 27);
            this.tbID.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(186, 36);
            this.tbName.Name = "tbName";
            this.tbName.PlaceholderText = "Имя";
            this.tbName.Size = new System.Drawing.Size(157, 27);
            this.tbName.TabIndex = 2;
            // 
            // tbPassport
            // 
            this.tbPassport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassport.Location = new System.Drawing.Point(371, 3);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.PlaceholderText = "Паспортные данные";
            this.tbPassport.Size = new System.Drawing.Size(157, 27);
            this.tbPassport.TabIndex = 3;
            // 
            // tbNomTel
            // 
            this.tbNomTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNomTel.Location = new System.Drawing.Point(371, 36);
            this.tbNomTel.Name = "tbNomTel";
            this.tbNomTel.PlaceholderText = "Номер телефона";
            this.tbNomTel.Size = new System.Drawing.Size(157, 27);
            this.tbNomTel.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(734, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 60);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLogin.Location = new System.Drawing.Point(555, 3);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PlaceholderText = "Логин";
            this.tbLogin.Size = new System.Drawing.Size(157, 27);
            this.tbLogin.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 474);
            this.panel1.TabIndex = 7;
            // 
            // tbSurname
            // 
            this.tbSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSurname.Location = new System.Drawing.Point(186, 0);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.PlaceholderText = "Фамилия";
            this.tbSurname.Size = new System.Drawing.Size(157, 27);
            this.tbSurname.TabIndex = 8;
            // 
            // UCUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbNomTel);
            this.Controls.Add(this.tbPassport);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.cbRole);
            this.Name = "UCUsersList";
            this.Size = new System.Drawing.Size(920, 570);
            this.Load += new System.EventHandler(this.UCUsersList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbRole;
        private TextBox tbID;
        private TextBox tbName;
        private TextBox tbPassport;
        private TextBox tbNomTel;
        private Button btnSearch;
        private TextBox tbLogin;
        private Panel panel1;
        private TextBox tbSurname;
    }
}
