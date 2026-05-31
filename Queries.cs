using Microsoft.Data.SqlClient;
using System.Data;

namespace FestivalsBD;

public partial class Queries : Form
{
    public Queries()
    {
        InitializeComponent();

        LoadFestivalsIntoComboBox(cmbFestivalQ1);
        LoadFestivalsIntoComboBox(cmbFestivalQ2);
        LoadParticipantsIntoComboBox(cmbParticipantQ5);
    }
    
    private void Return_Click(object sender, EventArgs e)
    {
        MainForm form = new MainForm();

        form.Show();

        this.Close();
    }

    private void LoadFestivalsIntoComboBox(ComboBox cmb)
    {
        string query = "SELECT Name, Start_date FROM Festivals";
        DataTable dt = DbHelper.ExecuteQuery(query);

        DataTable comboTable = new DataTable();
        comboTable.Columns.Add("Display", typeof(string));
        comboTable.Columns.Add("Value", typeof(string));

        foreach (DataRow row in dt.Rows)
        {
            string name = row["Name"].ToString();
            DateTime date = Convert.ToDateTime(row["Start_date"]);

            comboTable.Rows.Add($"{name} ({date:yyyy-MM-dd})", $"{name}|{date:yyyy-MM-dd}");
        }

        cmb.DataSource = comboTable;
        cmb.DisplayMember = "Display";
        cmb.ValueMember = "Value";
    }

    private void LoadParticipantsIntoComboBox(ComboBox cmb)
    {
        string query = "SELECT ID, Name FROM Participants";
        DataTable dt = DbHelper.ExecuteQuery(query);

        DataTable comboTable = new DataTable();
        comboTable.Columns.Add("Display", typeof(string));
        comboTable.Columns.Add("Value", typeof(int));

        foreach (DataRow row in dt.Rows)
        {
            int id = Convert.ToInt32(row["ID"]);
            string name = row["Name"].ToString();

            string displayString = $"{name} (ID: {id})";

            comboTable.Rows.Add(displayString, id);
        }

        cmb.DataSource = comboTable;
        cmb.DisplayMember = "Display";
        cmb.ValueMember = "Value";
    }

    private void btnRunQ1_Click(object sender, EventArgs e)
    {
        if (cmbFestivalQ1.SelectedValue == null) return;

        string[] festParts = cmbFestivalQ1.SelectedValue.ToString().Split('|');
        string festName = festParts[0];
        DateTime festStart = DateTime.Parse(festParts[1]);

        string query = @"
                SELECT e.Name, e.Day, e.Start_time, f.Theme
                FROM Events e
                INNER JOIN Festivals f 
                    ON e.Festival = f.Name AND e.Start_festival = f.Start_date
                WHERE f.Name = @festName AND f.Start_date = @festStart";

        SqlParameter[] p = {
                new SqlParameter("@festName", festName),
                new SqlParameter("@festStart", festStart)
            };

        DataTable result = DbHelper.ExecuteQuery(query, p);
        dgvResultQ1.DataSource = result;
    }

    private void btnRunQ2_Click(object sender, EventArgs e)
    {
        if (cmbFestivalQ2.SelectedValue == null) return;

        string[] festParts = cmbFestivalQ2.SelectedValue.ToString().Split('|');
        string festName = festParts[0];
        DateTime festStart = DateTime.Parse(festParts[1]);

        string query = @"
                SELECT SUM(fin.Contribution_amount)
                FROM Financing fin
                INNER JOIN Festivals f 
                    ON fin.Fest_name = f.Name AND fin.Fest_start = f.Start_date
                WHERE f.Name = @festName AND f.Start_date = @festStart";

        SqlParameter[] p = {
                new SqlParameter("@festName", festName),
                new SqlParameter("@festStart", festStart)
            };

        object result = DbHelper.ExecuteScalar(query, p);

        if (result != null && result != DBNull.Value)
        {
            decimal totalAmount = Convert.ToDecimal(result);
            lblSumResult.Text = $"Загальна сума фінансування: {totalAmount:N2} грн";
        }
        else
        {
            lblSumResult.Text = "Загальна сума фінансування: 0.00 грн";
        }
    }

    private void btnRunQ3_Click(object sender, EventArgs e)
    {
        decimal minArea = numArea.Value;
        decimal minLoad = numLoad.Value;

        string query = @"
        SELECT s.Name, s.Type, t.Document_number, t.Stage_area, t.Maximum_load
        FROM Scenes s
        INNER JOIN Technical_data_sheets t ON s.Name = t.Stage_name
        WHERE t.Stage_area > @area AND t.Maximum_load > @load";

        SqlParameter[] p = {
        new SqlParameter("@area", minArea),
        new SqlParameter("@load", minLoad)
    };

        DataTable result = DbHelper.ExecuteQuery(query, p);
        dgvResultQ3.DataSource = result;
    }

    private void btnRunQ4_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtAreaQ4.Text))
        {
            MessageBox.Show("Введіть сферу відповідальності для пошуку!");
            return;
        }

        string query = @"
        SELECT s.Name, s.Phone_number, l.Responsibility_area
        FROM Staff s
        INNER JOIN Leader l ON s.Id = l.Id
        WHERE l.Responsibility_area LIKE @areaSearch";

        SqlParameter[] p = {

        new SqlParameter("@areaSearch", $"%{txtAreaQ4.Text}%")
    };

        DataTable result = DbHelper.ExecuteQuery(query, p);
        dgvResultQ4.DataSource = result;
    }


    private void btnRunQ5_Click(object sender, EventArgs e)
    {
        if (cmbParticipantQ5.SelectedValue == null) return;

        int participantId = Convert.ToInt32(cmbParticipantQ5.SelectedValue);


        string query = @"
        SELECT MAX(s.Capacity)
        FROM Participants p
        INNER JOIN Performance perf ON p.ID = perf.Participant_id
        INNER JOIN Scenes s ON perf.Stage_name = s.Name
        WHERE p.ID = @pId";

        SqlParameter[] p = {
        new SqlParameter("@pId", participantId)
    };

        object result = DbHelper.ExecuteScalar(query, p);

        if (result != null && result != DBNull.Value)
        {
            int maxCapacity = Convert.ToInt32(result);
            lblMaxCapacityResult.Text = $"Максимальна місткість сцени: {maxCapacity} осіб";
        }
        else
        {
            lblMaxCapacityResult.Text = "Максимальна місткість сцени: Немає даних про виступи";
        }
    }
}