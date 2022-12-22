namespace Agency
{
    partial class BuyerInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyerInterface));
            this.lblCurrPage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMyDeals = new System.Windows.Forms.Label();
            this.lblAddReq = new System.Windows.Forms.Label();
            this.lblMyReqs = new System.Windows.Forms.Label();
            this.lblAparts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrPage
            // 
            this.lblCurrPage.AutoSize = true;
            this.lblCurrPage.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrPage.Location = new System.Drawing.Point(216, 12);
            this.lblCurrPage.Name = "lblCurrPage";
            this.lblCurrPage.Size = new System.Drawing.Size(0, 35);
            this.lblCurrPage.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lblMyDeals);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.lblAddReq);
            this.panel1.Controls.Add(this.lblMyReqs);
            this.panel1.Controls.Add(this.lblAparts);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblProfile);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 50);
            this.panel1.TabIndex = 10;
            // 
            // lblMyDeals
            // 
            this.lblMyDeals.AutoSize = true;
            this.lblMyDeals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMyDeals.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMyDeals.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMyDeals.Location = new System.Drawing.Point(592, 12);
            this.lblMyDeals.Name = "lblMyDeals";
            this.lblMyDeals.Size = new System.Drawing.Size(80, 23);
            this.lblMyDeals.TabIndex = 9;
            this.lblMyDeals.Text = "Покупки";
            this.lblMyDeals.Click += new System.EventHandler(this.lblMyDeals_Click);
            // 
            // lblAddReq
            // 
            this.lblAddReq.AutoSize = true;
            this.lblAddReq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddReq.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddReq.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddReq.Location = new System.Drawing.Point(426, 12);
            this.lblAddReq.Name = "lblAddReq";
            this.lblAddReq.Size = new System.Drawing.Size(144, 23);
            this.lblAddReq.TabIndex = 7;
            this.lblAddReq.Text = "Добавить заявку";
            this.lblAddReq.Click += new System.EventHandler(this.lblAddReq_Click);
            // 
            // lblMyReqs
            // 
            this.lblMyReqs.AutoSize = true;
            this.lblMyReqs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMyReqs.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMyReqs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMyReqs.Location = new System.Drawing.Point(297, 12);
            this.lblMyReqs.Name = "lblMyReqs";
            this.lblMyReqs.Size = new System.Drawing.Size(105, 23);
            this.lblMyReqs.TabIndex = 6;
            this.lblMyReqs.Text = "Мои заявки";
            this.lblMyReqs.Click += new System.EventHandler(this.lblMyReqs_Click);
            // 
            // lblAparts
            // 
            this.lblAparts.AutoSize = true;
            this.lblAparts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAparts.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAparts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAparts.Location = new System.Drawing.Point(184, 12);
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
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agency";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProfile.Location = new System.Drawing.Point(698, 12);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(122, 23);
            this.lblProfile.TabIndex = 3;
            this.lblProfile.Text = "Мой профиль";
            this.lblProfile.Click += new System.EventHandler(this.lblProfile_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExit.Location = new System.Drawing.Point(845, 12);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(62, 23);
            this.lblExit.TabIndex = 8;
            this.lblExit.Text = "Выход";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // BuyerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCurrPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BuyerInterface";
            this.Text = "BuyerInterface";
            this.Load += new System.EventHandler(this.BuyerInterface_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblCurrPage;
        private Panel panel1;
        private Label label2;
        private Label lblProfile;
        private Label lblMyDeals;
        private Label lblExit;
        private Label lblAddReq;
        private Label lblMyReqs;
        private Label lblAparts;
    }
}