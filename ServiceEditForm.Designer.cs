namespace FestivalsBD
{
    partial class ServiceEditForm
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
            cmbFestival = new ComboBox();
            label3 = new Label();
            cmbStaff = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbFestival
            // 
            cmbFestival.FormattingEnabled = true;
            cmbFestival.Location = new Point(10, 95);
            cmbFestival.Name = "cmbFestival";
            cmbFestival.Size = new Size(151, 28);
            cmbFestival.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 72);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 31;
            label3.Text = "Festival";
            // 
            // cmbStaff
            // 
            cmbStaff.FormattingEnabled = true;
            cmbStaff.Location = new Point(10, 40);
            cmbStaff.Name = "cmbStaff";
            cmbStaff.Size = new Size(151, 28);
            cmbStaff.TabIndex = 30;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(342, 256);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(242, 256);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 28;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 17);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 26;
            label1.Text = "Staff";
            // 
            // ServiceEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 303);
            Controls.Add(cmbFestival);
            Controls.Add(label3);
            Controls.Add(cmbStaff);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Name = "ServiceEditForm";
            Text = "ServiceEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFestival;
        private Label label3;
        private ComboBox cmbStaff;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
    }
}