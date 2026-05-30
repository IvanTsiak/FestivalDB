namespace FestivalsBD
{
    partial class StaffEditForm
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
            label2 = new Label();
            label1 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtPhone = new TextBox();
            SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 125);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 27;
            label2.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 17);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 26;
            label1.Text = "Company Name";
            // 
            // txtId
            // 
            txtId.Location = new Point(10, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(230, 27);
            txtId.TabIndex = 37;
            // 
            // txtName
            // 
            txtName.Location = new Point(10, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 27);
            txtName.TabIndex = 38;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(10, 148);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(230, 27);
            txtPhone.TabIndex = 39;
            // 
            // StaffEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 303);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StaffEditForm";
            Text = "StaffEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Button btnCancel;
        private Button btnSave;
        private Label label2;
        private Label label1;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtPhone;
    }
}