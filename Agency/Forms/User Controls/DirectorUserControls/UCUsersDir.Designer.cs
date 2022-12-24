namespace Agency.Forms.User_Controls.DirectorUserControls
{
    partial class UCUsersDir
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
            this.lblRemoveUser = new System.Windows.Forms.Label();
            this.lblAddNewUser = new System.Windows.Forms.Label();
            this.lblUsersList = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lblRemoveUser);
            this.panel1.Controls.Add(this.lblAddNewUser);
            this.panel1.Controls.Add(this.lblUsersList);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 37);
            this.panel1.TabIndex = 23;
            // 
            // lblRemoveUser
            // 
            this.lblRemoveUser.AutoSize = true;
            this.lblRemoveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemoveUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRemoveUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRemoveUser.Location = new System.Drawing.Point(653, 7);
            this.lblRemoveUser.Name = "lblRemoveUser";
            this.lblRemoveUser.Size = new System.Drawing.Size(188, 23);
            this.lblRemoveUser.TabIndex = 12;
            this.lblRemoveUser.Text = "Удалить пользователя";
            this.lblRemoveUser.Click += new System.EventHandler(this.lblRemoveUser_Click);
            // 
            // lblAddNewUser
            // 
            this.lblAddNewUser.AutoSize = true;
            this.lblAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddNewUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddNewUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddNewUser.Location = new System.Drawing.Point(340, 7);
            this.lblAddNewUser.Name = "lblAddNewUser";
            this.lblAddNewUser.Size = new System.Drawing.Size(262, 23);
            this.lblAddNewUser.TabIndex = 11;
            this.lblAddNewUser.Text = "Добавить нового пользователя";
            this.lblAddNewUser.Click += new System.EventHandler(this.lblAddNewUser_Click);
            // 
            // lblUsersList
            // 
            this.lblUsersList.AutoSize = true;
            this.lblUsersList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsersList.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsersList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsersList.Location = new System.Drawing.Point(70, 7);
            this.lblUsersList.Name = "lblUsersList";
            this.lblUsersList.Size = new System.Drawing.Size(193, 23);
            this.lblUsersList.TabIndex = 10;
            this.lblUsersList.Text = "Список пользователей";
            this.lblUsersList.Click += new System.EventHandler(this.lblUsersList_Click);
            // 
            // UCAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Name = "UCAllUsers";
            this.Size = new System.Drawing.Size(920, 570);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label lblUsersList;
        private Label lblRemoveUser;
        private Label lblAddNewUser;
    }
}
