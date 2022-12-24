namespace Agency
{
    partial class SpecialistInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialistInterface));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMyProfile = new System.Windows.Forms.Label();
            this.lblMyDeals = new System.Windows.Forms.Label();
            this.lblReqs = new System.Windows.Forms.Label();
            this.lblAparts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lblMyProfile);
            this.panel1.Controls.Add(this.lblMyDeals);
            this.panel1.Controls.Add(this.lblReqs);
            this.panel1.Controls.Add(this.lblAparts);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 50);
            this.panel1.TabIndex = 21;
            // 
            // lblMyProfile
            // 
            this.lblMyProfile.AutoSize = true;
            this.lblMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMyProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMyProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMyProfile.Location = new System.Drawing.Point(681, 12);
            this.lblMyProfile.Name = "lblMyProfile";
            this.lblMyProfile.Size = new System.Drawing.Size(122, 23);
            this.lblMyProfile.TabIndex = 9;
            this.lblMyProfile.Text = "Мой профиль";
            this.lblMyProfile.Click += new System.EventHandler(this.MyProfile_Click);
            // 
            // lblMyDeals
            // 
            this.lblMyDeals.AutoSize = true;
            this.lblMyDeals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMyDeals.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMyDeals.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMyDeals.Location = new System.Drawing.Point(536, 12);
            this.lblMyDeals.Name = "lblMyDeals";
            this.lblMyDeals.Size = new System.Drawing.Size(107, 23);
            this.lblMyDeals.TabIndex = 7;
            this.lblMyDeals.Text = "Мои сделки";
            this.lblMyDeals.Click += new System.EventHandler(this.ShowMyDeals_Click);
            // 
            // lblReqs
            // 
            this.lblReqs.AutoSize = true;
            this.lblReqs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReqs.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReqs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReqs.Location = new System.Drawing.Point(430, 12);
            this.lblReqs.Name = "lblReqs";
            this.lblReqs.Size = new System.Drawing.Size(65, 23);
            this.lblReqs.TabIndex = 6;
            this.lblReqs.Text = "Заявки";
            this.lblReqs.Click += new System.EventHandler(this.ShowRequests_Click);
            // 
            // lblAparts
            // 
            this.lblAparts.AutoSize = true;
            this.lblAparts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAparts.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAparts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAparts.Location = new System.Drawing.Point(301, 12);
            this.lblAparts.Name = "lblAparts";
            this.lblAparts.Size = new System.Drawing.Size(88, 23);
            this.lblAparts.TabIndex = 5;
            this.lblAparts.Text = "Квартиры";
            this.lblAparts.Click += new System.EventHandler(this.ShowAparts_Click);
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
            this.lblExit.Location = new System.Drawing.Point(832, 12);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(62, 23);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "Выход";
            this.lblExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SpecialistInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(914, 609);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SpecialistInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Агенство недвижимости";
            this.Load += new System.EventHandler(this.SpecialistInterface_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label lblMyProfile;
        private Label lblMyDeals;
        private Label lblReqs;
        private Label lblAparts;
        private Label label2;
        private Label lblExit;
    }
}