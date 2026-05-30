namespace FestivalsBD
{
    partial class LeaderEditForm
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
            label3 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            txtArea = new TextBox();
            cmbStaff = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 80);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 44;
            label3.Text = "Area";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(342, 264);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(242, 264);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 42;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 25);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 40;
            label1.Text = "Staff Id";
            // 
            // txtArea
            // 
            txtArea.Location = new Point(10, 103);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(230, 27);
            txtArea.TabIndex = 46;
            // 
            // cmbStaff
            // 
            cmbStaff.FormattingEnabled = true;
            cmbStaff.Location = new Point(10, 48);
            cmbStaff.Name = "cmbStaff";
            cmbStaff.Size = new Size(151, 28);
            cmbStaff.TabIndex = 47;
            // 
            // LeaderEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 318);
            Controls.Add(cmbStaff);
            Controls.Add(txtArea);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Name = "LeaderEditForm";
            Text = "LeaderEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private TextBox txtArea;
        private ComboBox cmbStaff;
    }
}