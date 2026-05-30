namespace FestivalsBD
{
    partial class TechWorkerEditForm
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
            cmbStaff = new ComboBox();
            txtShift = new TextBox();
            label3 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            txtSpecialization = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // cmbStaff
            // 
            cmbStaff.FormattingEnabled = true;
            cmbStaff.Location = new Point(10, 40);
            cmbStaff.Name = "cmbStaff";
            cmbStaff.Size = new Size(151, 28);
            cmbStaff.TabIndex = 53;
            // 
            // txtShift
            // 
            txtShift.Location = new Point(10, 95);
            txtShift.Name = "txtShift";
            txtShift.Size = new Size(230, 27);
            txtShift.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 72);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 51;
            label3.Text = "Shift";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(342, 256);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 50;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(242, 256);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 49;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 17);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 48;
            label1.Text = "Staff Id";
            // 
            // txtSpecialization
            // 
            txtSpecialization.Location = new Point(10, 151);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(230, 27);
            txtSpecialization.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 128);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 54;
            label2.Text = "Specialization";
            // 
            // TechWorkerEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 303);
            Controls.Add(txtSpecialization);
            Controls.Add(label2);
            Controls.Add(cmbStaff);
            Controls.Add(txtShift);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Name = "TechWorkerEditForm";
            Text = "TechWorkerEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStaff;
        private TextBox txtShift;
        private Label label3;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private TextBox txtSpecialization;
        private Label label2;
    }
}