namespace FestivalsBD
{
    partial class SceneEditForm
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
            txtCapacity = new TextBox();
            label3 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtName = new TextBox();
            txtType = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtHeight = new TextBox();
            label4 = new Label();
            txtDocNumber = new TextBox();
            txtArea = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtLoad = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(12, 104);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(230, 27);
            txtCapacity.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 51;
            label3.Text = "Capacity";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(341, 492);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 50;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(241, 492);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 49;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += this.btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 48;
            label1.Text = "Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtType);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtCapacity);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 197);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сцена";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 27);
            txtName.TabIndex = 53;
            // 
            // txtType
            // 
            txtType.Location = new Point(12, 160);
            txtType.Name = "txtType";
            txtType.Size = new Size(230, 27);
            txtType.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 137);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 54;
            label2.Text = "Type";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtLoad);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtHeight);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtDocNumber);
            groupBox2.Controls.Add(txtArea);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(-1, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 255);
            groupBox2.TabIndex = 55;
            groupBox2.TabStop = false;
            groupBox2.Text = "Технічний паспорт";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(12, 160);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(230, 27);
            txtHeight.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 137);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 54;
            label4.Text = "Stage height";
            // 
            // txtDocNumber
            // 
            txtDocNumber.Location = new Point(12, 49);
            txtDocNumber.Name = "txtDocNumber";
            txtDocNumber.Size = new Size(230, 27);
            txtDocNumber.TabIndex = 53;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(12, 104);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(230, 27);
            txtArea.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 26);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 48;
            label5.Text = "Document number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 81);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 51;
            label6.Text = "Stage area";
            // 
            // txtLoad
            // 
            txtLoad.Location = new Point(13, 217);
            txtLoad.Name = "txtLoad";
            txtLoad.Size = new Size(230, 27);
            txtLoad.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 194);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 56;
            label7.Text = "Maximum load";
            // 
            // SceneEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 533);
            Controls.Add(groupBox2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "SceneEditForm";
            Text = "SceneEditForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCapacity;
        private Label label3;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtName;
        private TextBox txtType;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtHeight;
        private Label label4;
        private TextBox txtDocNumber;
        private TextBox txtArea;
        private Label label5;
        private Label label6;
        private TextBox txtLoad;
        private Label label7;
    }
}