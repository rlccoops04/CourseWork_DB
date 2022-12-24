namespace Agency.Forms.User_Controls
{
    partial class UCDealsDir
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
            this.panel = new System.Windows.Forms.Panel();
            this.lblfound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(7, 53);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(910, 483);
            this.panel.TabIndex = 7;
            // 
            // lblfound
            // 
            this.lblfound.AutoSize = true;
            this.lblfound.BackColor = System.Drawing.Color.Transparent;
            this.lblfound.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblfound.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfound.Location = new System.Drawing.Point(12, 22);
            this.lblfound.Name = "lblfound";
            this.lblfound.Size = new System.Drawing.Size(180, 28);
            this.lblfound.TabIndex = 6;
            this.lblfound.Text = "Найдено сделок: ";
            // 
            // UCDealsDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblfound);
            this.Name = "UCDealsDir";
            this.Size = new System.Drawing.Size(920, 570);
            this.Load += new System.EventHandler(this.UCDealsDir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel;
        private Label lblfound;
    }
}
