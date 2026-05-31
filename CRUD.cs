using Microsoft.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

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

    ///
    /// Load data funcs
    ///

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
            f.Participant1_id [Friend1 Id], 
            p1.Name AS [Friend1 Name], 
            f.Participant2_id AS [Friend2 Id], 
            p2.Name AS [Friend2 Name]
        FROM Friendships f
        JOIN Participants p1 ON f.Participant1_id = p1.ID
        JOIN Participants p2 ON f.Participant2_id = p2.ID";

        DataTable dt = DbHelper.ExecuteQuery(query);
        dgvFriendships.DataSource = dt;
    }

    private void LoadPerformancesData()
    {
        string query = @"
        SELECT p.Festival_name, p.Festival_start, p.Event_name, p.Stage_name, part.ID, part.Name
        FROM Performance p
        JOIN Participants part ON p.Participant_id = part.ID";

        DataTable dt = DbHelper.ExecuteQuery(query);
        dgvPerformances.DataSource = dt;
    }

    ///
    /// Buttons Add and Edit
    ///

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

    ///
    /// Buttons Delete
    /// 

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvSponsors.SelectedRows.Count != 0)
        {
            string companyName = dgvSponsors.SelectedRows[0].Cells["Company_name"].Value.ToString();

            if (MessageBox.Show($"Видалити фестиваль '{companyName}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = $"DELETE FROM Sponsors WHERE Company_name = @name";
                SqlParameter[] p = {
                    new SqlParameter("@name", companyName)
                };
                DbHelper.ExecuteNonQuery(query, p);
                LoadSponsorsData();
            }
        }
    }

    private void btnDeleteFestival_Click(object sender, EventArgs e)
    {
        if (dgvFestivals.SelectedRows.Count == 0) return;

        string name = dgvFestivals.SelectedRows[0].Cells["Name"].Value.ToString();
        DateTime start = Convert.ToDateTime(dgvFestivals.SelectedRows[0].Cells["Start_date"].Value);

        if (MessageBox.Show($"Видалити фестиваль '{name}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            try
            {
                string query = "DELETE FROM Festivals WHERE Name = @name AND Start_date = @start";
                SqlParameter[] p = {
                    new SqlParameter("@name", name),
                    new SqlParameter("@start", start)
                };
                DbHelper.ExecuteNonQuery(query, p);
                LoadFestivalsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    private void btnDeleteEvent_Click(object sender, EventArgs e)
    {
        if (dgvEvents.SelectedRows.Count == 0) return;

        string name = dgvEvents.SelectedRows[0].Cells["Name"].Value.ToString();
        string festName = dgvEvents.SelectedRows[0].Cells["Festival"].Value.ToString();
        DateTime festStart = Convert.ToDateTime(dgvEvents.SelectedRows[0].Cells["Start_festival"].Value);

        if (MessageBox.Show($"Видалити подію '{name}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            try
            {
                string query = "DELETE FROM Events WHERE Name = @name AND Festival = @festName AND Start_festival = @festStart";
                SqlParameter[] p = {
                    new SqlParameter("@name", name),
                    new SqlParameter("@festName", festName),
                    new SqlParameter("@festStart", festStart)
                };
                DbHelper.ExecuteNonQuery(query, p);
                LoadEventsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    private void btnDeleteFinancing_Click(object sender, EventArgs e)
    {
        if (dgvFinancing.SelectedRows.Count == 0) return;

        string comp = dgvFinancing.SelectedRows[0].Cells["Company_name"].Value.ToString();
        string festName = dgvFinancing.SelectedRows[0].Cells["Fest_name"].Value.ToString();
        DateTime festStart = Convert.ToDateTime(dgvFinancing.SelectedRows[0].Cells["Fest_start"].Value);

        if (MessageBox.Show("Видалити запис про фінансування?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            string query = "DELETE FROM Financing WHERE Company_name = @comp AND Fest_name = @festName AND Fest_start = @festStart";
            SqlParameter[] p = {
                new SqlParameter("@comp", comp),
                new SqlParameter("@festName", festName),
                new SqlParameter("@festStart", festStart)
            };
            DbHelper.ExecuteNonQuery(query, p);
            LoadFinancingData();
        }
    }

    private void btnDeleteStaff_Click(object sender, EventArgs e)
    {
        if (dgvStaff.SelectedRows.Count == 0) return;

        int id = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells["Id"].Value);
        string name = dgvStaff.SelectedRows[0].Cells["Name"].Value.ToString();

        if (MessageBox.Show($"Видалити працівника '{name}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            try
            {
                string query = "DELETE FROM Staff WHERE Id = @id";
                SqlParameter[] p = { new SqlParameter("@id", id) };
                DbHelper.ExecuteNonQuery(query, p);
                LoadStaffData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    private void btnDeleteLeader_Click(object sender, EventArgs e)
    {
        if (dgvLeader.SelectedRows.Count == 0) return;

        int id = Convert.ToInt32(dgvLeader.SelectedRows[0].Cells["Id"].Value);

        if (MessageBox.Show("Зняти працівника з посади керівника?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            string query = "DELETE FROM Leader WHERE Id = @id";
            SqlParameter[] p = { new SqlParameter("@id", id) };
            DbHelper.ExecuteNonQuery(query, p);
            LoadLeadersData();
        }
    }

    private void btnDeleteTechWorker_Click(object sender, EventArgs e)
    {
        if (dgvTechnicalWorker.SelectedRows.Count == 0) return;

        int id = Convert.ToInt32(dgvTechnicalWorker.SelectedRows[0].Cells["Id"].Value);

        if (MessageBox.Show("Видалити дані технічного працівника?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            string query = "DELETE FROM Technical_worker WHERE Id = @id";
            SqlParameter[] p = { new SqlParameter("@id", id) };
            DbHelper.ExecuteNonQuery(query, p);
            LoadTechWorkersData();
        }
    }

    private void btnDeleteService_Click(object sender, EventArgs e)
    {
        if (dgvService.SelectedRows.Count == 0) return;

        int staffId = Convert.ToInt32(dgvService.SelectedRows[0].Cells["Staff_Id"].Value);
        string festName = dgvService.SelectedRows[0].Cells["Fest_name"].Value.ToString();
        DateTime festStart = Convert.ToDateTime(dgvService.SelectedRows[0].Cells["Fest_start"].Value);

        if (MessageBox.Show("Скасувати призначення на обслуговування?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            string query = "DELETE FROM Service WHERE Staff_Id = @id AND Fest_name = @fest AND Fest_start = @start";
            SqlParameter[] p = {
                new SqlParameter("@id", staffId),
                new SqlParameter("@fest", festName),
                new SqlParameter("@start", festStart)
            };
            DbHelper.ExecuteNonQuery(query, p);
            LoadServiceData();
        }
    }

    private void btnDeleteScene_Click(object sender, EventArgs e)
    {
        if (dgvScenes.SelectedRows.Count == 0) return;

        string name = dgvScenes.SelectedRows[0].Cells["Name"].Value.ToString();

        if (MessageBox.Show($"Видалити сцену '{name}' та її паспорт?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            try
            {
                string query = @"
                    DELETE FROM Technical_data_sheets WHERE Stage_name = @name;
                    DELETE FROM Scenes WHERE Name = @name;";

                SqlParameter[] p = { new SqlParameter("@name", name) };
                DbHelper.ExecuteNonQuery(query, p);
                LoadScenesData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка! Можливо, на цій сцені заплановано виступи.\n\n" + ex.Message);
            }
        }
    }

    private void btnDeleteParticipant_Click(object sender, EventArgs e)
    {
        if (dgvParticipants.SelectedRows.Count == 0) return;

        int id = Convert.ToInt32(dgvParticipants.SelectedRows[0].Cells["ID"].Value);
        string name = dgvParticipants.SelectedRows[0].Cells["Name"].Value.ToString();

        if (MessageBox.Show($"Видалити учасника '{name}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            try
            {
                string query = "DELETE FROM Participants WHERE ID = @id";
                SqlParameter[] p = { new SqlParameter("@id", id) };
                DbHelper.ExecuteNonQuery(query, p);
                LoadParticipantsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    private void btnDeleteFriendship_Click(object sender, EventArgs e)
    {
        if (dgvFriendships.SelectedRows.Count == 0) return;

        int p1 = Convert.ToInt32(dgvFriendships.SelectedRows[0].Cells["Participant1_id"].Value);
        int p2 = Convert.ToInt32(dgvFriendships.SelectedRows[0].Cells["Participant2_id"].Value);

        if (MessageBox.Show("Видалити запис про дружбу?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            string query = "DELETE FROM Friendships WHERE Participant1_id = @p1 AND Participant2_id = @p2";
            SqlParameter[] p = {
                new SqlParameter("@p1", p1),
                new SqlParameter("@p2", p2)
            };
            DbHelper.ExecuteNonQuery(query, p);
            LoadFriendshipsData();
        }
    }

    private void btnDeletePerformance_Click(object sender, EventArgs e)
    {
        if (dgvPerformances.SelectedRows.Count == 0) return;

        var row = dgvPerformances.SelectedRows[0];
        string festName = row.Cells["Festival_name"].Value.ToString();
        DateTime festStart = Convert.ToDateTime(row.Cells["Festival_start"].Value);
        string eventName = row.Cells["Event_name"].Value.ToString();
        string stage = row.Cells["Stage_name"].Value.ToString();
        int partId = Convert.ToInt16(row.Cells["ID"].Value.ToString());

        if (MessageBox.Show("Скасувати виступ учасника?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            string query = @"
                DELETE FROM Performance 
                WHERE Festival_name = @fest 
                  AND Festival_start = @start 
                  AND Event_name = @event 
                  AND Stage_name = @stage 
                  AND Participant_id = @partId";

            SqlParameter[] p = {
                new SqlParameter("@fest", festName),
                new SqlParameter("@start", festStart),
                new SqlParameter("@event", eventName),
                new SqlParameter("@stage", stage),
                new SqlParameter("@partId", partId)
            };
            DbHelper.ExecuteNonQuery(query, p);
            LoadPerformancesData();
        }
    }
}