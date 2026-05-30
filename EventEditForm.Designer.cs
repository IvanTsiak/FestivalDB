namespace FestivalsBD
{
    partial class EventEditForm
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
            label4 = new Label();
            dtpStartTime = new DateTimePicker();
            label3 = new Label();
            dtpDay = new DateTimePicker();
            btnCancel = new Button();
            btnSave = new Button();
            label2 = new Label();
            txtTheme = new TextBox();
            label1 = new Label();
            txtEventName = new TextBox();
            label5 = new Label();
            dtpEndTime = new DateTimePicker();
            cmbFestival = new ComboBox();
            d = new Label();
            label6 = new Label();
            txtEventType = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 119);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 25;
            label4.Text = "Start time";
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(12, 142);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(250, 27);
            dtpStartTime.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 23;
            label3.Text = "Day";
            // 
            // dtpDay
            // 
            dtpDay.Format = DateTimePickerFormat.Short;
            dtpDay.Location = new Point(12, 86);
            dtpDay.Name = "dtpDay";
            dtpDay.Size = new Size(250, 27);
            dtpDay.TabIndex = 22;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(341, 412);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(241, 412);
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
            label2.Location = new Point(12, 228);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 19;
            label2.Text = "Theme";
            // 
            // txtTheme
            // 
            txtTheme.Location = new Point(12, 251);
            txtTheme.Name = "txtTheme";
            txtTheme.Size = new Size(230, 27);
            txtTheme.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(12, 34);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(230, 27);
            txtEventName.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 175);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 27;
            label5.Text = "End time";
            // 
            // dtpEndTime
            // 
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(12, 198);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(250, 27);
            dtpEndTime.TabIndex = 26;
            // 
            // cmbFestival
            // 
            cmbFestival.FormattingEnabled = true;
            cmbFestival.Location = new Point(12, 360);
            cmbFestival.Name = "cmbFestival";
            cmbFestival.Size = new Size(151, 28);
            cmbFestival.TabIndex = 28;
            // 
            // d
            // 
            d.AutoSize = true;
            d.Location = new Point(12, 337);
            d.Name = "d";
            d.Size = new Size(58, 20);
            d.TabIndex = 29;
            d.Text = "Festival";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 283);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 31;
            label6.Text = "Event type";
            // 
            // txtEventType
            // 
            txtEventType.Location = new Point(12, 306);
            txtEventType.Name = "txtEventType";
            txtEventType.Size = new Size(230, 27);
            txtEventType.TabIndex = 30;
            // 
            // EventEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 453);
            Controls.Add(label6);
            Controls.Add(txtEventType);
            Controls.Add(d);
            Controls.Add(cmbFestival);
            Controls.Add(label5);
            Controls.Add(dtpEndTime);
            Controls.Add(label4);
            Controls.Add(dtpStartTime);
            Controls.Add(label3);
            Controls.Add(dtpDay);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(txtTheme);
            Controls.Add(label1);
            Controls.Add(txtEventName);
            Name = "EventEditForm";
            Text = "EventEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DateTimePicker dtpStartTime;
        private Label label3;
        private DateTimePicker dtpDay;
        private Button btnCancel;
        private Button btnSave;
        private Label label2;
        private TextBox txtTheme;
        private Label label1;
        private TextBox txtEventName;
        private Label label5;
        private DateTimePicker dtpEndTime;
        private ComboBox cmbFestival;
        private Label d;
        private Label label6;
        private TextBox txtEventType;
    }
}