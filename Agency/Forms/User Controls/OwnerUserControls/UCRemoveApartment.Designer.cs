namespace Agency.Forms.User_Controls
{
    partial class UCRemoveApartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRemoveApartment));
            this.lblFurniture = new System.Windows.Forms.Label();
            this.lblMetro = new System.Windows.Forms.Label();
            this.lblLivespace = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMainInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFurniture
            // 
            this.lblFurniture.AutoSize = true;
            this.lblFurniture.Location = new System.Drawing.Point(197, 165);
            this.lblFurniture.Name = "lblFurniture";
            this.lblFurniture.Size = new System.Drawing.Size(70, 20);
            this.lblFurniture.TabIndex = 17;
            this.lblFurniture.Text = "Мебель: ";
            // 
            // lblMetro
            // 
            this.lblMetro.AutoSize = true;
            this.lblMetro.Location = new System.Drawing.Point(197, 146);
            this.lblMetro.Name = "lblMetro";
            this.lblMetro.Size = new System.Drawing.Size(61, 20);
            this.lblMetro.TabIndex = 16;
            this.lblMetro.Text = "Метро: ";
            // 
            // lblLivespace
            // 
            this.lblLivespace.AutoSize = true;
            this.lblLivespace.Location = new System.Drawing.Point(197, 126);
            this.lblLivespace.Name = "lblLivespace";
            this.lblLivespace.Size = new System.Drawing.Size(128, 20);
            this.lblLivespace.TabIndex = 15;
            this.lblLivespace.Text = "Жилая площадь: ";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(197, 106);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(118, 20);
            this.lblYear.TabIndex = 14;
            this.lblYear.Text = "Год постройки: ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(197, 86);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(120, 20);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Тип постройки: ";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(197, 59);
            this.lblAdress.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(0, 20);
            this.lblAdress.TabIndex = 12;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(197, 31);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 28);
            this.lblPrice.TabIndex = 11;
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMainInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMainInfo.Location = new System.Drawing.Point(197, 3);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(0, 28);
            this.lblMainInfo.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(565, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // UCRemoveApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblFurniture);
            this.Controls.Add(this.lblMetro);
            this.Controls.Add(this.lblLivespace);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMainInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCRemoveApartment";
            this.Size = new System.Drawing.Size(671, 198);
            this.Load += new System.EventHandler(this.UCRemoveApartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFurniture;
        private Label lblMetro;
        private Label lblLivespace;
        private Label lblYear;
        private Label lblType;
        private Label lblAdress;
        private Label lblPrice;
        private Label lblMainInfo;
        private PictureBox pictureBox1;
        private Button btnRemove;
    }
}
