namespace Agency.Forms
{
    partial class OwnerInterface
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
            this.lblCurrPage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMyProfile = new System.Windows.Forms.Label();
            this.lblAddApart = new System.Windows.Forms.Label();
            this.lblMyAparts = new System.Windows.Forms.Label();
            this.lblAparts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrPage
            // 
            this.lblCurrPage.AutoSize = true;
            this.lblCurrPage.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrPage.Location = new System.Drawing.Point(212, 13);
            this.lblCurrPage.Name = "lblCurrPage";
            this.lblCurrPage.Size = new System.Drawing.Size(0, 35);
            this.lblCurrPage.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lblMyProfile);
            this.panel1.Controls.Add(this.lblAddApart);
            this.panel1.Controls.Add(this.lblMyAparts);
            this.panel1.Controls.Add(this.lblAparts);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 50);
            this.panel1.TabIndex = 20;
            // 
            // lblMyProfile
            // 
            this.lblMyProfile.AutoSize = true;
            this.lblMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMyProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMyProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMyProfile.Location = new System.Drawing.Point(665, 12);
            this.lblMyProfile.Name = "lblMyProfile";
            this.lblMyProfile.Size = new System.Drawing.Size(122, 23);
            this.lblMyProfile.TabIndex = 9;
            this.lblMyProfile.Text = "Мой профиль";
            this.lblMyProfile.Click += new System.EventHandler(this.lblMyProfile_Click);
            // 
            // lblAddApart
            // 
            this.lblAddApart.AutoSize = true;
            this.lblAddApart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddApart.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddApart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddApart.Location = new System.Drawing.Point(485, 12);
            this.lblAddApart.Name = "lblAddApart";
            this.lblAddApart.Size = new System.Drawing.Size(156, 23);
            this.lblAddApart.TabIndex = 7;
            this.lblAddApart.Text = "Продать квартиру";
            this.lblAddApart.Click += new System.EventHandler(this.lblAddApart_Click);
            // 
            // lblMyAparts
            // 
            this.lblMyAparts.AutoSize = true;
            this.lblMyAparts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMyAparts.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMyAparts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMyAparts.Location = new System.Drawing.Point(338, 12);
            this.lblMyAparts.Name = "lblMyAparts";
            this.lblMyAparts.Size = new System.Drawing.Size(128, 23);
            this.lblMyAparts.TabIndex = 6;
            this.lblMyAparts.Text = "Мои квартиры";
            this.lblMyAparts.Click += new System.EventHandler(this.lblMyAparts_Click);
            // 
            // lblAparts
            // 
            this.lblAparts.AutoSize = true;
            this.lblAparts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAparts.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAparts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAparts.Location = new System.Drawing.Point(221, 12);
            this.lblAparts.Name = "lblAparts";
            this.lblAparts.Size = new System.Drawing.Size(88, 23);
            this.lblAparts.TabIndex = 5;
            this.lblAparts.Text = "Квартиры";
            this.lblAparts.Click += new System.EventHandler(this.lblAparts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(16, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agency";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExit.Location = new System.Drawing.Point(811, 12);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(62, 23);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "Выход";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // OwnerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCurrPage);
            this.Name = "OwnerInterface";
            this.Text = "OwnerInterface";
            this.Load += new System.EventHandler(this.OwnerInterface_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCurrPage;
        private Panel panel1;
        private Label lblMyProfile;
        private Label lblAddApart;
        private Label lblMyAparts;
        private Label lblAparts;
        private Label label2;
        private Label lblExit;
    }
}