namespace Agency.Forms.User_Controls.DirectorUserControls
{
    partial class UCApartmentsDir
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRemoveApart = new System.Windows.Forms.Label();
            this.lblAddNewApart = new System.Windows.Forms.Label();
            this.lblApartsList = new System.Windows.Forms.Label();
            this.cbOwners = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.cbOwners);
            this.panel1.Controls.Add(this.lblRemoveApart);
            this.panel1.Controls.Add(this.lblAddNewApart);
            this.panel1.Controls.Add(this.lblApartsList);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 37);
            this.panel1.TabIndex = 24;
            // 
            // lblRemoveApart
            // 
            this.lblRemoveApart.AutoSize = true;
            this.lblRemoveApart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemoveApart.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRemoveApart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRemoveApart.Location = new System.Drawing.Point(741, 7);
            this.lblRemoveApart.Name = "lblRemoveApart";
            this.lblRemoveApart.Size = new System.Drawing.Size(151, 23);
            this.lblRemoveApart.TabIndex = 12;
            this.lblRemoveApart.Text = "Удалить квартиру";
            this.lblRemoveApart.Click += new System.EventHandler(this.lblRemoveApart_Click);
            // 
            // lblAddNewApart
            // 
            this.lblAddNewApart.AutoSize = true;
            this.lblAddNewApart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddNewApart.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddNewApart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddNewApart.Location = new System.Drawing.Point(235, 7);
            this.lblAddNewApart.Name = "lblAddNewApart";
            this.lblAddNewApart.Size = new System.Drawing.Size(221, 23);
            this.lblAddNewApart.TabIndex = 11;
            this.lblAddNewApart.Text = "Добавить новую квартиру";
            this.lblAddNewApart.Click += new System.EventHandler(this.lblAddNewApart_Click);
            // 
            // lblApartsList
            // 
            this.lblApartsList.AutoSize = true;
            this.lblApartsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblApartsList.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApartsList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblApartsList.Location = new System.Drawing.Point(23, 7);
            this.lblApartsList.Name = "lblApartsList";
            this.lblApartsList.Size = new System.Drawing.Size(137, 23);
            this.lblApartsList.TabIndex = 10;
            this.lblApartsList.Text = "Список квартир";
            this.lblApartsList.Click += new System.EventHandler(this.lblApartsList_Click);
            // 
            // cbOwners
            // 
            this.cbOwners.FormattingEnabled = true;
            this.cbOwners.Location = new System.Drawing.Point(462, 6);
            this.cbOwners.Name = "cbOwners";
            this.cbOwners.Size = new System.Drawing.Size(151, 28);
            this.cbOwners.TabIndex = 25;
            // 
            // UCAllApartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Name = "UCAllApartments";
            this.Size = new System.Drawing.Size(920, 570);
            this.Load += new System.EventHandler(this.UCAllApartments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblRemoveApart;
        private Label lblAddNewApart;
        private Label lblApartsList;
        private ComboBox cbOwners;
    }
}
