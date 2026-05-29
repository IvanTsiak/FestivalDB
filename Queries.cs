namespace FestivalsBD;

public partial class Queries : Form
{
    public Queries()
    {
        InitializeComponent();
    }

    private void Return_Click(object sender, EventArgs e)
    {
        MainForm form = new MainForm();
        
        form.Show();

        this.Close();
    }
}