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
    public partial class FinancingEditForm : Form
    {
        private bool _isEditMode = false;

        private string _oldCompany;
        private string _oldFestName;
        private DateTime _oldFestStart;

        public FinancingEditForm()
        {
            InitializeComponent();
            this.Text = "Додати фінансування";
            LoadSponsors();
            LoadFestivals();
        }

        public FinancingEditForm(string company, string festName, DateTime festStart, decimal amount)
        {
            InitializeComponent();
            this.Text = "Редагувати фінансування";
            _isEditMode = true;

            _oldCompany = company;
            _oldFestName = festName;
            _oldFestStart = festStart;

            LoadSponsors();
            LoadFestivals();

            cmbCompany.SelectedValue = company;
            cmbFestival.SelectedValue = $"{festName}|{festStart:yyyy-MM-dd}";
            txtAmount.Text = amount.ToString("0.00");
        }

        private void LoadSponsors()
        {
            string query = "SELECT Company_name FROM Sponsors";
            DataTable dt = DbHelper.ExecuteQuery(query);

            cmbCompany.DataSource = dt;
            cmbCompany.DisplayMember = "Company_name";
            cmbCompany.ValueMember = "Company_name";
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
            if (cmbCompany.SelectedValue == null || cmbFestival.SelectedValue == null || string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Сума введена некоректно! Використовуйте цифри.");
                return;
            }

            string company = cmbCompany.SelectedValue.ToString();

            string[] festParts = cmbFestival.SelectedValue.ToString().Split('|');
            string festName = festParts[0];
            DateTime festStart = DateTime.Parse(festParts[1]);

            try
            {
                if (_isEditMode)
                {
                    string query = @"
                        UPDATE Financing 
                        SET Company_name = @newComp, 
                            Fest_name = @newFestName, 
                            Fest_start = @newFestStart, 
                            Contribution_amount = @amount 
                        WHERE Company_name = @oldComp AND Fest_name = @oldFestName AND Fest_start = @oldFestStart";

                    SqlParameter[] p = {
                        new SqlParameter("@newComp", company),
                        new SqlParameter("@newFestName", festName),
                        new SqlParameter("@newFestStart", festStart),
                        new SqlParameter("@amount", amount),

                        new SqlParameter("@oldComp", _oldCompany),
                        new SqlParameter("@oldFestName", _oldFestName),
                        new SqlParameter("@oldFestStart", _oldFestStart)
                    };
                    DbHelper.ExecuteNonQuery(query, p);
                }
                else
                {
                    string query = @"
                        INSERT INTO Financing (Company_name, Fest_name, Fest_start, Contribution_amount) 
                        VALUES (@comp, @festName, @festStart, @amount)";

                    SqlParameter[] p = {
                        new SqlParameter("@comp", company),
                        new SqlParameter("@festName", festName),
                        new SqlParameter("@festStart", festStart),
                        new SqlParameter("@amount", amount)
                    };
                    DbHelper.ExecuteNonQuery(query, p);
                }

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
