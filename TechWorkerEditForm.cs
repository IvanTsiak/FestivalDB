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
    public partial class TechWorkerEditForm : Form
    {
        private bool _isEditMode = false;
        private int _originalId;

        public TechWorkerEditForm()
        {
            InitializeComponent();
            this.Text = "Додати тех. працівника";
            LoadStaffList();
        }

        public TechWorkerEditForm(int id, string shift, string specialization)
        {
            InitializeComponent();
            this.Text = "Редагувати тех. працівника";
            _isEditMode = true;
            _originalId = id;

            LoadStaffList();

            cmbStaff.SelectedValue = id;
            txtShift.Text = shift;
            txtSpecialization.Text = specialization;

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
                MessageBox.Show("Оберіть працівника зі списку!");
                return;
            }

            int staffId = Convert.ToInt32(cmbStaff.SelectedValue);

            try
            {
                if (_isEditMode)
                {
                    string query = "UPDATE Technical_worker SET Shift = @shift, Specialization = @spec WHERE Id = @oldId";
                    SqlParameter[] p = {
                        new SqlParameter("@shift", string.IsNullOrWhiteSpace(txtShift.Text) ? DBNull.Value : txtShift.Text),
                        new SqlParameter("@spec", string.IsNullOrWhiteSpace(txtSpecialization.Text) ? DBNull.Value : txtSpecialization.Text),
                        new SqlParameter("@oldId", _originalId)
                    };
                    DbHelper.ExecuteNonQuery(query, p);
                }
                else
                {
                    string query = "INSERT INTO Technical_worker (Id, Shift, Specialization) VALUES (@id, @shift, @spec)";
                    SqlParameter[] p = {
                        new SqlParameter("@id", staffId),
                        new SqlParameter("@shift", string.IsNullOrWhiteSpace(txtShift.Text) ? DBNull.Value : txtShift.Text),
                        new SqlParameter("@spec", string.IsNullOrWhiteSpace(txtSpecialization.Text) ? DBNull.Value : txtSpecialization.Text)
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
