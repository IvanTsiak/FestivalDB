namespace FestivalsBD;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void ToCRUDButton_Click(object sender, EventArgs e)
    {
        CRUD crudForm = new CRUD();

        crudForm.Show();

        this.Hide();
    }

    private void ToQueriesButton_Click(object sender, EventArgs e)
    {
        Queries queriesForm = new Queries();

        queriesForm.Show();

        this.Hide();
    }

    private void ToHardQueriesButton_Click(object sender, EventArgs e)
    {
        HardQueries queriesForm = new HardQueries();

        queriesForm.Show();

        this.Hide();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
}