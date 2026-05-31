using System.ComponentModel;

namespace FestivalsBD;

partial class Queries
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        dgvResultQ1 = new DataGridView();
        label12 = new Label();
        button1 = new Button();
        cmbFestivalQ1 = new ComboBox();
        label2 = new Label();
        label1 = new Label();
        tabPage2 = new TabPage();
        lblSumResult = new Label();
        label3 = new Label();
        button2 = new Button();
        cmbFestivalQ2 = new ComboBox();
        label4 = new Label();
        label5 = new Label();
        tabPage3 = new TabPage();
        numLoad = new NumericUpDown();
        numArea = new NumericUpDown();
        label9 = new Label();
        dgvResultQ3 = new DataGridView();
        label6 = new Label();
        btnRunQ3 = new Button();
        label7 = new Label();
        label8 = new Label();
        tabPage4 = new TabPage();
        txtAreaQ4 = new TextBox();
        dgvResultQ4 = new DataGridView();
        label10 = new Label();
        btnRunQ4 = new Button();
        label11 = new Label();
        label13 = new Label();
        tabPage5 = new TabPage();
        lblMaxCapacityResult = new Label();
        label15 = new Label();
        btnRunQ5 = new Button();
        cmbParticipantQ5 = new ComboBox();
        label16 = new Label();
        label17 = new Label();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        ((ISupportInitialize)dgvResultQ1).BeginInit();
        tabPage2.SuspendLayout();
        tabPage3.SuspendLayout();
        ((ISupportInitialize)numLoad).BeginInit();
        ((ISupportInitialize)numArea).BeginInit();
        ((ISupportInitialize)dgvResultQ3).BeginInit();
        tabPage4.SuspendLayout();
        ((ISupportInitialize)dgvResultQ4).BeginInit();
        tabPage5.SuspendLayout();
        SuspendLayout();
        // 
        // Return
        // 
        Return.Location = new Point(649, -2);
        Return.Name = "Return";
        Return.Size = new Size(156, 29);
        Return.TabIndex = 0;
        Return.Text = "На головну";
        Return.UseVisualStyleBackColor = true;
        Return.Click += Return_Click;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Controls.Add(tabPage3);
        tabControl1.Controls.Add(tabPage4);
        tabControl1.Controls.Add(tabPage5);
        tabControl1.Location = new Point(0, 27);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(794, 415);
        tabControl1.TabIndex = 1;
        tabControl1.Click += btnRunQ3_Click;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(dgvResultQ1);
        tabPage1.Controls.Add(label12);
        tabPage1.Controls.Add(button1);
        tabPage1.Controls.Add(cmbFestivalQ1);
        tabPage1.Controls.Add(label2);
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
        dgvResultQ1.Location = new Point(0, 222);
        dgvResultQ1.Name = "dgvResultQ1";
        dgvResultQ1.RowHeadersWidth = 51;
        dgvResultQ1.Size = new Size(786, 142);
        dgvResultQ1.TabIndex = 22;
        dgvResultQ1.Text = "dataGridView1";
        // 
        // label12
        // 
        label12.Location = new Point(0, 195);
        label12.Name = "label12";
        label12.Size = new Size(145, 24);
        label12.TabIndex = 21;
        label12.Text = "Результат:";
        // 
        // button1
        // 
        button1.Location = new Point(8, 131);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 3;
        button1.Text = "Виконати";
        button1.UseVisualStyleBackColor = true;
        button1.Click += btnRunQ1_Click;
        // 
        // cmbFestivalQ1
        // 
        cmbFestivalQ1.FormattingEnabled = true;
        cmbFestivalQ1.Location = new Point(8, 79);
        cmbFestivalQ1.Name = "cmbFestivalQ1";
        cmbFestivalQ1.Size = new Size(151, 28);
        cmbFestivalQ1.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(8, 56);
        label2.Name = "label2";
        label2.Size = new Size(143, 20);
        label2.TabIndex = 1;
        label2.Text = "Оберіть фестиваль:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(8, 16);
        label1.Name = "label1";
        label1.Size = new Size(624, 20);
        label1.TabIndex = 0;
        label1.Text = "Показати назви, дати та час початку всіх подій, які відбуваються на обраному фестивалі";
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(lblSumResult);
        tabPage2.Controls.Add(label3);
        tabPage2.Controls.Add(button2);
        tabPage2.Controls.Add(cmbFestivalQ2);
        tabPage2.Controls.Add(label4);
        tabPage2.Controls.Add(label5);
        tabPage2.Location = new Point(4, 29);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(786, 382);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Запит 2";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // lblSumResult
        // 
        lblSumResult.AutoSize = true;
        lblSumResult.Location = new Point(3, 219);
        lblSumResult.Name = "lblSumResult";
        lblSumResult.Size = new Size(0, 20);
        lblSumResult.TabIndex = 28;
        // 
        // label3
        // 
        label3.Location = new Point(0, 195);
        label3.Name = "label3";
        label3.Size = new Size(145, 24);
        label3.TabIndex = 27;
        label3.Text = "Результат:";
        // 
        // button2
        // 
        button2.Location = new Point(8, 131);
        button2.Name = "button2";
        button2.Size = new Size(94, 29);
        button2.TabIndex = 26;
        button2.Text = "Виконати";
        button2.UseVisualStyleBackColor = true;
        button2.Click += btnRunQ2_Click;
        // 
        // cmbFestivalQ2
        // 
        cmbFestivalQ2.FormattingEnabled = true;
        cmbFestivalQ2.Location = new Point(8, 79);
        cmbFestivalQ2.Name = "cmbFestivalQ2";
        cmbFestivalQ2.Size = new Size(151, 28);
        cmbFestivalQ2.TabIndex = 25;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(8, 56);
        label4.Name = "label4";
        label4.Size = new Size(143, 20);
        label4.TabIndex = 24;
        label4.Text = "Оберіть фестиваль:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(8, 16);
        label5.Name = "label5";
        label5.Size = new Size(625, 20);
        label5.TabIndex = 23;
        label5.Text = "Знайти загальну суму фінансування, яку отримав обраний фестиваль від усіх спонсорів.";
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(numLoad);
        tabPage3.Controls.Add(numArea);
        tabPage3.Controls.Add(label9);
        tabPage3.Controls.Add(dgvResultQ3);
        tabPage3.Controls.Add(label6);
        tabPage3.Controls.Add(btnRunQ3);
        tabPage3.Controls.Add(label7);
        tabPage3.Controls.Add(label8);
        tabPage3.Location = new Point(4, 29);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3);
        tabPage3.Size = new Size(786, 382);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "Запит 3";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // numLoad
        // 
        numLoad.Location = new Point(241, 97);
        numLoad.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        numLoad.Name = "numLoad";
        numLoad.Size = new Size(150, 27);
        numLoad.TabIndex = 33;
        // 
        // numArea
        // 
        numArea.Location = new Point(8, 97);
        numArea.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        numArea.Name = "numArea";
        numArea.Size = new Size(150, 27);
        numArea.TabIndex = 32;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(241, 74);
        label9.Name = "label9";
        label9.Size = new Size(160, 20);
        label9.TabIndex = 30;
        label9.Text = "Вкажіть макс. навант.:";
        // 
        // dgvResultQ3
        // 
        dgvResultQ3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvResultQ3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvResultQ3.Location = new Point(0, 240);
        dgvResultQ3.Name = "dgvResultQ3";
        dgvResultQ3.RowHeadersWidth = 51;
        dgvResultQ3.Size = new Size(786, 142);
        dgvResultQ3.TabIndex = 28;
        dgvResultQ3.Text = "dataGridView1";
        // 
        // label6
        // 
        label6.Location = new Point(0, 213);
        label6.Name = "label6";
        label6.Size = new Size(145, 24);
        label6.TabIndex = 27;
        label6.Text = "Результат:";
        // 
        // btnRunQ3
        // 
        btnRunQ3.Location = new Point(8, 149);
        btnRunQ3.Name = "btnRunQ3";
        btnRunQ3.Size = new Size(94, 29);
        btnRunQ3.TabIndex = 26;
        btnRunQ3.Text = "Виконати";
        btnRunQ3.UseVisualStyleBackColor = true;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(8, 74);
        label7.Name = "label7";
        label7.Size = new Size(114, 20);
        label7.TabIndex = 24;
        label7.Text = "Вкажіть площу:";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(8, 17);
        label8.Name = "label8";
        label8.Size = new Size(627, 40);
        label8.TabIndex = 23;
        label8.Text = "Вивести список сцен та їхні технічні паспорти, площа яких перевищує обране значення,\r\nа максимальне навантаження більше за інше обране значення.";
        // 
        // tabPage4
        // 
        tabPage4.Controls.Add(txtAreaQ4);
        tabPage4.Controls.Add(dgvResultQ4);
        tabPage4.Controls.Add(label10);
        tabPage4.Controls.Add(btnRunQ4);
        tabPage4.Controls.Add(label11);
        tabPage4.Controls.Add(label13);
        tabPage4.Location = new Point(4, 29);
        tabPage4.Name = "tabPage4";
        tabPage4.Padding = new Padding(3);
        tabPage4.Size = new Size(786, 382);
        tabPage4.TabIndex = 3;
        tabPage4.Text = "Запит 4";
        tabPage4.UseVisualStyleBackColor = true;
        // 
        // txtAreaQ4
        // 
        txtAreaQ4.Location = new Point(8, 80);
        txtAreaQ4.Name = "txtAreaQ4";
        txtAreaQ4.Size = new Size(151, 27);
        txtAreaQ4.TabIndex = 30;
        // 
        // dgvResultQ4
        // 
        dgvResultQ4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvResultQ4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvResultQ4.Location = new Point(0, 223);
        dgvResultQ4.Name = "dgvResultQ4";
        dgvResultQ4.RowHeadersWidth = 51;
        dgvResultQ4.Size = new Size(786, 142);
        dgvResultQ4.TabIndex = 28;
        dgvResultQ4.Text = "dataGridView1";
        // 
        // label10
        // 
        label10.Location = new Point(0, 196);
        label10.Name = "label10";
        label10.Size = new Size(145, 24);
        label10.TabIndex = 27;
        label10.Text = "Результат:";
        // 
        // btnRunQ4
        // 
        btnRunQ4.Location = new Point(8, 132);
        btnRunQ4.Name = "btnRunQ4";
        btnRunQ4.Size = new Size(94, 29);
        btnRunQ4.TabIndex = 26;
        btnRunQ4.Text = "Виконати";
        btnRunQ4.UseVisualStyleBackColor = true;
        btnRunQ4.Click += btnRunQ4_Click;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(8, 57);
        label11.Name = "label11";
        label11.Size = new Size(110, 20);
        label11.TabIndex = 24;
        label11.Text = "Вкажіть сферу:";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(8, 17);
        label13.Name = "label13";
        label13.Size = new Size(638, 20);
        label13.TabIndex = 23;
        label13.Text = "Визначити ім'я та телефон керівників, які відповідають за вказану сферу відповідальності.";
        // 
        // tabPage5
        // 
        tabPage5.Controls.Add(lblMaxCapacityResult);
        tabPage5.Controls.Add(label15);
        tabPage5.Controls.Add(btnRunQ5);
        tabPage5.Controls.Add(cmbParticipantQ5);
        tabPage5.Controls.Add(label16);
        tabPage5.Controls.Add(label17);
        tabPage5.Location = new Point(4, 29);
        tabPage5.Name = "tabPage5";
        tabPage5.Padding = new Padding(3);
        tabPage5.Size = new Size(786, 382);
        tabPage5.TabIndex = 4;
        tabPage5.Text = "Запит 5";
        tabPage5.UseVisualStyleBackColor = true;
        // 
        // lblMaxCapacityResult
        // 
        lblMaxCapacityResult.AutoSize = true;
        lblMaxCapacityResult.Location = new Point(3, 219);
        lblMaxCapacityResult.Name = "lblMaxCapacityResult";
        lblMaxCapacityResult.Size = new Size(0, 20);
        lblMaxCapacityResult.TabIndex = 34;
        // 
        // label15
        // 
        label15.Location = new Point(0, 195);
        label15.Name = "label15";
        label15.Size = new Size(145, 24);
        label15.TabIndex = 33;
        label15.Text = "Результат:";
        // 
        // btnRunQ5
        // 
        btnRunQ5.Location = new Point(8, 131);
        btnRunQ5.Name = "btnRunQ5";
        btnRunQ5.Size = new Size(94, 29);
        btnRunQ5.TabIndex = 32;
        btnRunQ5.Text = "Виконати";
        btnRunQ5.UseVisualStyleBackColor = true;
        btnRunQ5.Click += btnRunQ5_Click;
        // 
        // cmbParticipantQ5
        // 
        cmbParticipantQ5.FormattingEnabled = true;
        cmbParticipantQ5.Location = new Point(8, 79);
        cmbParticipantQ5.Name = "cmbParticipantQ5";
        cmbParticipantQ5.Size = new Size(151, 28);
        cmbParticipantQ5.TabIndex = 31;
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(8, 56);
        label16.Name = "label16";
        label16.Size = new Size(134, 20);
        label16.TabIndex = 30;
        label16.Text = "Оберіть учасника:";
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Location = new Point(8, 16);
        label17.Name = "label17";
        label17.Size = new Size(583, 20);
        label17.TabIndex = 29;
        label17.Text = "Знайти максимальну місткість сцени, на якій виступав учасник з обраним іменем.";
        // 
        // Queries
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(tabControl1);
        Controls.Add(Return);
        Name = "Queries";
        Text = "Параметризовані запити";
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        ((ISupportInitialize)dgvResultQ1).EndInit();
        tabPage2.ResumeLayout(false);
        tabPage2.PerformLayout();
        tabPage3.ResumeLayout(false);
        tabPage3.PerformLayout();
        ((ISupportInitialize)numLoad).EndInit();
        ((ISupportInitialize)numArea).EndInit();
        ((ISupportInitialize)dgvResultQ3).EndInit();
        tabPage4.ResumeLayout(false);
        tabPage4.PerformLayout();
        ((ISupportInitialize)dgvResultQ4).EndInit();
        tabPage5.ResumeLayout(false);
        tabPage5.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button Return;

    #endregion

    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private TabPage tabPage5;
    private Label label1;
    private Label label2;
    private ComboBox cmbFestivalQ1;
    private Button button1;
    private DataGridView dgvResultQ1;
    private Label label12;
    private Label label3;
    private Button button2;
    private ComboBox cmbFestivalQ2;
    private Label label4;
    private Label label5;
    private Label lblSumResult;
    private Label label9;
    private DataGridView dgvResultQ3;
    private Label label6;
    private Button btnRunQ3;
    private Label label7;
    private Label label8;
    private TextBox txtAreaQ4;
    private DataGridView dgvResultQ4;
    private Label label10;
    private Button btnRunQ4;
    private Label label11;
    private Label label13;
    private Label lblMaxCapacityResult;
    private Label label15;
    private Button btnRunQ5;
    private ComboBox cmbParticipantQ5;
    private Label label16;
    private Label label17;
    private NumericUpDown numLoad;
    private NumericUpDown numArea;
}