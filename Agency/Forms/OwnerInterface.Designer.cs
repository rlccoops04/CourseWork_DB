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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerInterface));
            this.lblCurrPage = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddApartment = new System.Windows.Forms.Button();
            this.btnMyAparts = new System.Windows.Forms.Button();
            this.btnSearchAparts = new System.Windows.Forms.Button();
            this.btnKatalog = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblCurrUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(12, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 53);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddApartment
            // 
            this.btnAddApartment.Location = new System.Drawing.Point(12, 415);
            this.btnAddApartment.Name = "btnAddApartment";
            this.btnAddApartment.Size = new System.Drawing.Size(171, 53);
            this.btnAddApartment.TabIndex = 16;
            this.btnAddApartment.Text = "Продать квартиру";
            this.btnAddApartment.UseVisualStyleBackColor = true;
            this.btnAddApartment.Click += new System.EventHandler(this.btnAddApartment_Click);
            // 
            // btnMyAparts
            // 
            this.btnMyAparts.Location = new System.Drawing.Point(12, 356);
            this.btnMyAparts.Name = "btnMyAparts";
            this.btnMyAparts.Size = new System.Drawing.Size(171, 53);
            this.btnMyAparts.TabIndex = 15;
            this.btnMyAparts.Text = "Мои квартиры";
            this.btnMyAparts.UseVisualStyleBackColor = true;
            this.btnMyAparts.Click += new System.EventHandler(this.btnMyAparts_Click);
            // 
            // btnSearchAparts
            // 
            this.btnSearchAparts.Location = new System.Drawing.Point(12, 297);
            this.btnSearchAparts.Name = "btnSearchAparts";
            this.btnSearchAparts.Size = new System.Drawing.Size(171, 53);
            this.btnSearchAparts.TabIndex = 14;
            this.btnSearchAparts.Text = "Поиск квартиры по параметрам";
            this.btnSearchAparts.UseVisualStyleBackColor = true;
            this.btnSearchAparts.Click += new System.EventHandler(this.btnSearchAparts_Click);
            // 
            // btnKatalog
            // 
            this.btnKatalog.Location = new System.Drawing.Point(12, 238);
            this.btnKatalog.Name = "btnKatalog";
            this.btnKatalog.Size = new System.Drawing.Size(171, 53);
            this.btnKatalog.TabIndex = 13;
            this.btnKatalog.Text = "Каталог квартир";
            this.btnKatalog.UseVisualStyleBackColor = true;
            this.btnKatalog.Click += new System.EventHandler(this.btnKatalog_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(12, 179);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(171, 53);
            this.btnProfile.TabIndex = 12;
            this.btnProfile.Text = "Мой профиль";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblCurrUserName
            // 
            this.lblCurrUserName.AutoSize = true;
            this.lblCurrUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrUserName.Location = new System.Drawing.Point(53, 124);
            this.lblCurrUserName.Name = "lblCurrUserName";
            this.lblCurrUserName.Size = new System.Drawing.Size(88, 23);
            this.lblCurrUserName.TabIndex = 11;
            this.lblCurrUserName.Text = "Продавец";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(36, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 108);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // OwnerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 609);
            this.Controls.Add(this.lblCurrPage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddApartment);
            this.Controls.Add(this.btnMyAparts);
            this.Controls.Add(this.btnSearchAparts);
            this.Controls.Add(this.btnKatalog);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblCurrUserName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OwnerInterface";
            this.Text = "OwnerInterface";
            this.Load += new System.EventHandler(this.OwnerInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCurrPage;
        private Button btnExit;
        private Button btnAddApartment;
        private Button btnMyAparts;
        private Button btnSearchAparts;
        private Button btnKatalog;
        private Button btnProfile;
        private Label lblCurrUserName;
        private PictureBox pictureBox1;
    }
}