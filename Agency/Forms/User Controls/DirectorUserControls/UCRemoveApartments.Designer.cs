namespace Agency.Forms.User_Controls.DirectorUserControls
{
    partial class UCRemoveApartments
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
            this.pnlAparts.Location = new System.Drawing.Point(3, 53);
            this.pnlAparts.Name = "pnlAparts";
            this.pnlAparts.Size = new System.Drawing.Size(910, 483);
            this.pnlAparts.TabIndex = 5;
            // 
            // lblfound
            // 
            this.lblfound.AutoSize = true;
            this.lblfound.BackColor = System.Drawing.Color.Transparent;
            this.lblfound.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblfound.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfound.Location = new System.Drawing.Point(12, 22);
            this.lblfound.Name = "lblfound";
            this.lblfound.Size = new System.Drawing.Size(190, 28);
            this.lblfound.TabIndex = 4;
            this.lblfound.Text = "Найдено квартир: ";
            // 
            // UCRemoveApartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnlAparts);
            this.Controls.Add(this.lblfound);
            this.Name = "UCRemoveApartments";
            this.Size = new System.Drawing.Size(920, 570);
            this.Load += new System.EventHandler(this.UCRemoveApartments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlAparts;
        private Label lblfound;
    }
}
