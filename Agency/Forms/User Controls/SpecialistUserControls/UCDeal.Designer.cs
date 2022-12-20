namespace Agency.Forms.User_Controls
{
    partial class UCDeal
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
            this.lblNumDeal = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumDeal
            // 
            this.lblNumDeal.AutoSize = true;
            this.lblNumDeal.Location = new System.Drawing.Point(12, 11);
            this.lblNumDeal.Name = "lblNumDeal";
            this.lblNumDeal.Size = new System.Drawing.Size(82, 20);
            this.lblNumDeal.TabIndex = 0;
            this.lblNumDeal.Text = "Сделка № ";
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuyer.Location = new System.Drawing.Point(12, 54);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(128, 28);
            this.lblBuyer.TabIndex = 1;
            this.lblBuyer.Text = "Покупатель: ";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSpec.Location = new System.Drawing.Point(12, 103);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(129, 28);
            this.lblSpec.TabIndex = 2;
            this.lblSpec.Text = "Специалист: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Квартира: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(199, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(99, 20);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Дата сделки: ";
            // 
            // UCDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblBuyer);
            this.Controls.Add(this.lblNumDeal);
            this.Name = "UCDeal";
            this.Size = new System.Drawing.Size(703, 426);
            this.Load += new System.EventHandler(this.UCDeal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumDeal;
        private Label lblBuyer;
        private Label lblSpec;
        private Label label3;
        private Label lblDate;
    }
}
