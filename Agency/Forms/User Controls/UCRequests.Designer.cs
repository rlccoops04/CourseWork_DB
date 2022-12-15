namespace Agency.Forms.User_Controls
{
    partial class UCRequests
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
            this.panelReqs = new System.Windows.Forms.Panel();
            this.lblCountReqs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelReqs
            // 
            this.panelReqs.AutoScroll = true;
            this.panelReqs.Location = new System.Drawing.Point(0, 55);
            this.panelReqs.Name = "panelReqs";
            this.panelReqs.Size = new System.Drawing.Size(750, 448);
            this.panelReqs.TabIndex = 0;
            // 
            // lblCountReqs
            // 
            this.lblCountReqs.AutoSize = true;
            this.lblCountReqs.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCountReqs.Location = new System.Drawing.Point(0, 0);
            this.lblCountReqs.Name = "lblCountReqs";
            this.lblCountReqs.Size = new System.Drawing.Size(204, 32);
            this.lblCountReqs.TabIndex = 0;
            this.lblCountReqs.Text = "Найдено заявок: ";
            // 
            // UCRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCountReqs);
            this.Controls.Add(this.panelReqs);
            this.Name = "UCRequests";
            this.Size = new System.Drawing.Size(750, 503);
            this.Load += new System.EventHandler(this.UCRequests_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelReqs;
        private Label lblCountReqs;
    }
}
