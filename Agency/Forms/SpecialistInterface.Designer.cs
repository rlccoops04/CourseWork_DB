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
            this.btnMyDeals = new System.Windows.Forms.Button();
            this.btnReqs = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMyDeals
            // 
            this.btnMyDeals.Location = new System.Drawing.Point(12, 227);
            this.btnMyDeals.Name = "btnMyDeals";
            this.btnMyDeals.Size = new System.Drawing.Size(141, 46);
            this.btnMyDeals.TabIndex = 0;
            this.btnMyDeals.Text = "Мои сделки";
            this.btnMyDeals.UseVisualStyleBackColor = true;
            this.btnMyDeals.Click += new System.EventHandler(this.btnMyDeals_Click);
            // 
            // btnReqs
            // 
            this.btnReqs.Location = new System.Drawing.Point(12, 279);
            this.btnReqs.Name = "btnReqs";
            this.btnReqs.Size = new System.Drawing.Size(141, 49);
            this.btnReqs.TabIndex = 1;
            this.btnReqs.Text = "Заявки";
            this.btnReqs.UseVisualStyleBackColor = true;
            this.btnReqs.Click += new System.EventHandler(this.btnReqs_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(12, 175);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(141, 46);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Мой профиль";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 334);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 46);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(27, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 103);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Специалист";
            // 
            // SpecialistInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(996, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnReqs);
            this.Controls.Add(this.btnMyDeals);
            this.Name = "SpecialistInterface";
            this.Text = "SpecialistInterface";
            this.Load += new System.EventHandler(this.SpecialistInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMyDeals;
        private Button btnReqs;
        private Button btnProfile;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label label1;
    }
}