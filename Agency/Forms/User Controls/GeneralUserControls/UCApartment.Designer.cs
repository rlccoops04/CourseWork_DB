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
            this.lblMetro = new System.Windows.Forms.Label();
            this.lblFurniture = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(14, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMainInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMainInfo.Location = new System.Drawing.Point(208, 10);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(0, 28);
            this.lblMainInfo.TabIndex = 1;
            this.lblMainInfo.MouseEnter += new System.EventHandler(this.lblLivespace_MouseEnter);
            this.lblMainInfo.MouseLeave += new System.EventHandler(this.lblLivespace_MouseLeave);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(208, 38);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 28);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.MouseEnter += new System.EventHandler(this.lblLivespace_MouseEnter);
            this.lblPrice.MouseLeave += new System.EventHandler(this.lblLivespace_MouseLeave);
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdress.Location = new System.Drawing.Point(208, 66);
            this.lblAdress.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(0, 20);
            this.lblAdress.TabIndex = 3;
            this.lblAdress.MouseEnter += new System.EventHandler(this.lblLivespace_MouseEnter);
            this.lblAdress.MouseLeave += new System.EventHandler(this.lblLivespace_MouseLeave);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(208, 93);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(121, 20);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Тип постройки: ";
            this.lblType.MouseEnter += new System.EventHandler(this.lblLivespace_MouseEnter);
            this.lblType.MouseLeave += new System.EventHandler(this.lblLivespace_MouseLeave);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(208, 113);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(120, 20);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Год постройки: ";
            this.lblYear.MouseEnter += new System.EventHandler(this.lblLivespace_MouseEnter);
            this.lblYear.MouseLeave += new System.EventHandler(this.lblLivespace_MouseLeave);
            // 
            // lblLivespace
            // 
            this.lblLivespace.AutoSize = true;
            this.lblLivespace.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLivespace.Location = new System.Drawing.Point(208, 133);
            this.lblLivespace.Name = "lblLivespace";
            this.lblLivespace.Size = new System.Drawing.Size(132, 20);
            this.lblLivespace.TabIndex = 6;
            this.lblLivespace.Text = "Жилая площадь: ";
            this.lblLivespace.MouseEnter += new System.EventHandler(this.lblLivespace_MouseEnter);
            this.lblLivespace.MouseLeave += new System.EventHandler(this.lblLivespace_MouseLeave);
            // 
            // lblMetro
            // 
            this.lblMetro.AutoSize = true;
            this.lblMetro.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetro.Location = new System.Drawing.Point(208, 153);
            this.lblMetro.Name = "lblMetro";
            this.lblMetro.Size = new System.Drawing.Size(63, 20);
            this.lblMetro.TabIndex = 7;
            this.lblMetro.Text = "Метро: ";
            // 
            // lblFurniture
            // 
            this.lblFurniture.AutoSize = true;
            this.lblFurniture.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFurniture.Location = new System.Drawing.Point(208, 172);
            this.lblFurniture.Name = "lblFurniture";
            this.lblFurniture.Size = new System.Drawing.Size(72, 20);
            this.lblFurniture.TabIndex = 8;
            this.lblFurniture.Text = "Мебель: ";
            // 
            // UCApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.lblFurniture);
            this.Controls.Add(this.lblMetro);
            this.Controls.Add(this.lblLivespace);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMainInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCApartment";
            this.Size = new System.Drawing.Size(879, 198);
            this.Load += new System.EventHandler(this.UCApartment_Load);
            this.MouseEnter += new System.EventHandler(this.UCApartment_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCApartment_MouseLeave);
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
        private Label lblMetro;
        private Label lblFurniture;
    }
}
