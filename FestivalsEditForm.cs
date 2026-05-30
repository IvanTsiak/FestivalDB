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
    public partial class FestivalsEditForm : Form
    {
        private bool _isEditMode = false;
        private string _originalName;
        private DateTime _originalStartDate;

        public FestivalsEditForm()
        {
            InitializeComponent();
            this.Text = "Додати фестиваль";
        }

        public FestivalsEditForm(string name, DateTime startDate, object endDate, string theme)
        {
            InitializeComponent();
            this.Text = "Редагувати фестиваль";
            _isEditMode = true;

            _originalName = name;
            _originalStartDate = startDate;

            txtName.Text = name;
            dtpStartDate.Value = startDate;
            txtTheme.Text = theme;

            if (endDate != DBNull.Value && endDate != null)
            {
                dtpEndDate.Checked = true;
                dtpEndDate.Value = Convert.ToDateTime(endDate);
            }
            else
            {
                dtpEndDate.Checked = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Назва фестивалю обов'язкова!");
                return;
            }

            try
            {
                if (_isEditMode)
                {
                    string query = @"
                        UPDATE Festivals 
                        SET Name = @newName, 
                            Start_date = @newStart, 
                            End_date = @end, 
                            Theme = @theme 
                        WHERE Name = @oldName AND Start_date = @oldStart";

                    SqlParameter[] p = {
                        new SqlParameter("@newName", txtName.Text),
                        new SqlParameter("@newStart", dtpStartDate.Value.Date),
                        new SqlParameter("@end", dtpEndDate.Checked ? (object)dtpEndDate.Value.Date : DBNull.Value),
                        new SqlParameter("@theme", string.IsNullOrWhiteSpace(txtTheme.Text) ? DBNull.Value : txtTheme.Text),

                        new SqlParameter("@oldName", _originalName),
                        new SqlParameter("@oldStart", _originalStartDate)
                    };
                    DbHelper.ExecuteNonQuery(query, p);
                }
                else
                {
                    string query = @"
                        INSERT INTO Festivals (Name, Start_date, End_date, Theme) 
                        VALUES (@name, @start, @end, @theme)";

                    SqlParameter[] p = {
                        new SqlParameter("@name", txtName.Text),
                        new SqlParameter("@start", dtpStartDate.Value.Date),
                        new SqlParameter("@end", dtpEndDate.Checked ? (object)dtpEndDate.Value.Date : DBNull.Value),
                        new SqlParameter("@theme", string.IsNullOrWhiteSpace(txtTheme.Text) ? DBNull.Value : txtTheme.Text)
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
