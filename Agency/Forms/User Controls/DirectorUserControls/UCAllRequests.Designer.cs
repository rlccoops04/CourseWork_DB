namespace Agency.Forms.User_Controls.DirectorUserControls
{
    partial class UCAllRequests
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
            this.btnReqs = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbChoiceSpec = new System.Windows.Forms.ComboBox();
            this.cbChoiceBuyer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnReqs
            // 
            this.btnReqs.Location = new System.Drawing.Point(80, 3);
            this.btnReqs.Name = "btnReqs";
            this.btnReqs.Size = new System.Drawing.Size(273, 29);
            this.btnReqs.TabIndex = 0;
            this.btnReqs.Text = "Запросы";
            this.btnReqs.UseVisualStyleBackColor = true;
            this.btnReqs.Click += new System.EventHandler(this.btnReqs_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить запрос";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbChoiceSpec
            // 
            this.cbChoiceSpec.FormattingEnabled = true;
            this.cbChoiceSpec.Location = new System.Drawing.Point(80, 38);
            this.cbChoiceSpec.Name = "cbChoiceSpec";
            this.cbChoiceSpec.Size = new System.Drawing.Size(273, 28);
            this.cbChoiceSpec.TabIndex = 2;
            this.cbChoiceSpec.Visible = false;
            this.cbChoiceSpec.SelectedIndexChanged += new System.EventHandler(this.cbChoiceSpec_SelectedIndexChanged);
            // 
            // cbChoiceBuyer
            // 
            this.cbChoiceBuyer.FormattingEnabled = true;
            this.cbChoiceBuyer.Location = new System.Drawing.Point(359, 38);
            this.cbChoiceBuyer.Name = "cbChoiceBuyer";
            this.cbChoiceBuyer.Size = new System.Drawing.Size(273, 28);
            this.cbChoiceBuyer.TabIndex = 3;
            // 
            // UCAllRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbChoiceBuyer);
            this.Controls.Add(this.cbChoiceSpec);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReqs);
            this.Name = "UCAllRequests";
            this.Size = new System.Drawing.Size(750, 550);
            this.Load += new System.EventHandler(this.UCAllRequests_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReqs;
        private Button button2;
        private ComboBox cbChoiceSpec;
        private ComboBox cbChoiceBuyer;
    }
}
