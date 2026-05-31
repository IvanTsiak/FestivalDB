using Microsoft.Data.SqlClient;
using System.Data;

namespace FestivalsBD;

public partial class CRUD : Form
{
    public CRUD()
    {
        InitializeComponent();
        LoadSponsorsData();
    }

    private void Return_Click(object sender, EventArgs e)
    {
        MainForm form = new MainForm();

        form.Show();

        this.Close();
    }

    private void CRUDTab_SelectIndexChanged(object sender, EventArgs e)
    {
        switch (CRUDTab.SelectedTab.Name)
        {
            case "SponsorsPage":
                LoadSponsorsData();
                break;
            case "FestivalsTab":
                LoadFestivalsData();
                LoadEventsData();
                LoadFinancingData();
                break;
            case "StaffTab":
                LoadStaffData();
                LoadLeadersData();
                LoadTechWorkersData();
                LoadServiceData();
                break;
            case "ScenesTab":
                LoadScenesData();
                break;
            case "ParticipantsTab":
                LoadParticipantsData();
                LoadFriendshipsData();
                break;
            case "PerformancesTab":
                LoadPerformancesData();
                break;
        }
    }

    private void LoadSponsorsData()
    {
        string query = "SELECT Company_name, Email FROM Sponsors";

        DataTable dt = DbHelper.ExecuteQuery(query);
        dgvSponsors.DataSource = dt;
    }

    private void LoadFestivalsData()
    {
        string queryFest = "SELECT Name, Start_date, End_date, Theme FROM Festivals";

        DataTable dtFest = DbHelper.ExecuteQuery(queryFest);
        dgvFestivals.DataSource = dtFest;
    }

    private void LoadEventsData()
    {
        string queryEvents = "SELECT Name, Day, Start_time, End_time, Theme, Event_Type, Festival, Start_Festival FROM Events";
        DataTable dtEvents = DbHelper.ExecuteQuery(queryEvents);
        dgvEvents.DataSource = dtEvents;
    }

    private void LoadFinancingData()
    {
        string queryFinancing = "SELECT Company_name, Fest_name, Fest_start, Contribution_amount FROM Financing";
        DataTable dtFinancing = DbHelper.ExecuteQuery(queryFinancing);
        dgvFinancing.DataSource = dtFinancing;
    }

    private void LoadStaffData()
    {
        string queryStaff = "SELECT Id, Name, Phone_number FROM Staff";
        DataTable dtStaff = DbHelper.ExecuteQuery(queryStaff);
        dgvStaff.DataSource = dtStaff;
    }

    private void LoadLeadersData()
    {
        string queryLeaders = "SELECT Id, Responsibility_area FROM Leader";
        DataTable dtLeaders = DbHelper.ExecuteQuery(queryLeaders);
        dgvLeader.DataSource = dtLeaders;
    }

    private void LoadTechWorkersData()
    {
        string queryTechWorkers = "SELECT Id, Shift, Specialization FROM Technical_worker";
        DataTable dtTechWorkers = DbHelper.ExecuteQuery(queryTechWorkers);
        dgvTechnicalWorker.DataSource = dtTechWorkers;
    }

    private void LoadServiceData()
    {
        string queryService = "SELECT Staff_Id, Fest_name, Fest_start FROM Service";
        DataTable dtService = DbHelper.ExecuteQuery(queryService);
        dgvService.DataSource = dtService;
    }

    private void LoadScenesData()
    {
        string query = @"
        SELECT s.Name, s.Capacity, s.Type, 
            t.Document_number, t.Stage_area, t.Stage_height, t.Maximum_load
        FROM Scenes s
        LEFT JOIN Technical_data_sheets t ON s.Name = t.Stage_name";

        DataTable dt = DbHelper.ExecuteQuery(query);
        dgvScenes.DataSource = dt;
    }

    private void LoadParticipantsData()
    {
        string query = "SELECT ID, Name, Type FROM Participants";
        DataTable dt = DbHelper.ExecuteQuery(query);
        dgvParticipants.DataSource = dt;
    }

