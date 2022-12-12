namespace Agency
{
    partial class UCKatalog
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
            this.lblfound = new System.Windows.Forms.Label();
            this.pnlAparts = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblfound
            // 
            this.lblfound.AutoSize = true;
            this.lblfound.BackColor = System.Drawing.Color.Transparent;
            this.lblfound.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfound.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfound.Location = new System.Drawing.Point(0, 0);
            this.lblfound.Name = "lblfound";
            this.lblfound.Size = new System.Drawing.Size(219, 32);
            this.lblfound.TabIndex = 0;
            this.lblfound.Text = "Найдено квартир: ";
            // 
            // pnlAparts
            // 
            this.pnlAparts.AutoScroll = true;
            this.pnlAparts.Location = new System.Drawing.Point(0, 35);
            this.pnlAparts.Name = "pnlAparts";
            this.pnlAparts.Size = new System.Drawing.Size(750, 468);
            this.pnlAparts.TabIndex = 1;
            // 
            // UCKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlAparts);
            this.Controls.Add(this.lblfound);
            this.Name = "UCKatalog";
            this.Size = new System.Drawing.Size(750, 503);
            this.Load += new System.EventHandler(this.UCKatalog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblfound;
        private Panel pnlAparts;
    }
}
