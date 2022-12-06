namespace Agency
{
    partial class UCApartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCApartment));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMainInfo = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblLivespace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(14, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMainInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMainInfo.Location = new System.Drawing.Point(208, 10);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(0, 28);
            this.lblMainInfo.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(208, 38);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 28);
            this.lblPrice.TabIndex = 2;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(208, 66);
            this.lblAdress.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(0, 20);
            this.lblAdress.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(208, 106);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(120, 20);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Тип постройки: ";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(208, 126);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(118, 20);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Год постройки: ";
            // 
            // lblLivespace
            // 
            this.lblLivespace.AutoSize = true;
            this.lblLivespace.Location = new System.Drawing.Point(208, 146);
            this.lblLivespace.Name = "lblLivespace";
            this.lblLivespace.Size = new System.Drawing.Size(128, 20);
            this.lblLivespace.TabIndex = 6;
            this.lblLivespace.Text = "Жилая площадь: ";
            // 
            // UCApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblLivespace);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMainInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCApartment";
            this.Size = new System.Drawing.Size(725, 198);
            this.Load += new System.EventHandler(this.UCApartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblMainInfo;
        private Label lblPrice;
        private Label lblAdress;
        private Label lblType;
        private Label lblYear;
        private Label lblLivespace;
    }
}
