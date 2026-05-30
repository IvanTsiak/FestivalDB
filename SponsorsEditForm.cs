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
    public partial class SponsorsEditForm : Form
    {
        private bool _isEditMode = false;
        private string _originalCompanyName;

        public SponsorsEditForm()
        {
            InitializeComponent();
            this.Text = "Add Sponsor";
        }

        public SponsorsEditForm(string companyName, string email)
        {
            InitializeComponent();
            this.Text = "Edit Sponsor";
            _isEditMode = true;
            _originalCompanyName = companyName;
            txtCompanyName.Text = companyName;
            txtEmail.Text = email;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                MessageBox.Show("Company Name is required!");
                return;
            }
            
            try
            {
                if (_isEditMode)
                {
                    string query = @"
                        UPDATE Sponsors
                        SET Company_name = @newName,
                        Email = @newEmail
                        WHERE Company_name = @oldName";

                    SqlParameter[] p =
                    {
                        new SqlParameter("@newName", txtCompanyName.Text),
                        new SqlParameter("@newEmail", txtEmail.Text),
                        new SqlParameter("@oldName", _originalCompanyName)
                    };
                    DbHelper.ExecuteNonQuery(query, p);
                }
                else
                {
                    string query = "INSERT INTO Sponsors (Company_name, Email) VALUES (@name, @email)";
                    SqlParameter[] p = {
                        new SqlParameter("@name", txtCompanyName.Text),
                        new SqlParameter("@email", string.IsNullOrWhiteSpace(txtEmail.Text) ? DBNull.Value : txtEmail.Text)
                    };
                    DbHelper.ExecuteNonQuery(query, p);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving sponsor: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
