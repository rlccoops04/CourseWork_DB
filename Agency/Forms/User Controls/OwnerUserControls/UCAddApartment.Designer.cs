namespace Agency.Forms.User_Controls
{
    partial class UCAddApartment
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
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLiveSpace = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.tbSpace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKadastrNom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbApartNom = new System.Windows.Forms.TextBox();
            this.tbHomeNom = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbYear
            // 
            this.tbYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbYear.Location = new System.Drawing.Point(452, 284);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(149, 27);
            this.tbYear.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(452, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 28);
            this.label7.TabIndex = 54;
            this.label7.Text = "Год постройки";
            // 
            // tbLiveSpace
            // 
            this.tbLiveSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLiveSpace.Location = new System.Drawing.Point(456, 59);
            this.tbLiveSpace.Name = "tbLiveSpace";
            this.tbLiveSpace.Size = new System.Drawing.Size(153, 27);
            this.tbLiveSpace.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(456, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 28);
            this.label6.TabIndex = 52;
            this.label6.Text = "Жилплощадь";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(279, 456);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(311, 58);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbPriceMax
            // 
            this.tbPriceMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPriceMax.Location = new System.Drawing.Point(279, 134);
            this.tbPriceMax.Name = "tbPriceMax";
            this.tbPriceMax.Size = new System.Drawing.Size(150, 27);
            this.tbPriceMax.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(279, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 28);
            this.label5.TabIndex = 49;
            this.label5.Text = "Цена, ₽";
            // 
            // cbFurniture
            // 
            this.cbFurniture.AutoSize = true;
            this.cbFurniture.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbFurniture.Location = new System.Drawing.Point(279, 418);
            this.cbFurniture.Name = "cbFurniture";
            this.cbFurniture.Size = new System.Drawing.Size(108, 32);
            this.cbFurniture.TabIndex = 48;
            this.cbFurniture.Text = "Мебель";
            this.cbFurniture.UseVisualStyleBackColor = true;
            // 
            // cbMetro
            // 
            this.cbMetro.AutoSize = true;
            this.cbMetro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbMetro.Location = new System.Drawing.Point(456, 418);
            this.cbMetro.Name = "cbMetro";
            this.cbMetro.Size = new System.Drawing.Size(96, 32);
            this.cbMetro.TabIndex = 47;
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
            this.cbType.Location = new System.Drawing.Point(279, 284);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(150, 28);
            this.cbType.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(279, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "Тип постройки";
            // 
            // tbRoomsMax
            // 
            this.tbRoomsMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRoomsMax.Location = new System.Drawing.Point(456, 133);
            this.tbRoomsMax.Name = "tbRoomsMax";
            this.tbRoomsMax.Size = new System.Drawing.Size(149, 27);
            this.tbRoomsMax.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(456, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 28);
            this.label3.TabIndex = 43;
            this.label3.Text = "Кол-во комнат";
            // 
            // tbFloorMax
            // 
            this.tbFloorMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFloorMax.Location = new System.Drawing.Point(279, 205);
            this.tbFloorMax.Name = "tbFloorMax";
            this.tbFloorMax.Size = new System.Drawing.Size(150, 27);
            this.tbFloorMax.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(279, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "Номер этажа";
            // 
            // tbSpace
            // 
            this.tbSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSpace.Location = new System.Drawing.Point(452, 205);
            this.tbSpace.Name = "tbSpace";
            this.tbSpace.Size = new System.Drawing.Size(153, 27);
            this.tbSpace.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(452, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "Площадь";
            // 
            // tbKadastrNom
            // 
            this.tbKadastrNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKadastrNom.Location = new System.Drawing.Point(279, 59);
            this.tbKadastrNom.Name = "tbKadastrNom";
            this.tbKadastrNom.Size = new System.Drawing.Size(150, 27);
            this.tbKadastrNom.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(279, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 28);
            this.label8.TabIndex = 56;
            this.label8.Text = "Кадастр. номер";
            // 
            // tbCity
            // 
            this.tbCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCity.Location = new System.Drawing.Point(279, 347);
            this.tbCity.Name = "tbCity";
            this.tbCity.PlaceholderText = "Город";
            this.tbCity.Size = new System.Drawing.Size(150, 27);
            this.tbCity.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(279, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 28);
            this.label9.TabIndex = 58;
            this.label9.Text = "Адрес";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(279, 529);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 60;
            // 
            // tbApartNom
            // 
            this.tbApartNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApartNom.Location = new System.Drawing.Point(452, 380);
            this.tbApartNom.Name = "tbApartNom";
            this.tbApartNom.PlaceholderText = "Квартира";
            this.tbApartNom.Size = new System.Drawing.Size(149, 27);
            this.tbApartNom.TabIndex = 61;
            // 
            // tbHomeNom
            // 
            this.tbHomeNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHomeNom.Location = new System.Drawing.Point(279, 380);
            this.tbHomeNom.Name = "tbHomeNom";
            this.tbHomeNom.PlaceholderText = "Дом";
            this.tbHomeNom.Size = new System.Drawing.Size(150, 27);
            this.tbHomeNom.TabIndex = 62;
            // 
            // tbStreet
            // 
            this.tbStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStreet.Location = new System.Drawing.Point(452, 347);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.PlaceholderText = "Улица";
            this.tbStreet.Size = new System.Drawing.Size(149, 27);
            this.tbStreet.TabIndex = 63;
            // 
            // UCAddApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.tbHomeNom);
            this.Controls.Add(this.tbApartNom);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbKadastrNom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbLiveSpace);
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
            this.Controls.Add(this.tbSpace);
            this.Controls.Add(this.label1);
            this.Name = "UCAddApartment";
            this.Size = new System.Drawing.Size(932, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbYear;
        private Label label7;
        private TextBox tbLiveSpace;
        private Label label6;
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
        private TextBox tbSpace;
        private Label label1;
        private TextBox tbKadastrNom;
        private Label label8;
        private TextBox tbCity;
        private Label label9;
        private Label lblResult;
        private TextBox tbApartNom;
        private TextBox tbHomeNom;
        private TextBox tbStreet;
    }
}
