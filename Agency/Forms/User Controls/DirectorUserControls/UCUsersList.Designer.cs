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
            this.tbFio = new System.Windows.Forms.TextBox();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.tbNomTel = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Покупатель",
            "Продавец",
            "Специалист"});
            this.cbRole.Location = new System.Drawing.Point(457, 54);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(157, 28);
            this.cbRole.TabIndex = 0;
            // 
            // tbID
            // 
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbID.Location = new System.Drawing.Point(131, 22);
            this.tbID.Name = "tbID";
            this.tbID.PlaceholderText = "Идентификатор";
            this.tbID.Size = new System.Drawing.Size(157, 27);
            this.tbID.TabIndex = 1;
            // 
            // tbFio
            // 
            this.tbFio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFio.Location = new System.Drawing.Point(131, 55);
            this.tbFio.Name = "tbFio";
            this.tbFio.PlaceholderText = "ФИО";
            this.tbFio.Size = new System.Drawing.Size(157, 27);
            this.tbFio.TabIndex = 2;
            // 
            // tbPassport
            // 
            this.tbPassport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassport.Location = new System.Drawing.Point(294, 22);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.PlaceholderText = "Паспортные данные";
            this.tbPassport.Size = new System.Drawing.Size(157, 27);
            this.tbPassport.TabIndex = 3;
            // 
            // tbNomTel
            // 
            this.tbNomTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNomTel.Location = new System.Drawing.Point(294, 55);
            this.tbNomTel.Name = "tbNomTel";
            this.tbNomTel.PlaceholderText = "Номер телефона";
            this.tbNomTel.Size = new System.Drawing.Size(157, 27);
            this.tbNomTel.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(457, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 50);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLogin.Location = new System.Drawing.Point(457, 22);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PlaceholderText = "Логин";
            this.tbLogin.Size = new System.Drawing.Size(157, 27);
            this.tbLogin.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 336);
            this.panel1.TabIndex = 7;
            // 
            // UCUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbNomTel);
            this.Controls.Add(this.tbPassport);
            this.Controls.Add(this.tbFio);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.cbRole);
            this.Name = "UCUsersList";
            this.Size = new System.Drawing.Size(725, 480);
            this.Load += new System.EventHandler(this.UCUsersList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbRole;
        private TextBox tbID;
        private TextBox tbFio;
        private TextBox tbPassport;
        private TextBox tbNomTel;
        private Button btnSearch;
        private TextBox tbLogin;
        private Panel panel1;
    }
}
