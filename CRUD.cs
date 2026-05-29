using System.Data;

namespace FestivalsBD;

public partial class CRUD : Form
{
    public CRUD()
    {
        InitializeComponent();
    }

    private void Return_Click(object sender, EventArgs e)
    {
        MainForm form = new MainForm();

        form.Show();

        this.Close();
    }

    private void SponsorsTab_SelectIndexChanged(object sender, EventArgs e)
    {
        switch (SponsorsTab.SelectedTab.Name)
        {
            case "SponsorsTab":
                LoadSponsorsData();
                break;
        }
    }

    private void LoadSponsorsData()
    {
        string query = "SELECT Company_name, Email FROM Sponsors";

        DataTable dt = DbHelper.ExecuteQuery(query);
        dgvSponsors.DataSource = dt;
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
}