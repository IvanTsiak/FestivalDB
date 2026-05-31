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
    public partial class ParticipantEditForm : Form
    {
        private bool _isEditMode = false;
        private int _originalId;

        public ParticipantEditForm()
        {
            InitializeComponent();
            this.Text = "Додати учасника";
        }

        public ParticipantEditForm(int id, string name, string type)
        {
            InitializeComponent();
            this.Text = "Редагувати учасника";
            _isEditMode = true;
            _originalId = id;

            txtId.Text = id.ToString();
            txtName.Text = name;
            txtType.Text = type;

            txtId.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("ID та Ім'я є обов'язковими!");
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
                    string query = "UPDATE Participants SET Name = @name, Type = @type WHERE ID = @oldId";
                    SqlParameter[] p = {
                        new SqlParameter("@name", txtName.Text),
                        new SqlParameter("@type", string.IsNullOrWhiteSpace(txtType.Text) ? DBNull.Value : txtType.Text),
                        new SqlParameter("@oldId", _originalId)
                    };
                    DbHelper.ExecuteNonQuery(query, p);
                }
                else
                {
                    string query = "INSERT INTO Participants (ID, Name, Type) VALUES (@id, @name, @type)";
                    SqlParameter[] p = {
                        new SqlParameter("@id", id),
                        new SqlParameter("@name", txtName.Text),
                        new SqlParameter("@type", string.IsNullOrWhiteSpace(txtType.Text) ? DBNull.Value : txtType.Text)
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