    private void LoadFriendshipsData()
    {
        string query = @"
        SELECT 
            f.Participant1_id, 
            p1.Name, 
            f.Participant2_id, 
            p2.Name
        FROM Friendships f
        JOIN Participants p1 ON f.Participant1_id = p1.ID
        JOIN Participants p2 ON f.Participant2_id = p2.ID";

        DataTable dt = DbHelper.ExecuteQuery(query);
        dgvFriendships.DataSource = dt;
    }

    private void LoadPerformancesData()
    {
        string query = @"
        SELECT 
            p.Festival_name AS [Фестиваль],
            p.Festival_start AS [Початок фестивалю],
            p.Event_name AS [Подія],
            p.Stage_name AS [Сцена],
            part.Name AS [Учасник]
        FROM Performance p
        JOIN Participants part ON p.Participant_id = part.ID";

        DataTable dt = DbHelper.ExecuteQuery(query);
        dgvPerformances.DataSource = dt;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using (var modal = new SponsorsEditForm())
        {
            if (modal.ShowDialog() == DialogResult.OK)
            {
                LoadSponsorsData();
            }
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvSponsors.SelectedRows.Count != 0)
        {
            string companyName = dgvSponsors.SelectedRows[0].Cells["Company_name"].Value.ToString();
            string email = dgvSponsors.SelectedRows[0].Cells["Email"].Value.ToString();
            using (var modal = new SponsorsEditForm(companyName, email))
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    LoadSponsorsData();
                }
            }
        }
    }

    private void btnAddFestival_Click(object sender, EventArgs e)
    {
        using (var modal = new FestivalsEditForm())
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadFestivalsData();
        }
    }

    private void btnEditFestival_Click(object sender, EventArgs e)
    {
        if (dgvFestivals.SelectedRows.Count == 0) return;

        var row = dgvFestivals.SelectedRows[0];
        string name = row.Cells["Name"].Value.ToString();
        DateTime start = Convert.ToDateTime(row.Cells["Start_date"].Value);
        object end = row.Cells["End_date"].Value;
        string theme = row.Cells["Theme"].Value.ToString();

        using (var modal = new FestivalsEditForm(name, start, end, theme))
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadFestivalsData();
        }
    }

    private void btnAddEvent_Click(object sender, EventArgs e)
    {
        using (var modal = new EventEditForm())
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadEventsData();
        }
    }

    private void btnEditEvent_Click(object sender, EventArgs e)
    {
        if (dgvEvents.SelectedRows.Count == 0) return;

        var row = dgvEvents.SelectedRows[0];
        string name = row.Cells["Name"].Value.ToString();
        DateTime day = Convert.ToDateTime(row.Cells["Day"].Value);
        TimeSpan start = (TimeSpan)row.Cells["Start_time"].Value;
        TimeSpan end = (TimeSpan)row.Cells["End_time"].Value;
        string theme = row.Cells["Theme"].Value.ToString();
        string type = row.Cells["Event_type"].Value.ToString();
        string festName = row.Cells["Festival"].Value.ToString();
        DateTime festStart = Convert.ToDateTime(row.Cells["Start_festival"].Value);

        using (var modal = new EventEditForm(name, day, start, end, theme, type, festName, festStart))
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadEventsData();
        }
    }

    private void btnAddFinancing_Click(object sender, EventArgs e)
    {
        using (var modal = new FinancingEditForm())
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadFinancingData();
        }
    }

    private void btnEditFinancing_Click(object sender, EventArgs e)
    {
        if (dgvFinancing.SelectedRows.Count == 0) return;

        var row = dgvFinancing.SelectedRows[0];
        string compName = row.Cells["Company_name"].Value.ToString();
        string festName = row.Cells["Fest_name"].Value.ToString();
        DateTime festStart = Convert.ToDateTime(row.Cells["Fest_start"].Value);
        decimal amount = Convert.ToDecimal(row.Cells["Contribution_amount"].Value);

        using (var modal = new FinancingEditForm(compName, festName, festStart, amount))
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadFinancingData();
        }
    }

    private void btnAddStaff_Click(object sender, EventArgs e)
    {
        using (var modal = new StaffEditForm())
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadStaffData();
        }
    }

    private void btnEditStaff_Click(object sender, EventArgs e)
    {
        if (dgvStaff.SelectedRows.Count == 0) return;

        var row = dgvStaff.SelectedRows[0];
        int id = Convert.ToInt32(row.Cells["Id"].Value);
        string name = row.Cells["Name"].Value.ToString();
        string phone = row.Cells["Phone_number"].Value.ToString();

        using (var modal = new StaffEditForm(id, name, phone))
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadStaffData();
        }
    }

    private void btnAddLeader_Click(object sender, EventArgs e)
    {
        using (var modal = new LeaderEditForm())
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadLeadersData();
        }
    }

    private void btnEditLeader_Click(object sender, EventArgs e)
    {
        if (dgvLeader.SelectedRows.Count == 0) return;

        var row = dgvLeader.SelectedRows[0];
        int id = Convert.ToInt32(row.Cells["Id"].Value);
        string area = row.Cells["Responsibility_area"].Value.ToString();

        using (var modal = new LeaderEditForm(id, area))
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadLeadersData();
        }
    }

    private void btnAddScene_Click(object sender, EventArgs e)
    {
        using (var modal = new SceneEditForm())
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadScenesData();
        }
    }

    private void btnEditScene_Click(object sender, EventArgs e)
    {
        if (dgvScenes.SelectedRows.Count == 0) return;

        var row = dgvScenes.SelectedRows[0];
        string name = row.Cells["Name"].Value.ToString();
        string cap = row.Cells["Capacity"].Value.ToString();
        string type = row.Cells["Type"].Value.ToString();

        string doc = row.Cells["Document_Number"].Value.ToString();
        string area = row.Cells["Stage_area"].Value.ToString();
        string height = row.Cells["Stage_height"].Value.ToString();
        string load = row.Cells["Maximum_load"].Value.ToString();

        using (var modal = new SceneEditForm(name, cap, type, doc, area, height, load))
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadScenesData();
        }
    }

    private void btnAddParticipant_Click(object sender, EventArgs e)
    {
        using (var modal = new ParticipantEditForm())
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadParticipantsData();
        }
    }

    private void btnEditParticipant_Click(object sender, EventArgs e)
    {
        if (dgvParticipants.SelectedRows.Count == 0) return;

        var row = dgvParticipants.SelectedRows[0];
        int id = Convert.ToInt32(row.Cells["ID"].Value);
        string name = row.Cells["Name"].Value.ToString();
        string type = row.Cells["Type"].Value.ToString();

        using (var modal = new ParticipantEditForm(id, name, type))
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadParticipantsData();
        }
    }

    private void btnAddFriendship_Click(object sender, EventArgs e)
    {
        using (var modal = new FriendshipEditForm())
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadFriendshipsData();
        }
    }

    private void btnAddPerformance_Click(object sender, EventArgs e)
    {
        using (var modal = new PerfomanceEditForm())
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadPerformancesData();
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvSponsors.SelectedRows.Count != 0)
        {
            string companyName = dgvSponsors.SelectedRows[0].Cells["Company_name"].Value.ToString();
            string query = $"DELETE FROM Sponsors WHERE Company_name = @name";
            SqlParameter[] p = {
                new SqlParameter("@name", companyName)
            };
            DbHelper.ExecuteNonQuery(query, p);
            LoadSponsorsData();
        }
    }

    private void btnAddTechWorker_Click(object sender, EventArgs e)
    {
        using (var modal = new TechWorkerEditForm())
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadTechWorkersData();
        }
    }

    private void btnEditTechWorker_Click(object sender, EventArgs e)
    {
        if (dgvTechnicalWorker.SelectedRows.Count == 0) return;

        var row = dgvTechnicalWorker.SelectedRows[0];
        int id = Convert.ToInt32(row.Cells["Id"].Value);
        string shift = row.Cells["Shift"].Value.ToString();
        string spec = row.Cells["Specialization"].Value.ToString();

        using (var modal = new TechWorkerEditForm(id, shift, spec))
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadTechWorkersData();
        }
    }

    private void btnAddService_Click(object sender, EventArgs e)
    {
        using (var modal = new ServiceEditForm())
        {
            if (modal.ShowDialog() == DialogResult.OK)
                LoadServiceData();
        }
    }

    private void tabPage1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void tabPage2_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void label1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button1_Click_2(object sender, EventArgs e)
    {

    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void panel3_Paint_1(object sender, PaintEventArgs e)
    {

    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void label9_Click(object sender, EventArgs e)
    {

    }
}