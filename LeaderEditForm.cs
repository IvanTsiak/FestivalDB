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
    public partial class LeaderEditForm : Form
    {
        private bool _isEditMode = false;
        private int _originalId;

        public LeaderEditForm()
        {
            InitializeComponent();
            this.Text = "Додати керівника";
            LoadStaffList();
        }

        public LeaderEditForm(int id, string area)
        {
            InitializeComponent();
            this.Text = "Редагувати керівника";
            _isEditMode = true;
            _originalId = id;

            LoadStaffList();

            cmbStaff.SelectedValue = id;
            txtArea.Text = area;

            cmbStaff.Enabled = false;
        }

        private void LoadStaffList()
        {
            string query = "SELECT Id, Name FROM Staff";
            DataTable dt = DbHelper.ExecuteQuery(query);

            cmbStaff.DataSource = dt;
            cmbStaff.DisplayMember = "Name";
            cmbStaff.ValueMember = "Id"; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbStaff.SelectedValue == null)
            {
                MessageBox.Show("Будь ласка, оберіть працівника зі списку!");
                return;
            }

            int staffId = Convert.ToInt32(cmbStaff.SelectedValue);

            try
            {
                if (_isEditMode)
                {
                    string query = "UPDATE Leader SET Responsibility_area = @area WHERE Id = @oldId";
                    SqlParameter[] p = {
                        new SqlParameter("@area", string.IsNullOrWhiteSpace(txtArea.Text) ? DBNull.Value : txtArea.Text),
                        new SqlParameter("@oldId", _originalId)
                    };
                    DbHelper.ExecuteNonQuery(query, p);
                }
                else
                {
                    string query = "INSERT INTO Leader (Id, Responsibility_area) VALUES (@id, @area)";
                    SqlParameter[] p = {
                        new SqlParameter("@id", staffId),
                        new SqlParameter("@area", string.IsNullOrWhiteSpace(txtArea.Text) ? DBNull.Value : txtArea.Text)
                    };
                    DbHelper.ExecuteNonQuery(query, p);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка збереження! Можливо, цей працівник вже є керівником.\n\n" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
