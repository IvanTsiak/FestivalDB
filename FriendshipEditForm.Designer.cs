namespace FestivalsBD
{
    partial class FriendshipEditForm
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
            cmbParticipant2 = new ComboBox();
            label3 = new Label();
            cmbParticipant1 = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbParticipant2
            // 
            cmbParticipant2.FormattingEnabled = true;
            cmbParticipant2.Location = new Point(10, 95);
            cmbParticipant2.Name = "cmbParticipant2";
            cmbParticipant2.Size = new Size(151, 28);
            cmbParticipant2.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 72);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 37;
            label3.Text = "Participant2";
            // 
            // cmbParticipant1
            // 
            cmbParticipant1.FormattingEnabled = true;
            cmbParticipant1.Location = new Point(10, 40);
            cmbParticipant1.Name = "cmbParticipant1";
            cmbParticipant1.Size = new Size(151, 28);
            cmbParticipant1.TabIndex = 36;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(342, 256);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(242, 256);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 34;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 17);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 33;
            label1.Text = "Participant1";
            // 
            // FriendshipEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 303);
            Controls.Add(cmbParticipant2);
            Controls.Add(label3);
            Controls.Add(cmbParticipant1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Name = "FriendshipEditForm";
            Text = "FriendshipEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbParticipant2;
        private Label label3;
        private ComboBox cmbParticipant1;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
    }
}