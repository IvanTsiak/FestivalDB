using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FestivalsBD
{
    public partial class HardQueries : Form
    {
        public HardQueries()
        {
            InitializeComponent();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();

            form.Show();

            this.Close();
        }

        private void btnRunQ1_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT DISTINCT p.Name, p.Type
                FROM Participants p
                WHERE NOT EXISTS (
                    SELECT *
                    FROM Scenes s
                    WHERE s.Name NOT IN (
                        SELECT perf.Stage_name
                        FROM Performance perf
                        WHERE perf.Participant_id = p.ID
                    )
                )";

            DataTable result = DbHelper.ExecuteQuery(query);
            dgvResultQ1.DataSource = result;
        }

        private void btnRunQ2_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT p1.Name, p2.Name
                FROM Participants p1
                JOIN Participants p2 ON p1.ID < p2.ID
                WHERE 
                    NOT EXISTS (
                        SELECT perf1.Stage_name 
                        FROM Performance perf1 
                        WHERE perf1.Participant_id = p1.ID
                        AND perf1.Stage_name NOT IN (
                            SELECT perf2.Stage_name 
                            FROM Performance perf2 
                            WHERE perf2.Participant_id = p2.ID
                        )
                    )
                    AND NOT EXISTS (
                        SELECT perf3.Stage_name 
                        FROM Performance perf3 
                        WHERE perf3.Participant_id = p2.ID
                        AND perf3.Stage_name NOT IN (
                            SELECT perf4.Stage_name 
                            FROM Performance perf4 
                            WHERE perf4.Participant_id = p1.ID
                        )
                    )
                    AND EXISTS (
                        SELECT 1 FROM Performance WHERE Participant_id = p1.ID
                    )";

            DataTable result = DbHelper.ExecuteQuery(query);
            dgvResultQ2.DataSource = result;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
