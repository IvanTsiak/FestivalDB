using System.ComponentModel;

namespace FestivalsBD;

partial class CRUD
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
        SponsorsTab = new TabControl();
        SponsorsPage = new TabPage();
        panel1 = new Panel();
        UpdateBtn = new Button();
        DeleteBtn = new Button();
        AddBtn = new Button();
        dgvSponsors = new DataGridView();
        Company_name = new DataGridViewTextBoxColumn();
        Email = new DataGridViewTextBoxColumn();
        label1 = new Label();
        tabPage2 = new TabPage();
        SponsorsTab.SuspendLayout();
        SponsorsPage.SuspendLayout();
        panel1.SuspendLayout();
        ((ISupportInitialize)dgvSponsors).BeginInit();
        SuspendLayout();
        // 
        // Return
        // 
        Return.Location = new Point(646, -3);
        Return.Name = "Return";
        Return.Size = new Size(156, 29);
        Return.TabIndex = 0;
        Return.Text = "На головну";
        Return.UseVisualStyleBackColor = true;
        Return.Click += Return_Click;
        // 
        // SponsorsTab
        // 
        SponsorsTab.Controls.Add(SponsorsPage);
        SponsorsTab.Controls.Add(tabPage2);
        SponsorsTab.Location = new Point(0, 23);
        SponsorsTab.Name = "SponsorsTab";
        SponsorsTab.SelectedIndex = 0;
        SponsorsTab.Size = new Size(802, 448);
        SponsorsTab.TabIndex = 1;
        // 
        // SponsorsPage
        // 
        SponsorsPage.Controls.Add(panel1);
        SponsorsPage.Controls.Add(dgvSponsors);
        SponsorsPage.Controls.Add(label1);
        SponsorsPage.Location = new Point(4, 29);
        SponsorsPage.Name = "SponsorsPage";
        SponsorsPage.Padding = new Padding(3);
        SponsorsPage.Size = new Size(794, 415);
        SponsorsPage.TabIndex = 0;
        SponsorsPage.Text = "Спонсори";
        SponsorsPage.UseVisualStyleBackColor = true;
        SponsorsPage.Click += tabPage1_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(UpdateBtn);
        panel1.Controls.Add(DeleteBtn);
        panel1.Controls.Add(AddBtn);
        panel1.Location = new Point(0, 175);
        panel1.Name = "panel1";
        panel1.Size = new Size(794, 43);
        panel1.TabIndex = 3;
        // 
        // UpdateBtn
        // 
        UpdateBtn.Location = new Point(204, 0);
        UpdateBtn.Name = "UpdateBtn";
        UpdateBtn.Size = new Size(94, 43);
        UpdateBtn.TabIndex = 5;
        UpdateBtn.Text = "Редагувати";
        UpdateBtn.UseVisualStyleBackColor = true;
        UpdateBtn.Click += button1_Click_2;
        // 
        // DeleteBtn
        // 
        DeleteBtn.Location = new Point(102, 0);
        DeleteBtn.Name = "DeleteBtn";
        DeleteBtn.Size = new Size(96, 43);
        DeleteBtn.TabIndex = 4;
        DeleteBtn.Text = "Видалити";
        DeleteBtn.UseVisualStyleBackColor = true;
        DeleteBtn.Click += button1_Click;
        // 
        // AddBtn
        // 
        AddBtn.Location = new Point(0, 0);
        AddBtn.Name = "AddBtn";
        AddBtn.Size = new Size(96, 43);
        AddBtn.TabIndex = 2;
        AddBtn.Text = "Додати";
        AddBtn.UseVisualStyleBackColor = true;
        // 
        // dgvSponsors
        // 
        dgvSponsors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvSponsors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSponsors.Columns.AddRange(new DataGridViewColumn[] { Company_name, Email });
        dgvSponsors.Location = new Point(-4, 27);
        dgvSponsors.Name = "dgvSponsors";
        dgvSponsors.RowHeadersWidth = 51;
        dgvSponsors.Size = new Size(798, 142);
        dgvSponsors.TabIndex = 2;
        dgvSponsors.Text = "dataGridView1";
        dgvSponsors.CellContentClick += dataGridView1_CellContentClick;
        // 
        // Company_name
        // 
        Company_name.HeaderText = "Назва компаній";
        Company_name.MinimumWidth = 6;
        Company_name.Name = "Company_name";
        Company_name.ReadOnly = true;
        // 
        // Email
        // 
        Email.HeaderText = "Електронна пошта";
        Email.MinimumWidth = 6;
        Email.Name = "Email";
        Email.ReadOnly = true;
        // 
        // label1
        // 
        label1.Location = new Point(0, 0);
        label1.Name = "label1";
        label1.Size = new Size(174, 24);
        label1.TabIndex = 1;
        label1.Text = "Спонсори";
        label1.Click += label1_Click;
        // 
        // tabPage2
        // 
        tabPage2.Location = new Point(4, 29);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(794, 415);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "tabPage2";
        tabPage2.UseVisualStyleBackColor = true;
        tabPage2.Click += tabPage2_Click;
        // 
        // CRUD
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 471);
        Controls.Add(Return);
        Controls.Add(SponsorsTab);
        Name = "CRUD";
        Text = "CRUD";
        SponsorsTab.ResumeLayout(false);
        SponsorsPage.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ((ISupportInitialize)dgvSponsors).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button AddBtn;
    private System.Windows.Forms.Button DeleteBtn;

    private System.Windows.Forms.DataGridViewTextBoxColumn Email;

    private System.Windows.Forms.DataGridViewTextBoxColumn Company_name;

    private System.Windows.Forms.DataGridView dgvSponsors;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TabControl SponsorsTab;
    private System.Windows.Forms.TabPage SponsorsPage;
    private System.Windows.Forms.TabPage tabPage2;

    private System.Windows.Forms.Button Return;

    #endregion

    private Button UpdateBtn;
}