namespace Agency
{
    partial class UCSearchApartments
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
            this.tbSpace1 = new System.Windows.Forms.TextBox();
            this.tbSpace2 = new System.Windows.Forms.TextBox();
            this.tbFloorMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFloorMax = new System.Windows.Forms.TextBox();
            this.tbRoomsMax = new System.Windows.Forms.TextBox();
            this.tbRoomsMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbMetro = new System.Windows.Forms.CheckBox();
            this.cbFurniture = new System.Windows.Forms.CheckBox();
            this.tbPriceMax = new System.Windows.Forms.TextBox();
            this.tbPriceMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Площадь";
            // 
            // tbSpace1
            // 
            this.tbSpace1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSpace1.Location = new System.Drawing.Point(17, 41);
            this.tbSpace1.Name = "tbSpace1";
            this.tbSpace1.PlaceholderText = "от";
            this.tbSpace1.Size = new System.Drawing.Size(38, 27);
            this.tbSpace1.TabIndex = 1;
            // 
            // tbSpace2
            // 
            this.tbSpace2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSpace2.Location = new System.Drawing.Point(73, 41);
            this.tbSpace2.Name = "tbSpace2";
            this.tbSpace2.PlaceholderText = "до";
            this.tbSpace2.Size = new System.Drawing.Size(40, 27);
            this.tbSpace2.TabIndex = 2;
            // 
            // tbFloorMin
            // 
            this.tbFloorMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFloorMin.Location = new System.Drawing.Point(173, 41);
            this.tbFloorMin.Name = "tbFloorMin";
            this.tbFloorMin.PlaceholderText = "от";
            this.tbFloorMin.Size = new System.Drawing.Size(57, 27);
            this.tbFloorMin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(173, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер этажа";
            // 
            // tbFloorMax
            // 
            this.tbFloorMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFloorMax.Location = new System.Drawing.Point(236, 41);
            this.tbFloorMax.Name = "tbFloorMax";
            this.tbFloorMax.PlaceholderText = "до";
            this.tbFloorMax.Size = new System.Drawing.Size(68, 27);
            this.tbFloorMax.TabIndex = 5;
            // 
            // tbRoomsMax
            // 
            this.tbRoomsMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRoomsMax.Location = new System.Drawing.Point(432, 41);
            this.tbRoomsMax.Name = "tbRoomsMax";
            this.tbRoomsMax.PlaceholderText = "до";
            this.tbRoomsMax.Size = new System.Drawing.Size(74, 27);
            this.tbRoomsMax.TabIndex = 8;
            // 
            // tbRoomsMin
            // 
            this.tbRoomsMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRoomsMin.Location = new System.Drawing.Point(357, 41);
            this.tbRoomsMin.Name = "tbRoomsMin";
            this.tbRoomsMin.PlaceholderText = "от";
            this.tbRoomsMin.Size = new System.Drawing.Size(69, 27);
            this.tbRoomsMin.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(357, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кол-во комнат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(564, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тип постройки";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Кирпич",
            "Монолит",
            "Панель"});
            this.cbType.Location = new System.Drawing.Point(564, 41);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(150, 28);
            this.cbType.TabIndex = 10;
            // 
            // cbMetro
            // 
            this.cbMetro.AutoSize = true;
            this.cbMetro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMetro.Location = new System.Drawing.Point(291, 123);
            this.cbMetro.Name = "cbMetro";
            this.cbMetro.Size = new System.Drawing.Size(94, 32);
            this.cbMetro.TabIndex = 12;
            this.cbMetro.Text = "Метро";
            this.cbMetro.UseVisualStyleBackColor = true;
            // 
            // cbFurniture
            // 
            this.cbFurniture.AutoSize = true;
            this.cbFurniture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFurniture.Location = new System.Drawing.Point(291, 93);
            this.cbFurniture.Name = "cbFurniture";
            this.cbFurniture.Size = new System.Drawing.Size(105, 32);
            this.cbFurniture.TabIndex = 13;
            this.cbFurniture.Text = "Мебель";
            this.cbFurniture.UseVisualStyleBackColor = true;
            // 
            // tbPriceMax
            // 
            this.tbPriceMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPriceMax.Location = new System.Drawing.Point(115, 128);
            this.tbPriceMax.Name = "tbPriceMax";
            this.tbPriceMax.PlaceholderText = "до";
            this.tbPriceMax.Size = new System.Drawing.Size(96, 27);
            this.tbPriceMax.TabIndex = 16;
            // 
            // tbPriceMin
            // 
            this.tbPriceMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPriceMin.Location = new System.Drawing.Point(17, 128);
            this.tbPriceMin.Name = "tbPriceMin";
            this.tbPriceMin.PlaceholderText = "от";
            this.tbPriceMin.Size = new System.Drawing.Size(96, 27);
            this.tbPriceMin.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Цена, ₽";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(498, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(216, 58);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(0, 185);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(750, 318);
            this.panel.TabIndex = 18;
            // 
            // UCSearchApartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbPriceMax);
            this.Controls.Add(this.tbPriceMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFurniture);
            this.Controls.Add(this.cbMetro);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRoomsMax);
            this.Controls.Add(this.tbRoomsMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFloorMax);
            this.Controls.Add(this.tbFloorMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSpace2);
            this.Controls.Add(this.tbSpace1);
            this.Controls.Add(this.label1);
            this.Name = "UCSearchApartments";
            this.Size = new System.Drawing.Size(750, 503);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbSpace1;
        private TextBox tbSpace2;
        private TextBox tbFloorMin;
        private Label label2;
        private TextBox tbFloorMax;
        private TextBox tbRoomsMax;
        private TextBox tbRoomsMin;
        private Label label3;
        private Label label4;
        private ComboBox cbType;
        private CheckBox cbMetro;
        private CheckBox cbFurniture;
        private TextBox tbPriceMax;
        private TextBox tbPriceMin;
        private Label label5;
        private Button btnSearch;
        private Panel panel;
    }
}
