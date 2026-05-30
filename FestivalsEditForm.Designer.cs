namespace FestivalsBD
{
    partial class FestivalsEditForm
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
            txtTheme = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            dtpStartDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            dtpEndDate = new DateTimePicker();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(343, 262);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(243, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 186);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 9;
            label2.Text = "Theme";
            // 
            // txtTheme
            // 
            txtTheme.Location = new Point(11, 209);
            txtTheme.Name = "txtTheme";
            txtTheme.Size = new Size(230, 27);
            txtTheme.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 23);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(11, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 27);
            txtName.TabIndex = 6;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(11, 98);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 75);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 13;
            label3.Text = "Start date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 131);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 15;
            label4.Text = "End date";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(11, 154);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 14;
            // 
            // FestivalsEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 303);
            Controls.Add(label4);
            Controls.Add(dtpEndDate);
            Controls.Add(label3);
            Controls.Add(dtpStartDate);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(txtTheme);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "FestivalsEditForm";
            Text = "FestivalsEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label label2;
        private TextBox txtTheme;
        private Label label1;
        private TextBox txtName;
        private DateTimePicker dtpStartDate;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpEndDate;
    }
}