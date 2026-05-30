using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FestivalsBD
{
    public partial class ServiceEditForm : Form
    {
        public ServiceEditForm()
        {
            InitializeComponent();
            this.Text = "Призначити обслуговування";
            LoadStaff();
            LoadFestivals();
        }

        private void LoadStaff()
        {
            string query = @"
                SELECT s.Id, s.Name 
                FROM Staff s
                INNER JOIN Staff tw ON s.Id = tw.Id";

            DataTable dt = DbHelper.ExecuteQuery(query);

            cmbStaff.DataSource = dt;
            cmbStaff.DisplayMember = "Name";
            cmbStaff.ValueMember = "Id";
        }

        private void LoadFestivals()
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

            cmbFestival.DataSource = comboTable;
            cmbFestival.DisplayMember = "Display";
            cmbFestival.ValueMember = "Value";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbStaff.SelectedValue == null || cmbFestival.SelectedValue == null)
            {
                MessageBox.Show("Оберіть працівника та фестиваль!");
                return;
            }

            int staffId = Convert.ToInt32(cmbStaff.SelectedValue);

            string[] festParts = cmbFestival.SelectedValue.ToString().Split('|');
            string festName = festParts[0];
            DateTime festStart = DateTime.Parse(festParts[1]);

            try
            {

                string query = @"
                    INSERT INTO Service (Staff_id, Fest_name, Fest_start) 
                    VALUES (@staffId, @festName, @festStart)";

                SqlParameter[] p = {
                    new SqlParameter("@staffId", staffId),
                    new SqlParameter("@festName", festName),
                    new SqlParameter("@festStart", festStart)
                };

                DbHelper.ExecuteNonQuery(query, p);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
