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
        CRUDTab = new TabControl();
        SponsorsPage = new TabPage();
        panel1 = new Panel();
        UpdateBtn = new Button();
        DeleteBtn = new Button();
        AddBtn = new Button();
        dgvSponsors = new DataGridView();
        label1 = new Label();
        FestivalsTab = new TabPage();
        dgvFinancing = new DataGridView();
        label4 = new Label();
        panel4 = new Panel();
        button7 = new Button();
        button8 = new Button();
        button9 = new Button();
        dgvEvents = new DataGridView();
        label3 = new Label();
        panel2 = new Panel();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        dgvFestivals = new DataGridView();
        label2 = new Label();
        panel3 = new Panel();
        button2 = new Button();
        button3 = new Button();
        button1 = new Button();
        StaffTab = new TabPage();
        dgvService = new DataGridView();
        label8 = new Label();
        panel8 = new Panel();
        button20 = new Button();
        button21 = new Button();
        dgvTechnicalWorker = new DataGridView();
        label7 = new Label();
        panel7 = new Panel();
        button16 = new Button();
        button17 = new Button();
        button18 = new Button();
        dgvLeader = new DataGridView();
        label6 = new Label();
        panel6 = new Panel();
        button13 = new Button();
        button14 = new Button();
        button15 = new Button();
        dgvStaff = new DataGridView();
        label5 = new Label();
        panel5 = new Panel();
        button10 = new Button();
        button11 = new Button();
        button12 = new Button();
        ScenesTab = new TabPage();
        dgvScenes = new DataGridView();
        label9 = new Label();
        panel9 = new Panel();
        button19 = new Button();
        button22 = new Button();
        button23 = new Button();
        ParticipantsTab = new TabPage();
        dgvFriendships = new DataGridView();
        label11 = new Label();
        panel11 = new Panel();
        button28 = new Button();
        button29 = new Button();
        dgvParticipants = new DataGridView();
        label10 = new Label();
        panel10 = new Panel();
        button24 = new Button();
        button25 = new Button();
        button26 = new Button();
        PerformancesTab = new TabPage();
        dgvPerformances = new DataGridView();
        label12 = new Label();
        panel12 = new Panel();
        button30 = new Button();
        button31 = new Button();
        CRUDTab.SuspendLayout();
        SponsorsPage.SuspendLayout();
        panel1.SuspendLayout();
        ((ISupportInitialize)dgvSponsors).BeginInit();
        FestivalsTab.SuspendLayout();
        ((ISupportInitialize)dgvFinancing).BeginInit();
        panel4.SuspendLayout();
        ((ISupportInitialize)dgvEvents).BeginInit();
        panel2.SuspendLayout();
        ((ISupportInitialize)dgvFestivals).BeginInit();
        panel3.SuspendLayout();
        StaffTab.SuspendLayout();
        ((ISupportInitialize)dgvService).BeginInit();
        panel8.SuspendLayout();
        ((ISupportInitialize)dgvTechnicalWorker).BeginInit();
        panel7.SuspendLayout();
        ((ISupportInitialize)dgvLeader).BeginInit();
        panel6.SuspendLayout();
        ((ISupportInitialize)dgvStaff).BeginInit();
        panel5.SuspendLayout();
        ScenesTab.SuspendLayout();
        ((ISupportInitialize)dgvScenes).BeginInit();
        panel9.SuspendLayout();
        ParticipantsTab.SuspendLayout();
        ((ISupportInitialize)dgvFriendships).BeginInit();
        panel11.SuspendLayout();
        ((ISupportInitialize)dgvParticipants).BeginInit();
        panel10.SuspendLayout();
        PerformancesTab.SuspendLayout();
        ((ISupportInitialize)dgvPerformances).BeginInit();
        panel12.SuspendLayout();
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
        // CRUDTab
        // 
        CRUDTab.Controls.Add(SponsorsPage);
        CRUDTab.Controls.Add(FestivalsTab);
        CRUDTab.Controls.Add(StaffTab);
        CRUDTab.Controls.Add(ScenesTab);
        CRUDTab.Controls.Add(ParticipantsTab);
        CRUDTab.Controls.Add(PerformancesTab);
        CRUDTab.Location = new Point(0, 23);
        CRUDTab.Name = "CRUDTab";
        CRUDTab.SelectedIndex = 0;
        CRUDTab.Size = new Size(802, 448);
        CRUDTab.TabIndex = 1;
        CRUDTab.SelectedIndexChanged += CRUDTab_SelectIndexChanged;
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
        SponsorsPage.Click += CRUDTab_SelectIndexChanged;
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
        UpdateBtn.Click += btnEdit_Click;
        // 
        // DeleteBtn
        // 
        DeleteBtn.Location = new Point(102, 0);
        DeleteBtn.Name = "DeleteBtn";
        DeleteBtn.Size = new Size(96, 43);
        DeleteBtn.TabIndex = 4;
        DeleteBtn.Text = "Видалити";
        DeleteBtn.UseVisualStyleBackColor = true;
        DeleteBtn.Click += btnDelete_Click;
        // 
        // AddBtn
        // 
        AddBtn.Location = new Point(0, 0);
        AddBtn.Name = "AddBtn";
        AddBtn.Size = new Size(96, 43);
        AddBtn.TabIndex = 2;
        AddBtn.Text = "Додати";
        AddBtn.UseVisualStyleBackColor = true;
        AddBtn.Click += btnAdd_Click;
        // 
        // dgvSponsors
        // 
        dgvSponsors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvSponsors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSponsors.Location = new Point(-4, 27);
        dgvSponsors.Name = "dgvSponsors";
        dgvSponsors.ReadOnly = true;
        dgvSponsors.RowHeadersWidth = 51;
        dgvSponsors.Size = new Size(798, 142);
        dgvSponsors.TabIndex = 2;
        dgvSponsors.Text = "dataGridView1";
        // 
        // label1
        // 
        label1.Location = new Point(0, 0);
        label1.Name = "label1";
        label1.Size = new Size(174, 24);
        label1.TabIndex = 1;
        label1.Text = "Спонсори";
        // 
        // FestivalsTab
        // 
        FestivalsTab.AutoScroll = true;
        FestivalsTab.AutoScrollMinSize = new Size(0, 240);
        FestivalsTab.Controls.Add(dgvFinancing);
        FestivalsTab.Controls.Add(label4);
        FestivalsTab.Controls.Add(panel4);
        FestivalsTab.Controls.Add(dgvEvents);
        FestivalsTab.Controls.Add(label3);
        FestivalsTab.Controls.Add(panel2);
        FestivalsTab.Controls.Add(dgvFestivals);
        FestivalsTab.Controls.Add(label2);
        FestivalsTab.Controls.Add(panel3);
        FestivalsTab.Location = new Point(4, 29);
        FestivalsTab.Name = "FestivalsTab";
        FestivalsTab.Padding = new Padding(3);
        FestivalsTab.Size = new Size(794, 415);
        FestivalsTab.TabIndex = 1;
        FestivalsTab.Text = "Фестивалі";
        FestivalsTab.UseVisualStyleBackColor = true;
        // 
        // dgvFinancing
        // 
        dgvFinancing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvFinancing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvFinancing.Location = new Point(0, 501);
        dgvFinancing.Name = "dgvFinancing";
        dgvFinancing.ReadOnly = true;
        dgvFinancing.RowHeadersWidth = 51;
        dgvFinancing.Size = new Size(774, 142);
        dgvFinancing.TabIndex = 17;
        dgvFinancing.Text = "dataGridView1";
        // 
        // label4
        // 
        label4.Location = new Point(0, 474);
        label4.Name = "label4";
        label4.Size = new Size(153, 24);
        label4.TabIndex = 16;
        label4.Text = "Фінансування";
        // 
        // panel4
        // 
        panel4.Controls.Add(button7);
        panel4.Controls.Add(button8);
        panel4.Controls.Add(button9);
        panel4.Location = new Point(1, 649);
        panel4.Name = "panel4";
        panel4.Size = new Size(773, 43);
        panel4.TabIndex = 18;
        // 
        // button7
        // 
        button7.Location = new Point(204, 0);
        button7.Name = "button7";
        button7.Size = new Size(94, 43);
        button7.TabIndex = 5;
        button7.Text = "Редагувати";
        button7.UseVisualStyleBackColor = true;
        button7.Click += btnEditFinancing_Click;
        // 
        // button8
        // 
        button8.Location = new Point(102, 0);
        button8.Name = "button8";
        button8.Size = new Size(96, 43);
        button8.TabIndex = 4;
        button8.Text = "Видалити";
        button8.UseVisualStyleBackColor = true;
        button8.Click += btnDeleteFinancing_Click;
        // 
        // button9
        // 
        button9.Location = new Point(0, 0);
        button9.Name = "button9";
        button9.Size = new Size(96, 43);
        button9.TabIndex = 2;
        button9.Text = "Додати";
        button9.UseVisualStyleBackColor = true;
        button9.Click += btnAddFinancing_Click;
        // 
        // dgvEvents
        // 
        dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvEvents.Location = new Point(0, 265);
        dgvEvents.Name = "dgvEvents";
        dgvEvents.ReadOnly = true;
        dgvEvents.RowHeadersWidth = 51;
        dgvEvents.Size = new Size(774, 142);
        dgvEvents.TabIndex = 14;
        dgvEvents.Text = "dataGridView1";
        // 
        // label3
        // 
        label3.Location = new Point(0, 238);
        label3.Name = "label3";
        label3.Size = new Size(153, 24);
        label3.TabIndex = 13;
        label3.Text = "Події";
        // 
        // panel2
        // 
        panel2.Controls.Add(button4);
        panel2.Controls.Add(button5);
        panel2.Controls.Add(button6);
        panel2.Location = new Point(1, 413);
        panel2.Name = "panel2";
        panel2.Size = new Size(773, 43);
        panel2.TabIndex = 15;
        // 
        // button4
        // 
        button4.Location = new Point(204, 0);
        button4.Name = "button4";
        button4.Size = new Size(94, 43);
        button4.TabIndex = 5;
        button4.Text = "Редагувати";
        button4.UseVisualStyleBackColor = true;
        button4.Click += btnEditEvent_Click;
        // 
        // button5
        // 
        button5.Location = new Point(102, 0);
        button5.Name = "button5";
        button5.Size = new Size(96, 43);
        button5.TabIndex = 4;
        button5.Text = "Видалити";
        button5.UseVisualStyleBackColor = true;
        button5.Click += btnDeleteEvent_Click;
        // 
        // button6
        // 
        button6.Location = new Point(0, 0);
        button6.Name = "button6";
        button6.Size = new Size(96, 43);
        button6.TabIndex = 2;
        button6.Text = "Додати";
        button6.UseVisualStyleBackColor = true;
        button6.Click += btnAddEvent_Click;
        // 
        // dgvFestivals
        // 
        dgvFestivals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvFestivals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvFestivals.Location = new Point(0, 28);
        dgvFestivals.Name = "dgvFestivals";
        dgvFestivals.ReadOnly = true;
        dgvFestivals.RowHeadersWidth = 51;
        dgvFestivals.Size = new Size(774, 142);
        dgvFestivals.TabIndex = 11;
        dgvFestivals.Text = "dataGridView1";
        // 
        // label2
        // 
        label2.Location = new Point(0, 1);
        label2.Name = "label2";
        label2.Size = new Size(153, 24);
        label2.TabIndex = 10;
        label2.Text = "Фестивалі";
        // 
        // panel3
        // 
        panel3.Controls.Add(button2);
        panel3.Controls.Add(button3);
        panel3.Controls.Add(button1);
        panel3.Location = new Point(1, 176);
        panel3.Name = "panel3";
        panel3.Size = new Size(773, 43);
        panel3.TabIndex = 12;
        // 
        // button2
        // 
        button2.Location = new Point(204, 0);
        button2.Name = "button2";
        button2.Size = new Size(94, 43);
        button2.TabIndex = 5;
        button2.Text = "Редагувати";
        button2.UseVisualStyleBackColor = true;
        button2.Click += btnEditFestival_Click;
        // 
        // button3
        // 
        button3.Location = new Point(102, 0);
        button3.Name = "button3";
        button3.Size = new Size(96, 43);
        button3.TabIndex = 4;
        button3.Text = "Видалити";
        button3.UseVisualStyleBackColor = true;
        button3.Click += btnDeleteFestival_Click;
        // 
        // button1
        // 
        button1.Location = new Point(0, 0);
        button1.Name = "button1";
        button1.Size = new Size(96, 43);
        button1.TabIndex = 2;
        button1.Text = "Додати";
        button1.UseVisualStyleBackColor = true;
        button1.Click += btnAddFestival_Click;
        // 
        // StaffTab
        // 
        StaffTab.AutoScroll = true;
        StaffTab.AutoScrollMinSize = new Size(0, 160);
        StaffTab.Controls.Add(dgvService);
        StaffTab.Controls.Add(label8);
        StaffTab.Controls.Add(panel8);
        StaffTab.Controls.Add(dgvTechnicalWorker);
        StaffTab.Controls.Add(label7);
        StaffTab.Controls.Add(panel7);
        StaffTab.Controls.Add(dgvLeader);
        StaffTab.Controls.Add(label6);
        StaffTab.Controls.Add(panel6);
        StaffTab.Controls.Add(dgvStaff);
        StaffTab.Controls.Add(label5);
        StaffTab.Controls.Add(panel5);
        StaffTab.Location = new Point(4, 29);
        StaffTab.Name = "StaffTab";
        StaffTab.Padding = new Padding(3);
        StaffTab.Size = new Size(794, 415);
        StaffTab.TabIndex = 2;
        StaffTab.Text = "Персонал";
        StaffTab.UseVisualStyleBackColor = true;
        // 
        // dgvService
        // 
        dgvService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvService.Location = new Point(0, 699);
        dgvService.Name = "dgvService";
        dgvService.ReadOnly = true;
        dgvService.RowHeadersWidth = 51;
        dgvService.Size = new Size(774, 142);
        dgvService.TabIndex = 23;
        dgvService.Text = "dataGridView1";
        // 
        // label8
        // 
        label8.Location = new Point(0, 672);
        label8.Name = "label8";
        label8.Size = new Size(153, 24);
        label8.TabIndex = 22;
        label8.Text = "Обслуговування";
        // 
        // panel8
        // 
        panel8.Controls.Add(button20);
        panel8.Controls.Add(button21);
        panel8.Location = new Point(1, 847);
        panel8.Name = "panel8";
        panel8.Size = new Size(773, 43);
        panel8.TabIndex = 24;
        // 
        // button20
        // 
        button20.Location = new Point(102, 0);
        button20.Name = "button20";
        button20.Size = new Size(96, 43);
        button20.TabIndex = 4;
        button20.Text = "Видалити";
        button20.UseVisualStyleBackColor = true;
        // 
        // button21
        // 
        button21.Location = new Point(0, 0);
        button21.Name = "button21";
        button21.Size = new Size(96, 43);
        button21.TabIndex = 2;
        button21.Text = "Додати";
        button21.UseVisualStyleBackColor = true;
        button21.Click += btnAddService_Click;
        // 
        // dgvTechnicalWorker
        // 
        dgvTechnicalWorker.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTechnicalWorker.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTechnicalWorker.Location = new Point(1, 474);
        dgvTechnicalWorker.Name = "dgvTechnicalWorker";
        dgvTechnicalWorker.ReadOnly = true;
        dgvTechnicalWorker.RowHeadersWidth = 51;
        dgvTechnicalWorker.Size = new Size(774, 142);
        dgvTechnicalWorker.TabIndex = 20;
        dgvTechnicalWorker.Text = "dataGridView1";
        // 
        // label7
        // 
        label7.Location = new Point(1, 447);
        label7.Name = "label7";
        label7.Size = new Size(153, 24);
        label7.TabIndex = 19;
        label7.Text = "Технічні працівники";
        // 
        // panel7
        // 
        panel7.Controls.Add(button16);
        panel7.Controls.Add(button17);
        panel7.Controls.Add(button18);
        panel7.Location = new Point(2, 622);
        panel7.Name = "panel7";
        panel7.Size = new Size(773, 43);
        panel7.TabIndex = 21;
        // 
        // button16
        // 
        button16.Location = new Point(204, 0);
        button16.Name = "button16";
        button16.Size = new Size(94, 43);
        button16.TabIndex = 5;
        button16.Text = "Редагувати";
        button16.UseVisualStyleBackColor = true;
        button16.Click += btnEditTechWorker_Click;
        // 
        // button17
        // 
        button17.Location = new Point(102, 0);
        button17.Name = "button17";
        button17.Size = new Size(96, 43);
        button17.TabIndex = 4;
        button17.Text = "Видалити";
        button17.UseVisualStyleBackColor = true;
        button17.Click += btnDeleteTechWorker_Click;
        // 
        // button18
        // 
        button18.Location = new Point(0, 0);
        button18.Name = "button18";
        button18.Size = new Size(96, 43);
        button18.TabIndex = 2;
        button18.Text = "Додати";
        button18.UseVisualStyleBackColor = true;
        button18.Click += btnAddTechWorker_Click;
        // 
        // dgvLeader
        // 
        dgvLeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvLeader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvLeader.Location = new Point(0, 253);
        dgvLeader.Name = "dgvLeader";
        dgvLeader.ReadOnly = true;
        dgvLeader.RowHeadersWidth = 51;
        dgvLeader.Size = new Size(774, 142);
        dgvLeader.TabIndex = 17;
        dgvLeader.Text = "dataGridView1";
        // 
        // label6
        // 
        label6.Location = new Point(0, 226);
        label6.Name = "label6";
        label6.Size = new Size(153, 24);
        label6.TabIndex = 16;
        label6.Text = "Керівники";
        // 
        // panel6
        // 
        panel6.Controls.Add(button13);
        panel6.Controls.Add(button14);
        panel6.Controls.Add(button15);
        panel6.Location = new Point(1, 401);
        panel6.Name = "panel6";
        panel6.Size = new Size(773, 43);
        panel6.TabIndex = 18;
        // 
        // button13
        // 
        button13.Location = new Point(204, 0);
        button13.Name = "button13";
        button13.Size = new Size(94, 43);
        button13.TabIndex = 5;
        button13.Text = "Редагувати";
        button13.UseVisualStyleBackColor = true;
        button13.Click += btnEditLeader_Click;
        // 
        // button14
        // 
        button14.Location = new Point(102, 0);
        button14.Name = "button14";
        button14.Size = new Size(96, 43);
        button14.TabIndex = 4;
        button14.Text = "Видалити";
        button14.UseVisualStyleBackColor = true;
        button14.Click += btnDeleteLeader_Click;
        // 
        // button15
        // 
        button15.Location = new Point(0, 0);
        button15.Name = "button15";
        button15.Size = new Size(96, 43);
        button15.TabIndex = 2;
        button15.Text = "Додати";
        button15.UseVisualStyleBackColor = true;
        button15.Click += btnAddLeader_Click;
        // 
        // dgvStaff
        // 
        dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvStaff.Location = new Point(0, 32);
        dgvStaff.Name = "dgvStaff";
        dgvStaff.ReadOnly = true;
        dgvStaff.RowHeadersWidth = 51;
        dgvStaff.Size = new Size(774, 142);
        dgvStaff.TabIndex = 14;
        dgvStaff.Text = "dataGridView1";
        // 
        // label5
        // 
        label5.Location = new Point(0, 5);
        label5.Name = "label5";
        label5.Size = new Size(153, 24);
        label5.TabIndex = 13;
        label5.Text = "Персонал";
        // 
        // panel5
        // 
        panel5.Controls.Add(button10);
        panel5.Controls.Add(button11);
        panel5.Controls.Add(button12);
        panel5.Location = new Point(1, 180);
        panel5.Name = "panel5";
        panel5.Size = new Size(773, 43);
        panel5.TabIndex = 15;
        // 
        // button10
        // 
        button10.Location = new Point(204, 0);
        button10.Name = "button10";
        button10.Size = new Size(94, 43);
        button10.TabIndex = 5;
        button10.Text = "Редагувати";
        button10.UseVisualStyleBackColor = true;
        button10.Click += btnEditStaff_Click;
        // 
        // button11
        // 
        button11.Location = new Point(102, 0);
        button11.Name = "button11";
        button11.Size = new Size(96, 43);
        button11.TabIndex = 4;
        button11.Text = "Видалити";
        button11.UseVisualStyleBackColor = true;
        button11.Click += btnDeleteStaff_Click;
        // 
        // button12
        // 
        button12.Location = new Point(0, 0);
        button12.Name = "button12";
        button12.Size = new Size(96, 43);
        button12.TabIndex = 2;
        button12.Text = "Додати";
        button12.UseVisualStyleBackColor = true;
        button12.Click += btnAddStaff_Click;
        // 
        // ScenesTab
        // 
        ScenesTab.AutoScroll = true;
        ScenesTab.Controls.Add(dgvScenes);
        ScenesTab.Controls.Add(label9);
        ScenesTab.Controls.Add(panel9);
        ScenesTab.Location = new Point(4, 29);
        ScenesTab.Name = "ScenesTab";
        ScenesTab.Padding = new Padding(3);
        ScenesTab.Size = new Size(794, 415);
        ScenesTab.TabIndex = 3;
        ScenesTab.Text = "Сцени";
        ScenesTab.UseVisualStyleBackColor = true;
        // 
        // dgvScenes
        // 
        dgvScenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvScenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvScenes.Location = new Point(0, 31);
        dgvScenes.Name = "dgvScenes";
        dgvScenes.ReadOnly = true;
        dgvScenes.RowHeadersWidth = 51;
        dgvScenes.Size = new Size(794, 142);
        dgvScenes.TabIndex = 17;
        dgvScenes.Text = "dataGridView1";
        // 
        // label9
        // 
        label9.Location = new Point(0, 4);
        label9.Name = "label9";
        label9.Size = new Size(219, 24);
        label9.TabIndex = 16;
        label9.Text = "Сцени та їх технічні паспорти";
        // 
        // panel9
        // 
        panel9.Controls.Add(button19);
        panel9.Controls.Add(button22);
        panel9.Controls.Add(button23);
        panel9.Location = new Point(1, 179);
        panel9.Name = "panel9";
        panel9.Size = new Size(793, 43);
        panel9.TabIndex = 18;
        // 
        // button19
        // 
        button19.Location = new Point(204, 0);
        button19.Name = "button19";
        button19.Size = new Size(94, 43);
        button19.TabIndex = 5;
        button19.Text = "Редагувати";
        button19.UseVisualStyleBackColor = true;
        button19.Click += btnEditScene_Click;
        // 
        // button22
        // 
        button22.Location = new Point(102, 0);
        button22.Name = "button22";
        button22.Size = new Size(96, 43);
        button22.TabIndex = 4;
        button22.Text = "Видалити";
        button22.UseVisualStyleBackColor = true;
        button22.Click += btnDeleteScene_Click;
        // 
        // button23
        // 
        button23.Location = new Point(0, 0);
        button23.Name = "button23";
        button23.Size = new Size(96, 43);
        button23.TabIndex = 2;
        button23.Text = "Додати";
        button23.UseVisualStyleBackColor = true;
        button23.Click += btnAddScene_Click;
        // 
        // ParticipantsTab
        // 
        ParticipantsTab.AutoScroll = true;
        ParticipantsTab.AutoScrollMinSize = new Size(0, 310);
        ParticipantsTab.Controls.Add(dgvFriendships);
        ParticipantsTab.Controls.Add(label11);
        ParticipantsTab.Controls.Add(panel11);
        ParticipantsTab.Controls.Add(dgvParticipants);
        ParticipantsTab.Controls.Add(label10);
        ParticipantsTab.Controls.Add(panel10);
        ParticipantsTab.Location = new Point(4, 29);
        ParticipantsTab.Name = "ParticipantsTab";
        ParticipantsTab.Padding = new Padding(3);
        ParticipantsTab.Size = new Size(794, 415);
        ParticipantsTab.TabIndex = 4;
        ParticipantsTab.Text = "Учасники";
        ParticipantsTab.UseVisualStyleBackColor = true;
        // 
        // dgvFriendships
        // 
        dgvFriendships.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvFriendships.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvFriendships.Location = new Point(0, 255);
        dgvFriendships.Name = "dgvFriendships";
        dgvFriendships.ReadOnly = true;
        dgvFriendships.RowHeadersWidth = 51;
        dgvFriendships.Size = new Size(774, 142);
        dgvFriendships.TabIndex = 20;
        dgvFriendships.Text = "dataGridView1";
        // 
        // label11
        // 
        label11.Location = new Point(0, 228);
        label11.Name = "label11";
        label11.Size = new Size(153, 24);
        label11.TabIndex = 19;
        label11.Text = "Дружба";
        // 
        // panel11
        // 
        panel11.Controls.Add(button28);
        panel11.Controls.Add(button29);
        panel11.Location = new Point(1, 403);
        panel11.Name = "panel11";
        panel11.Size = new Size(773, 43);
        panel11.TabIndex = 21;
        // 
        // button28
        // 
        button28.Location = new Point(102, 0);
        button28.Name = "button28";
        button28.Size = new Size(96, 43);
        button28.TabIndex = 4;
        button28.Text = "Видалити";
        button28.UseVisualStyleBackColor = true;
        button28.Click += btnDeleteFriendship_Click;
        // 
        // button29
        // 
        button29.Location = new Point(0, 0);
        button29.Name = "button29";
        button29.Size = new Size(96, 43);
        button29.TabIndex = 2;
        button29.Text = "Додати";
        button29.UseVisualStyleBackColor = true;
        button29.Click += btnAddFriendship_Click;
        // 
        // dgvParticipants
        // 
        dgvParticipants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvParticipants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvParticipants.Location = new Point(0, 31);
        dgvParticipants.Name = "dgvParticipants";
        dgvParticipants.ReadOnly = true;
        dgvParticipants.RowHeadersWidth = 51;
        dgvParticipants.Size = new Size(774, 142);
        dgvParticipants.TabIndex = 17;
        dgvParticipants.Text = "dataGridView1";
        // 
        // label10
        // 
        label10.Location = new Point(0, 4);
        label10.Name = "label10";
        label10.Size = new Size(153, 24);
        label10.TabIndex = 16;
        label10.Text = "Учасники";
        // 
        // panel10
        // 
        panel10.Controls.Add(button24);
        panel10.Controls.Add(button25);
        panel10.Controls.Add(button26);
        panel10.Location = new Point(1, 179);
        panel10.Name = "panel10";
        panel10.Size = new Size(773, 43);
        panel10.TabIndex = 18;
        // 
        // button24
        // 
        button24.Location = new Point(204, 0);
        button24.Name = "button24";
        button24.Size = new Size(94, 43);
        button24.TabIndex = 5;
        button24.Text = "Редагувати";
        button24.UseVisualStyleBackColor = true;
        button24.Click += btnAddParticipant_Click;
        // 
        // button25
        // 
        button25.Location = new Point(102, 0);
        button25.Name = "button25";
        button25.Size = new Size(96, 43);
        button25.TabIndex = 4;
        button25.Text = "Видалити";
        button25.UseVisualStyleBackColor = true;
        button25.Click += btnDeleteParticipant_Click;
        // 
        // button26
        // 
        button26.Location = new Point(0, 0);
        button26.Name = "button26";
        button26.Size = new Size(96, 43);
        button26.TabIndex = 2;
        button26.Text = "Додати";
        button26.UseVisualStyleBackColor = true;
        button26.Click += btnAddParticipant_Click;
        // 
        // PerformancesTab
        // 
        PerformancesTab.Controls.Add(dgvPerformances);
        PerformancesTab.Controls.Add(label12);
        PerformancesTab.Controls.Add(panel12);
        PerformancesTab.Location = new Point(4, 29);
        PerformancesTab.Name = "PerformancesTab";
        PerformancesTab.Padding = new Padding(3);
        PerformancesTab.Size = new Size(794, 415);
        PerformancesTab.TabIndex = 5;
        PerformancesTab.Text = "Виступи";
        PerformancesTab.UseVisualStyleBackColor = true;
        // 
        // dgvPerformances
        // 
        dgvPerformances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPerformances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPerformances.Location = new Point(0, 32);
        dgvPerformances.Name = "dgvPerformances";
        dgvPerformances.ReadOnly = true;
        dgvPerformances.RowHeadersWidth = 51;
        dgvPerformances.Size = new Size(794, 142);
        dgvPerformances.TabIndex = 20;
        dgvPerformances.Text = "dataGridView1";
        // 
        // label12
        // 
        label12.Location = new Point(0, 5);
        label12.Name = "label12";
        label12.Size = new Size(153, 24);
        label12.TabIndex = 19;
        label12.Text = "Виступи";
        // 
        // panel12
        // 
        panel12.Controls.Add(button30);
        panel12.Controls.Add(button31);
        panel12.Location = new Point(1, 180);
        panel12.Name = "panel12";
        panel12.Size = new Size(793, 43);
        panel12.TabIndex = 21;
        // 
        // button30
        // 
        button30.Location = new Point(102, 0);
        button30.Name = "button30";
        button30.Size = new Size(96, 43);
        button30.TabIndex = 4;
        button30.Text = "Видалити";
        button30.UseVisualStyleBackColor = true;
        button30.Click += btnDeletePerformance_Click;
        // 
        // button31
        // 
        button31.Location = new Point(0, 0);
        button31.Name = "button31";
        button31.Size = new Size(96, 43);
        button31.TabIndex = 2;
        button31.Text = "Додати";
        button31.UseVisualStyleBackColor = true;
        button31.Click += btnAddPerformance_Click;
        // 
        // CRUD
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 471);
        Controls.Add(Return);
        Controls.Add(CRUDTab);
        Name = "CRUD";
        Text = "CRUD";
        CRUDTab.ResumeLayout(false);
        SponsorsPage.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ((ISupportInitialize)dgvSponsors).EndInit();
        FestivalsTab.ResumeLayout(false);
        ((ISupportInitialize)dgvFinancing).EndInit();
        panel4.ResumeLayout(false);
        ((ISupportInitialize)dgvEvents).EndInit();
        panel2.ResumeLayout(false);
        ((ISupportInitialize)dgvFestivals).EndInit();
        panel3.ResumeLayout(false);
        StaffTab.ResumeLayout(false);
        ((ISupportInitialize)dgvService).EndInit();
        panel8.ResumeLayout(false);
        ((ISupportInitialize)dgvTechnicalWorker).EndInit();
        panel7.ResumeLayout(false);
        ((ISupportInitialize)dgvLeader).EndInit();
        panel6.ResumeLayout(false);
        ((ISupportInitialize)dgvStaff).EndInit();
        panel5.ResumeLayout(false);
        ScenesTab.ResumeLayout(false);
        ((ISupportInitialize)dgvScenes).EndInit();
        panel9.ResumeLayout(false);
        ParticipantsTab.ResumeLayout(false);
        ((ISupportInitialize)dgvFriendships).EndInit();
        panel11.ResumeLayout(false);
        ((ISupportInitialize)dgvParticipants).EndInit();
        panel10.ResumeLayout(false);
        PerformancesTab.ResumeLayout(false);
        ((ISupportInitialize)dgvPerformances).EndInit();
        panel12.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button AddBtn;
    private System.Windows.Forms.Button DeleteBtn;

    private System.Windows.Forms.DataGridView dgvSponsors;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TabControl CRUDTab;
    private System.Windows.Forms.TabPage SponsorsPage;
    private System.Windows.Forms.TabPage FestivalsTab;

    private System.Windows.Forms.Button Return;

    #endregion

    private Button UpdateBtn;
    private DataGridView dgvFestivals;
    private Label label2;
    private Panel panel3;
    private Button button2;
    private Button button3;
    private Button button1;
    private DataGridView dgvEvents;
    private Label label3;
    private Panel panel2;
    private Button button4;
    private Button button5;
    private Button button6;
    private DataGridView dgvFinancing;
    private Label label4;
    private Panel panel4;
    private Button button7;
    private Button button8;
    private Button button9;
    private TabPage StaffTab;
    private DataGridView dgvService;
    private Label label8;
    private Panel panel8;
    private Button button20;
    private Button button21;
    private DataGridView dgvTechnicalWorker;
    private Label label7;
    private Panel panel7;
    private Button button16;
    private Button button17;
    private Button button18;
    private DataGridView dgvLeader;
    private Label label6;
    private Panel panel6;
    private Button button13;
    private Button button14;
    private Button button15;
    private DataGridView dgvStaff;
    private Label label5;
    private Panel panel5;
    private Button button10;
    private Button button11;
    private Button button12;
    private TabPage ScenesTab;
    private DataGridView dgvScenes;
    private Label label9;
    private Panel panel9;
    private Button button19;
    private Button button22;
    private Button button23;
    private TabPage ParticipantsTab;
    private DataGridView dgvFriendships;
    private Label label11;
    private Panel panel11;
    private Button button28;
    private Button button29;
    private DataGridView dgvParticipants;
    private Label label10;
    private Panel panel10;
    private Button button24;
    private Button button25;
    private Button button26;
    private TabPage PerformancesTab;
    private DataGridView dgvPerformances;
    private Label label12;
    private Panel panel12;
    private Button button30;
    private Button button31;
}