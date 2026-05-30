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
    public partial class StaffEditForm : Form
    {
        private bool _isEditMode = false;
        private int _originalId;

        public StaffEditForm()
        {
            InitializeComponent();
            this.Text = "Додати працівника";
        }

        public StaffEditForm(int id, string name, string phone)
        {
            InitializeComponent();
            this.Text = "Редагувати працівника";
            _isEditMode = true;
            _originalId = id;

            txtId.Text = id.ToString();
            txtName.Text = name;
            txtPhone.Text = phone;

            txtId.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Поля ID та ПІБ є обов'язковими!");
                return;
            }

            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("ID має бути числом!");
                return;
            }

            try
            {
                if (_isEditMode)
                {
                    string query = "UPDATE Staff SET Name = @name, Phone_number = @phone WHERE Id = @oldId";
                    SqlParameter[] p = {
                        new SqlParameter("@name", txtName.Text),
                        new SqlParameter("@phone", string.IsNullOrWhiteSpace(txtPhone.Text) ? DBNull.Value : txtPhone.Text),
                        new SqlParameter("@oldId", _originalId)
                    };
                    DbHelper.ExecuteNonQuery(query, p);
                }
                else
                {
                    string query = "INSERT INTO Staff (Id, Name, Phone_number) VALUES (@id, @name, @phone)";
                    SqlParameter[] p = {
                        new SqlParameter("@id", id),
                        new SqlParameter("@name", txtName.Text),
                        new SqlParameter("@phone", string.IsNullOrWhiteSpace(txtPhone.Text) ? DBNull.Value : txtPhone.Text)
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
