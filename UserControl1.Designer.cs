namespace EkzTest
{
    partial class UserControl1
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
            LBLName = new Label();
            DateLVL = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            DaysLBL = new Label();
            City = new Label();
            WiinerLBL = new Label();
            SuspendLayout();
            // 
            // LBLName
            // 
            LBLName.AutoSize = true;
            LBLName.Location = new Point(3, 16);
            LBLName.Name = "LBLName";
            LBLName.Size = new Size(38, 15);
            LBLName.TabIndex = 0;
            LBLName.Text = "label1";
            // 
            // DateLVL
            // 
            DateLVL.AutoSize = true;
            DateLVL.Location = new Point(3, 48);
            DateLVL.Name = "DateLVL";
            DateLVL.Size = new Size(38, 15);
            DateLVL.TabIndex = 1;
            DateLVL.Text = "label1";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // DaysLBL
            // 
            DaysLBL.AutoSize = true;
            DaysLBL.Location = new Point(3, 90);
            DaysLBL.Name = "DaysLBL";
            DaysLBL.Size = new Size(38, 15);
            DaysLBL.TabIndex = 2;
            DaysLBL.Text = "label1";
            // 
            // City
            // 
            City.AutoSize = true;
            City.Location = new Point(652, 90);
            City.Name = "City";
            City.Size = new Size(38, 15);
            City.TabIndex = 3;
            City.Text = "label1";
            // 
            // WiinerLBL
            // 
            WiinerLBL.AutoSize = true;
            WiinerLBL.Location = new Point(3, 133);
            WiinerLBL.Name = "WiinerLBL";
            WiinerLBL.Size = new Size(38, 15);
            WiinerLBL.TabIndex = 4;
            WiinerLBL.Text = "label1";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(WiinerLBL);
            Controls.Add(City);
            Controls.Add(DaysLBL);
            Controls.Add(DateLVL);
            Controls.Add(LBLName);
            ForeColor = SystemColors.ControlText;
            Name = "UserControl1";
            Size = new Size(927, 219);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLName;
        private Label DateLVL;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label DaysLBL;
        private Label City;
        private Label WiinerLBL;
    }
}
