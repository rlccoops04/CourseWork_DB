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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrUserName = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnKatalog = new System.Windows.Forms.Button();
            this.btnSearchAparts = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.btnMyDeals = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCurrPage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrUserName
            // 
            this.lblCurrUserName.AutoSize = true;
            this.lblCurrUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrUserName.Location = new System.Drawing.Point(12, 118);
            this.lblCurrUserName.Name = "lblCurrUserName";
            this.lblCurrUserName.Size = new System.Drawing.Size(0, 23);
            this.lblCurrUserName.TabIndex = 1;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(12, 179);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(171, 53);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Мой профиль";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnKatalog
            // 
            this.btnKatalog.Location = new System.Drawing.Point(12, 238);
            this.btnKatalog.Name = "btnKatalog";
            this.btnKatalog.Size = new System.Drawing.Size(171, 53);
            this.btnKatalog.TabIndex = 3;
            this.btnKatalog.Text = "Каталог квартир";
            this.btnKatalog.UseVisualStyleBackColor = true;
            this.btnKatalog.Click += new System.EventHandler(this.btnKatalog_Click);
            // 
            // btnSearchAparts
            // 
            this.btnSearchAparts.Location = new System.Drawing.Point(12, 297);
            this.btnSearchAparts.Name = "btnSearchAparts";
            this.btnSearchAparts.Size = new System.Drawing.Size(171, 53);
            this.btnSearchAparts.TabIndex = 4;
            this.btnSearchAparts.Text = "Поиск квартиры по параметрам";
            this.btnSearchAparts.UseVisualStyleBackColor = true;
            this.btnSearchAparts.Click += new System.EventHandler(this.btnSearchAparts_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(12, 356);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(171, 53);
            this.btnRequest.TabIndex = 5;
            this.btnRequest.Text = "Мои заявки";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Location = new System.Drawing.Point(12, 415);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(171, 53);
            this.btnAddRequest.TabIndex = 6;
            this.btnAddRequest.Text = "Добавить заявку";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // btnMyDeals
            // 
            this.btnMyDeals.Location = new System.Drawing.Point(12, 474);
            this.btnMyDeals.Name = "btnMyDeals";
            this.btnMyDeals.Size = new System.Drawing.Size(171, 53);
            this.btnMyDeals.TabIndex = 7;
            this.btnMyDeals.Text = "Мои покупки";
            this.btnMyDeals.UseVisualStyleBackColor = true;
            this.btnMyDeals.Click += new System.EventHandler(this.btnMyDeals_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(12, 533);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 53);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // BuyerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 609);
            this.Controls.Add(this.lblCurrPage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMyDeals);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.btnSearchAparts);
            this.Controls.Add(this.btnKatalog);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblCurrUserName);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "BuyerInterface";
            this.Text = "BuyerInterface";
            this.Load += new System.EventHandler(this.BuyerInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCurrUserName;
        private Button btnProfile;
        private Button btnKatalog;
        private Button btnSearchAparts;
        private Button btnRequest;
        private Button btnAddRequest;
        private Button btnMyDeals;
        private Button btnExit;
        private Label lblCurrPage;
    }
}