namespace Agency.Forms.User_Controls
{
    partial class UCMyDeals
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
            this.pnlAparts = new System.Windows.Forms.Panel();
            this.lblfound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlAparts
            // 
            this.pnlAparts.AutoScroll = true;
            this.pnlAparts.Location = new System.Drawing.Point(0, 35);
            this.pnlAparts.Name = "pnlAparts";
            this.pnlAparts.Size = new System.Drawing.Size(750, 468);
            this.pnlAparts.TabIndex = 3;
            // 
            // lblfound
            // 
            this.lblfound.AutoSize = true;
            this.lblfound.BackColor = System.Drawing.Color.Transparent;
            this.lblfound.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfound.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfound.Location = new System.Drawing.Point(0, 0);
            this.lblfound.Name = "lblfound";
            this.lblfound.Size = new System.Drawing.Size(206, 32);
            this.lblfound.TabIndex = 2;
            this.lblfound.Text = "Найдено сделок: ";
            // 
            // UCMyDeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAparts);
            this.Controls.Add(this.lblfound);
            this.Name = "UCMyDeals";
            this.Size = new System.Drawing.Size(750, 503);
            this.Load += new System.EventHandler(this.UCMyDeals_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlAparts;
        private Label lblfound;
    }
}
