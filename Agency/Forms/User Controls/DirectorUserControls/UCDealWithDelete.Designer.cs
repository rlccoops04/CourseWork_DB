namespace Agency.Forms.User_Controls.DirectorUserControls
{
    partial class UCDealWithDelete
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.lblNumDeal = new System.Windows.Forms.Label();
            this.btnRemoveDeal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblDate.Location = new System.Drawing.Point(3, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(28, 20);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "от ";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.BackColor = System.Drawing.Color.Transparent;
            this.lblSpec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSpec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblSpec.Location = new System.Drawing.Point(600, 35);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(98, 20);
            this.lblSpec.TabIndex = 6;
            this.lblSpec.Text = "Специалист: ";
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuyer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblBuyer.Location = new System.Drawing.Point(600, 15);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(97, 20);
            this.lblBuyer.TabIndex = 5;
            this.lblBuyer.Text = "Покупатель: ";
            // 
            // lblNumDeal
            // 
            this.lblNumDeal.AutoSize = true;
            this.lblNumDeal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumDeal.Location = new System.Drawing.Point(3, 12);
            this.lblNumDeal.Name = "lblNumDeal";
            this.lblNumDeal.Size = new System.Drawing.Size(41, 28);
            this.lblNumDeal.TabIndex = 4;
            this.lblNumDeal.Text = "№ ";
            // 
            // btnRemoveDeal
            // 
            this.btnRemoveDeal.Location = new System.Drawing.Point(739, 58);
            this.btnRemoveDeal.Name = "btnRemoveDeal";
            this.btnRemoveDeal.Size = new System.Drawing.Size(137, 29);
            this.btnRemoveDeal.TabIndex = 8;
            this.btnRemoveDeal.Text = "Отменить сделку";
            this.btnRemoveDeal.UseVisualStyleBackColor = true;
            this.btnRemoveDeal.Click += new System.EventHandler(this.btnRemoveDeal_Click);
            // 
            // UCDealWithDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.btnRemoveDeal);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblBuyer);
            this.Controls.Add(this.lblNumDeal);
            this.Name = "UCDealWithDelete";
            this.Size = new System.Drawing.Size(879, 90);
            this.Load += new System.EventHandler(this.UCDealWithDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDate;
        private Label lblSpec;
        private Label lblBuyer;
        private Label lblNumDeal;
        private Button btnRemoveDeal;
    }
}
