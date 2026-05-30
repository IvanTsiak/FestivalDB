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
    public partial class EventEditForm : Form
    {
        private bool _isEditMode = false;
        private string _originalEventName;
        private string _originalFestivalName;
        private DateTime _originalFestivalStartDate;

        public EventEditForm()
        {
            InitializeComponent();
            this.Text = "Додати подію";
            LoadFestivals();
        }

        public EventEditForm(string eventName, DateTime day, TimeSpan startTime, TimeSpan endTime,
                             string theme, string eventType, string festivalName, DateTime festivalStart)
        {
            InitializeComponent();
            this.Text = "Редагувати подію";
            _isEditMode = true;

            _originalEventName = eventName;
            _originalFestivalName = festivalName;
            _originalFestivalStartDate = festivalStart;

            LoadFestivals();

            txtEventName.Text = eventName;
            dtpDay.Value = day;

            dtpStartTime.Value = DateTime.Today.Add(startTime);
            dtpEndTime.Value = DateTime.Today.Add(endTime);

            txtTheme.Text = theme;
            txtEventType.Text = eventType;

            string expectedKey = $"{festivalName}|{festivalStart:yyyy-MM-dd}";
            cmbFestival.SelectedValue = expectedKey;
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

                string displayString = $"{name} ({date:yyyy-MM-dd})";

                string valueString = $"{name}|{date:yyyy-MM-dd}";

                comboTable.Rows.Add(displayString, valueString);
            }

            cmbFestival.DataSource = comboTable;
            cmbFestival.DisplayMember = "Display";
            cmbFestival.ValueMember = "Value";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEventName.Text) || cmbFestival.SelectedValue == null)
            {
                MessageBox.Show("Назва події та вибір фестивалю є обов'язковими!");
                return;
            }

            string selectedValue = cmbFestival.SelectedValue.ToString();
            string[] parts = selectedValue.Split('|');
            string festivalName = parts[0];
            DateTime festivalStart = DateTime.Parse(parts[1]);

            try
            {
                if (_isEditMode)
                {
                    string query = @"
                        UPDATE Events 
                        SET Name = @newName, 
                            Day = @day, 
                            Start_time = @start, 
                            End_time = @end, 
                            Theme = @theme, 
                            Event_type = @type, 
                            Festival = @festName, 
                            Start_festival = @festStart 
                        WHERE Name = @oldName AND Festival = @oldFestName AND Start_festival = @oldFestStart";

                    SqlParameter[] p = {
                        new SqlParameter("@newName", txtEventName.Text),
                        new SqlParameter("@day", dtpDay.Value.Date),
                        new SqlParameter("@start", dtpStartTime.Value.TimeOfDay),
                        new SqlParameter("@end", dtpEndTime.Value.TimeOfDay),
                        new SqlParameter("@theme", string.IsNullOrWhiteSpace(txtTheme.Text) ? DBNull.Value : txtTheme.Text),
                        new SqlParameter("@type", string.IsNullOrWhiteSpace(txtEventType.Text) ? DBNull.Value : txtEventType.Text),
                        new SqlParameter("@festName", festivalName),
                        new SqlParameter("@festStart", festivalStart),

                        new SqlParameter("@oldName", _originalEventName),
                        new SqlParameter("@oldFestName", _originalFestivalName),
                        new SqlParameter("@oldFestStart", _originalFestivalStartDate)
                    };
                    DbHelper.ExecuteNonQuery(query, p);
                }
                else
                {
                    string query = @"
                        INSERT INTO Events (Name, Day, Start_time, End_time, Theme, Event_type, Festival, Start_festival) 
                        VALUES (@name, @day, @start, @end, @theme, @type, @festName, @festStart)";

                    SqlParameter[] p = {
                        new SqlParameter("@name", txtEventName.Text),
                        new SqlParameter("@day", dtpDay.Value.Date),
                        new SqlParameter("@start", dtpStartTime.Value.TimeOfDay),
                        new SqlParameter("@end", dtpEndTime.Value.TimeOfDay),
                        new SqlParameter("@theme", string.IsNullOrWhiteSpace(txtTheme.Text) ? DBNull.Value : txtTheme.Text),
                        new SqlParameter("@type", string.IsNullOrWhiteSpace(txtEventType.Text) ? DBNull.Value : txtEventType.Text),
                        new SqlParameter("@festName", festivalName),
                        new SqlParameter("@festStart", festivalStart)
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

        }
    }
}
