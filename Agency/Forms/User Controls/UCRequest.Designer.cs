namespace Agency
{
    partial class UCRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblReqID = new System.Windows.Forms.Label();
            this.lblSpace = new System.Windows.Forms.Label();
            this.lblLiveSpace = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblCountRooms = new System.Windows.Forms.Label();
            this.lblYearBld = new System.Windows.Forms.Label();
            this.lblTypeBld = new System.Windows.Forms.Label();
            this.cbFurniture = new System.Windows.Forms.CheckBox();
            this.cbMetro = new System.Windows.Forms.CheckBox();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата запроса";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label2";
            // 
            // lblReqID
            // 
            this.lblReqID.AutoSize = true;
            this.lblReqID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReqID.Location = new System.Drawing.Point(133, 9);
            this.lblReqID.Name = "lblReqID";
            this.lblReqID.Size = new System.Drawing.Size(141, 23);
            this.lblReqID.TabIndex = 2;
            this.lblReqID.Text = "Номер запроса: ";
            // 
            // lblSpace
            // 
            this.lblSpace.AutoSize = true;
            this.lblSpace.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSpace.Location = new System.Drawing.Point(133, 52);
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(91, 23);
            this.lblSpace.TabIndex = 3;
            this.lblSpace.Text = "Площадь: ";
            // 
            // lblLiveSpace
            // 
            this.lblLiveSpace.AutoSize = true;
            this.lblLiveSpace.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLiveSpace.Location = new System.Drawing.Point(133, 75);
            this.lblLiveSpace.Name = "lblLiveSpace";
            this.lblLiveSpace.Size = new System.Drawing.Size(123, 23);
            this.lblLiveSpace.TabIndex = 4;
            this.lblLiveSpace.Text = "Жилплощадь: ";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFloor.Location = new System.Drawing.Point(133, 29);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(58, 23);
            this.lblFloor.TabIndex = 5;
            this.lblFloor.Text = "Этаж: ";
            // 
            // lblCountRooms
            // 
            this.lblCountRooms.AutoSize = true;
            this.lblCountRooms.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCountRooms.Location = new System.Drawing.Point(347, 6);
            this.lblCountRooms.Name = "lblCountRooms";
            this.lblCountRooms.Size = new System.Drawing.Size(135, 23);
            this.lblCountRooms.TabIndex = 6;
            this.lblCountRooms.Text = "Кол-во комнат: ";
            // 
            // lblYearBld
            // 
            this.lblYearBld.AutoSize = true;
            this.lblYearBld.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYearBld.Location = new System.Drawing.Point(348, 27);
            this.lblYearBld.Name = "lblYearBld";
            this.lblYearBld.Size = new System.Drawing.Size(134, 23);
            this.lblYearBld.TabIndex = 7;
            this.lblYearBld.Text = "Год постройки: ";
            // 
            // lblTypeBld
            // 
            this.lblTypeBld.AutoSize = true;
            this.lblTypeBld.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTypeBld.Location = new System.Drawing.Point(348, 52);
            this.lblTypeBld.Name = "lblTypeBld";
            this.lblTypeBld.Size = new System.Drawing.Size(136, 23);
            this.lblTypeBld.TabIndex = 8;
            this.lblTypeBld.Text = "Тип постройки: ";
            // 
            // cbFurniture
            // 
            this.cbFurniture.AutoSize = true;
            this.cbFurniture.Enabled = false;
            this.cbFurniture.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFurniture.Location = new System.Drawing.Point(563, 42);
            this.cbFurniture.Name = "cbFurniture";
            this.cbFurniture.Size = new System.Drawing.Size(93, 27);
            this.cbFurniture.TabIndex = 9;
            this.cbFurniture.Text = "Мебель";
            this.cbFurniture.UseVisualStyleBackColor = true;
            // 
            // cbMetro
            // 
            this.cbMetro.AutoSize = true;
            this.cbMetro.Enabled = false;
            this.cbMetro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMetro.Location = new System.Drawing.Point(563, 9);
            this.cbMetro.Name = "cbMetro";
            this.cbMetro.Size = new System.Drawing.Size(184, 27);
            this.cbMetro.TabIndex = 10;
            this.cbMetro.Text = "Доступность метро";
            this.cbMetro.UseVisualStyleBackColor = true;
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaxPrice.Location = new System.Drawing.Point(348, 75);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(149, 23);
            this.lblMaxPrice.TabIndex = 11;
            this.lblMaxPrice.Text = "Макс. стоимость: ";
            // 
            // UCRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.lblMaxPrice);
            this.Controls.Add(this.cbMetro);
            this.Controls.Add(this.cbFurniture);
            this.Controls.Add(this.lblTypeBld);
            this.Controls.Add(this.lblYearBld);
            this.Controls.Add(this.lblCountRooms);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.lblLiveSpace);
            this.Controls.Add(this.lblSpace);
            this.Controls.Add(this.lblReqID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Name = "UCRequest";
            this.Size = new System.Drawing.Size(745, 120);
            this.Load += new System.EventHandler(this.UCRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblDate;
        private Label lblReqID;
        private Label lblSpace;
        private Label lblLiveSpace;
        private Label lblFloor;
        private Label lblCountRooms;
        private Label lblYearBld;
        private Label lblTypeBld;
        private CheckBox cbFurniture;
        private CheckBox cbMetro;
        private Label lblMaxPrice;
    }
}
