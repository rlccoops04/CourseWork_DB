namespace Agency.Forms.User_Controls
{
    partial class UCRequestsDir
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbBuyer = new System.Windows.Forms.ComboBox();
            this.cbSpecs = new System.Windows.Forms.ComboBox();
            this.lblAddNewReq = new System.Windows.Forms.Label();
            this.lblReqs = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.cbBuyer);
            this.panel1.Controls.Add(this.cbSpecs);
            this.panel1.Controls.Add(this.lblAddNewReq);
            this.panel1.Controls.Add(this.lblReqs);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 37);
            this.panel1.TabIndex = 24;
            // 
            // cbBuyer
            // 
            this.cbBuyer.FormattingEnabled = true;
            this.cbBuyer.Location = new System.Drawing.Point(639, 7);
            this.cbBuyer.Name = "cbBuyer";
            this.cbBuyer.Size = new System.Drawing.Size(151, 28);
            this.cbBuyer.TabIndex = 26;
            // 
            // cbSpecs
            // 
            this.cbSpecs.FormattingEnabled = true;
            this.cbSpecs.Location = new System.Drawing.Point(153, 6);
            this.cbSpecs.Name = "cbSpecs";
            this.cbSpecs.Size = new System.Drawing.Size(151, 28);
            this.cbSpecs.TabIndex = 25;
            // 
            // lblAddNewReq
            // 
            this.lblAddNewReq.AutoSize = true;
            this.lblAddNewReq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddNewReq.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddNewReq.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddNewReq.Location = new System.Drawing.Point(432, 7);
            this.lblAddNewReq.Name = "lblAddNewReq";
            this.lblAddNewReq.Size = new System.Drawing.Size(201, 23);
            this.lblAddNewReq.TabIndex = 11;
            this.lblAddNewReq.Text = "Добавить новую заявку";
            this.lblAddNewReq.Click += new System.EventHandler(this.lblAddNewReq_Click);
            // 
            // lblReqs
            // 
            this.lblReqs.AutoSize = true;
            this.lblReqs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReqs.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReqs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReqs.Location = new System.Drawing.Point(82, 7);
            this.lblReqs.Name = "lblReqs";
            this.lblReqs.Size = new System.Drawing.Size(65, 23);
            this.lblReqs.TabIndex = 10;
            this.lblReqs.Text = "Заявки";
            this.lblReqs.Click += new System.EventHandler(this.lblReqs_Click);
            // 
            // UCRequestsDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCRequestsDir";
            this.Size = new System.Drawing.Size(920, 570);
            this.Load += new System.EventHandler(this.UCRequestsDir_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblAddNewReq;
        private Label lblReqs;
        private ComboBox cbBuyer;
        private ComboBox cbSpecs;
    }
}
