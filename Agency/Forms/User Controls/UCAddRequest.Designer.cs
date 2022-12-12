namespace Agency.Forms.User_Controls
{
    partial class UCAddRequest
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPriceMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFurniture = new System.Windows.Forms.CheckBox();
            this.cbMetro = new System.Windows.Forms.CheckBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRoomsMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFloorMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSpace2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSpace1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(572, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 58);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbPriceMax
            // 
            this.tbPriceMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPriceMax.Location = new System.Drawing.Point(181, 134);
            this.tbPriceMax.Name = "tbPriceMax";
            this.tbPriceMax.PlaceholderText = "до";
            this.tbPriceMax.Size = new System.Drawing.Size(131, 27);
            this.tbPriceMax.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(181, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 31;
            this.label5.Text = "Цена, ₽";
            // 
            // cbFurniture
            // 
            this.cbFurniture.AutoSize = true;
            this.cbFurniture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFurniture.Location = new System.Drawing.Point(572, 101);
            this.cbFurniture.Name = "cbFurniture";
            this.cbFurniture.Size = new System.Drawing.Size(105, 32);
            this.cbFurniture.TabIndex = 30;
            this.cbFurniture.Text = "Мебель";
            this.cbFurniture.UseVisualStyleBackColor = true;
            // 
            // cbMetro
            // 
            this.cbMetro.AutoSize = true;
            this.cbMetro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMetro.Location = new System.Drawing.Point(572, 131);
            this.cbMetro.Name = "cbMetro";
            this.cbMetro.Size = new System.Drawing.Size(94, 32);
            this.cbMetro.TabIndex = 29;
            this.cbMetro.Text = "Метро";
            this.cbMetro.UseVisualStyleBackColor = true;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Кирпич",
            "Монолит",
            "Панель"});
            this.cbType.Location = new System.Drawing.Point(572, 47);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(150, 28);
            this.cbType.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(572, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Тип постройки";
            // 
            // tbRoomsMax
            // 
            this.tbRoomsMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRoomsMax.Location = new System.Drawing.Point(365, 47);
            this.tbRoomsMax.Name = "tbRoomsMax";
            this.tbRoomsMax.Size = new System.Drawing.Size(149, 27);
            this.tbRoomsMax.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(365, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Кол-во комнат";
            // 
            // tbFloorMax
            // 
            this.tbFloorMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFloorMax.Location = new System.Drawing.Point(181, 47);
            this.tbFloorMax.Name = "tbFloorMax";
            this.tbFloorMax.Size = new System.Drawing.Size(131, 27);
            this.tbFloorMax.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(181, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Номер этажа";
            // 
            // tbSpace2
            // 
            this.tbSpace2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSpace2.Location = new System.Drawing.Point(25, 47);
            this.tbSpace2.Name = "tbSpace2";
            this.tbSpace2.Size = new System.Drawing.Size(96, 27);
            this.tbSpace2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Площадь";
            // 
            // tbSpace1
            // 
            this.tbSpace1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSpace1.Location = new System.Drawing.Point(25, 134);
            this.tbSpace1.Name = "tbSpace1";
            this.tbSpace1.Size = new System.Drawing.Size(105, 27);
            this.tbSpace1.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 28);
            this.label6.TabIndex = 35;
            this.label6.Text = "Жилплощадь";
            // 
            // tbYear
            // 
            this.tbYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbYear.Location = new System.Drawing.Point(365, 134);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(131, 27);
            this.tbYear.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(365, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 28);
            this.label7.TabIndex = 37;
            this.label7.Text = "Год постройки";
            // 
            // UCAddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSpace1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPriceMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFurniture);
            this.Controls.Add(this.cbMetro);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRoomsMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFloorMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSpace2);
            this.Controls.Add(this.label1);
            this.Name = "UCAddRequest";
            this.Size = new System.Drawing.Size(750, 248);
            this.Load += new System.EventHandler(this.UCAddRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private TextBox tbPriceMax;
        private Label label5;
        private CheckBox cbFurniture;
        private CheckBox cbMetro;
        private ComboBox cbType;
        private Label label4;
        private TextBox tbRoomsMax;
        private Label label3;
        private TextBox tbFloorMax;
        private Label label2;
        private TextBox tbSpace2;
        private Label label1;
        private TextBox tbSpace1;
        private Label label6;
        private TextBox tbYear;
        private Label label7;
    }
}
