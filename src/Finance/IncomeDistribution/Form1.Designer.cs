namespace IncomeDistribution
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxInputData = new System.Windows.Forms.TextBox();
            this.textBoxFinancialCushion = new System.Windows.Forms.TextBox();
            this.textBoxMandatoryExpenses = new System.Windows.Forms.TextBox();
            this.textBoxCurrentExpenses = new System.Windows.Forms.TextBox();
            this.textBoxGoal = new System.Windows.Forms.TextBox();
            this.textBoxInvestment = new System.Windows.Forms.TextBox();
            this.buttonCalculat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the amount to be calculated";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(121, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Financial Cushion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 273);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Goal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(250, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Investment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mandatory Expenses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(243, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Current Expenses";
            // 
            // textBoxInputData
            // 
            this.textBoxInputData.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputData.Location = new System.Drawing.Point(16, 33);
            this.textBoxInputData.Name = "textBoxInputData";
            this.textBoxInputData.Size = new System.Drawing.Size(254, 29);
            this.textBoxInputData.TabIndex = 6;
            // 
            // textBoxFinancialCushion
            // 
            this.textBoxFinancialCushion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFinancialCushion.Location = new System.Drawing.Point(122, 117);
            this.textBoxFinancialCushion.Name = "textBoxFinancialCushion";
            this.textBoxFinancialCushion.ReadOnly = true;
            this.textBoxFinancialCushion.Size = new System.Drawing.Size(177, 29);
            this.textBoxFinancialCushion.TabIndex = 7;
            // 
            // textBoxMandatoryExpenses
            // 
            this.textBoxMandatoryExpenses.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMandatoryExpenses.Location = new System.Drawing.Point(29, 197);
            this.textBoxMandatoryExpenses.Name = "textBoxMandatoryExpenses";
            this.textBoxMandatoryExpenses.ReadOnly = true;
            this.textBoxMandatoryExpenses.Size = new System.Drawing.Size(192, 29);
            this.textBoxMandatoryExpenses.TabIndex = 8;
            // 
            // textBoxCurrentExpenses
            // 
            this.textBoxCurrentExpenses.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCurrentExpenses.Location = new System.Drawing.Point(247, 197);
            this.textBoxCurrentExpenses.Name = "textBoxCurrentExpenses";
            this.textBoxCurrentExpenses.ReadOnly = true;
            this.textBoxCurrentExpenses.Size = new System.Drawing.Size(147, 29);
            this.textBoxCurrentExpenses.TabIndex = 9;
            // 
            // textBoxGoal
            // 
            this.textBoxGoal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGoal.Location = new System.Drawing.Point(29, 297);
            this.textBoxGoal.Name = "textBoxGoal";
            this.textBoxGoal.ReadOnly = true;
            this.textBoxGoal.Size = new System.Drawing.Size(100, 29);
            this.textBoxGoal.TabIndex = 10;
            // 
            // textBoxInvestment
            // 
            this.textBoxInvestment.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInvestment.Location = new System.Drawing.Point(254, 297);
            this.textBoxInvestment.Name = "textBoxInvestment";
            this.textBoxInvestment.ReadOnly = true;
            this.textBoxInvestment.Size = new System.Drawing.Size(100, 29);
            this.textBoxInvestment.TabIndex = 11;
            // 
            // buttonCalculat
            // 
            this.buttonCalculat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculat.Location = new System.Drawing.Point(122, 389);
            this.buttonCalculat.Name = "buttonCalculat";
            this.buttonCalculat.Size = new System.Drawing.Size(142, 39);
            this.buttonCalculat.TabIndex = 12;
            this.buttonCalculat.Text = "Calculat";
            this.buttonCalculat.UseVisualStyleBackColor = true;
            this.buttonCalculat.Click += new System.EventHandler(this.buttonCalculat_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 459);
            this.Controls.Add(this.buttonCalculat);
            this.Controls.Add(this.textBoxInvestment);
            this.Controls.Add(this.textBoxGoal);
            this.Controls.Add(this.textBoxCurrentExpenses);
            this.Controls.Add(this.textBoxMandatoryExpenses);
            this.Controls.Add(this.textBoxFinancialCushion);
            this.Controls.Add(this.textBoxInputData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Finance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxInputData;
        private System.Windows.Forms.TextBox textBoxFinancialCushion;
        private System.Windows.Forms.TextBox textBoxMandatoryExpenses;
        private System.Windows.Forms.TextBox textBoxCurrentExpenses;
        private System.Windows.Forms.TextBox textBoxGoal;
        private System.Windows.Forms.TextBox textBoxInvestment;
        private System.Windows.Forms.Button buttonCalculat;
    }
}

