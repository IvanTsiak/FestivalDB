namespace FestivalsBD
{
    partial class HardQueries
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
            Return = new Button();
            tabPage2 = new TabPage();
            dgvResultQ2 = new DataGridView();
            lblSumResult = new Label();
            label3 = new Label();
            button2 = new Button();
            label5 = new Label();
            tabPage1 = new TabPage();
            dgvResultQ1 = new DataGridView();
            label12 = new Label();
            button1 = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultQ2).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultQ1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // Return
            // 
            Return.Location = new Point(647, 3);
            Return.Name = "Return";
            Return.Size = new Size(156, 29);
            Return.TabIndex = 2;
            Return.Text = "На головну";
            Return.UseVisualStyleBackColor = true;
            Return.Click += Return_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvResultQ2);
            tabPage2.Controls.Add(lblSumResult);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 382);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Запит 2";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // dgvResultQ2
            // 
            dgvResultQ2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultQ2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultQ2.Location = new Point(0, 156);
            dgvResultQ2.Name = "dgvResultQ2";
            dgvResultQ2.ReadOnly = true;
            dgvResultQ2.RowHeadersWidth = 51;
            dgvResultQ2.Size = new Size(786, 142);
            dgvResultQ2.TabIndex = 29;
            dgvResultQ2.Text = "dataGridView1";
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(6, 222);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(0, 20);
            lblSumResult.TabIndex = 28;
            // 
            // label3
            // 
            label3.Location = new Point(0, 129);
            label3.Name = "label3";
            label3.Size = new Size(145, 24);
            label3.TabIndex = 27;
            label3.Text = "Результат:";
            // 
            // button2
            // 
            button2.Location = new Point(11, 71);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 26;
            button2.Text = "Знайти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnRunQ2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 19);
            label5.Name = "label5";
            label5.Size = new Size(531, 20);
            label5.TabIndex = 23;
            label5.Text = "Знайти пари учасників, які виступають на точно такій самій множині сцен.\r\n";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvResultQ1);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(786, 382);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Запит 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvResultQ1
            // 
            dgvResultQ1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultQ1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultQ1.Location = new Point(0, 156);
            dgvResultQ1.Name = "dgvResultQ1";
            dgvResultQ1.ReadOnly = true;
            dgvResultQ1.RowHeadersWidth = 51;
            dgvResultQ1.Size = new Size(786, 142);
            dgvResultQ1.TabIndex = 22;
            dgvResultQ1.Text = "dataGridView1";
            // 
            // label12
            // 
            label12.Location = new Point(0, 129);
            label12.Name = "label12";
            label12.Size = new Size(145, 24);
            label12.TabIndex = 21;
            label12.Text = "Результат:";
            // 
            // button1
            // 
            button1.Location = new Point(11, 71);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Знайти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRunQ1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(481, 20);
            label1.TabIndex = 0;
            label1.Text = "Визначити імена учасників, які виступають на всіх існуючих сценах.";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-2, 32);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 415);
            tabControl1.TabIndex = 3;
            tabControl1.Click += btnRunQ1_Click;
            // 
            // HardQueries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(Return);
            Name = "HardQueries";
            Text = "HardQueries";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultQ2).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultQ1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button Return;
        private TabPage tabPage2;
        private Label lblSumResult;
        private Label label3;
        private Button button2;
        private Label label5;
        private TabPage tabPage1;
        private DataGridView dgvResultQ1;
        private Label label12;
        private Button button1;
        private Label label1;
        private TabControl tabControl1;
        private DataGridView dgvResultQ2;
    }
}