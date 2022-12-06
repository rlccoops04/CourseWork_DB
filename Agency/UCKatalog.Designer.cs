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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAparts = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Свободные квартиры";
            // 
            // pnlAparts
            // 
            this.pnlAparts.AutoScroll = true;
            this.pnlAparts.Location = new System.Drawing.Point(0, 87);
            this.pnlAparts.Name = "pnlAparts";
            this.pnlAparts.Size = new System.Drawing.Size(750, 488);
            this.pnlAparts.TabIndex = 1;
            // 
            // UCKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAparts);
            this.Controls.Add(this.label1);
            this.Name = "UCKatalog";
            this.Size = new System.Drawing.Size(750, 575);
            this.Load += new System.EventHandler(this.UCKatalog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel pnlAparts;
    }
}
