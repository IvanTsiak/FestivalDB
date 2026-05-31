namespace FestivalsBD
{
    partial class PerfomanceEditForm
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
            cmbStage = new ComboBox();
            label3 = new Label();
            cmbEvent = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            cmbParticipant = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // cmbStage
            // 
            cmbStage.FormattingEnabled = true;
            cmbStage.Location = new Point(10, 95);
            cmbStage.Name = "cmbStage";
            cmbStage.Size = new Size(151, 28);
            cmbStage.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 72);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 37;
            label3.Text = "Stage";
            // 
            // cmbEvent
            // 
            cmbEvent.FormattingEnabled = true;
            cmbEvent.Location = new Point(10, 40);
            cmbEvent.Name = "cmbEvent";
            cmbEvent.Size = new Size(151, 28);
            cmbEvent.TabIndex = 36;
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
            label1.Size = new Size(45, 20);
            label1.TabIndex = 33;
            label1.Text = "Event";
            // 
            // cmbParticipant
            // 
            cmbParticipant.FormattingEnabled = true;
            cmbParticipant.Location = new Point(10, 151);
            cmbParticipant.Name = "cmbParticipant";
            cmbParticipant.Size = new Size(151, 28);
            cmbParticipant.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 128);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 39;
            label2.Text = "Participant";
            // 
            // PerfomanceEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 303);
            Controls.Add(cmbParticipant);
            Controls.Add(label2);
            Controls.Add(cmbStage);
            Controls.Add(label3);
            Controls.Add(cmbEvent);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Name = "PerfomanceEditForm";
            Text = "PerfomanceEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStage;
        private Label label3;
        private ComboBox cmbEvent;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private ComboBox cmbParticipant;
        private Label label2;
    }
}