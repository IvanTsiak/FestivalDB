namespace FestivalsBD
{
    partial class FinancingEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new Button();
            btnSave = new Button();
            label2 = new Label();
            label1 = new Label();
            cmbCompany = new ComboBox();
            cmbFestival = new ComboBox();
            label3 = new Label();
            txtAmount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtAmount).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(342, 256);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(242, 256);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 20;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 125);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 19;
            label2.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 17);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 17;
            label1.Text = "Company Name";
            // 
            // cmbCompany
            // 
            cmbCompany.FormattingEnabled = true;
            cmbCompany.Location = new Point(10, 40);
            cmbCompany.Name = "cmbCompany";
            cmbCompany.Size = new Size(151, 28);
            cmbCompany.TabIndex = 22;
            // 
            // cmbFestival
            // 
            cmbFestival.FormattingEnabled = true;
            cmbFestival.Location = new Point(10, 95);
            cmbFestival.Name = "cmbFestival";
            cmbFestival.Size = new Size(151, 28);
            cmbFestival.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 72);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 23;
            label3.Text = "Festival";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(10, 148);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(150, 27);
            txtAmount.TabIndex = 25;
            // 
            // FinancingEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 303);
            Controls.Add(txtAmount);
            Controls.Add(cmbFestival);
            Controls.Add(label3);
            Controls.Add(cmbCompany);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FinancingEditForm";
            Text = "FinancingEditForm";
            ((System.ComponentModel.ISupportInitialize)txtAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label label2;
        private Label label1;
        private ComboBox cmbCompany;
        private ComboBox cmbFestival;
        private Label label3;
        private NumericUpDown txtAmount;
    }
}