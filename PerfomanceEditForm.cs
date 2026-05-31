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
    public partial class PerfomanceEditForm : Form
    {
        public PerfomanceEditForm()
        {
            InitializeComponent();
            this.Text = "Призначити виступ";

            LoadEvents();
            LoadStages();
            LoadParticipants();
        }

        private void LoadEvents()
        {
            string query = "SELECT Name, Festival, Start_festival FROM Events";
            DataTable dt = DbHelper.ExecuteQuery(query);

            DataTable comboTable = new DataTable();
            comboTable.Columns.Add("Display", typeof(string));
            comboTable.Columns.Add("Value", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                string eventName = row["Name"].ToString();
                string festName = row["Festival"].ToString();
                DateTime festStart = Convert.ToDateTime(row["Start_festival"]);

                string displayString = $"{eventName} на {festName} ({festStart:yyyy-MM-dd})";

                string valueString = $"{eventName}|{festName}|{festStart:yyyy-MM-dd}";

                comboTable.Rows.Add(displayString, valueString);
            }

            cmbEvent.DataSource = comboTable;
            cmbEvent.DisplayMember = "Display";
            cmbEvent.ValueMember = "Value";
        }

        private void LoadStages()
        {
            string query = "SELECT Name FROM Scenes";
            DataTable dt = DbHelper.ExecuteQuery(query);

            cmbStage.DataSource = dt;
            cmbStage.DisplayMember = "Name";
            cmbStage.ValueMember = "Name";
        }

        private void LoadParticipants()
        {
            string query = "SELECT ID, Name FROM Participants";
            DataTable dt = DbHelper.ExecuteQuery(query);

            cmbParticipant.DataSource = dt;
            cmbParticipant.DisplayMember = "Name";
            cmbParticipant.ValueMember = "ID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbEvent.SelectedValue == null || cmbStage.SelectedValue == null || cmbParticipant.SelectedValue == null)
            {
                MessageBox.Show("Будь ласка, оберіть подію, сцену та учасника!");
                return;
            }

            string[] eventParts = cmbEvent.SelectedValue.ToString().Split('|');
            string eventName = eventParts[0];
            string festName = eventParts[1];
            DateTime festStart = DateTime.Parse(eventParts[2]);

            string stageName = cmbStage.SelectedValue.ToString();
            int participantId = Convert.ToInt32(cmbParticipant.SelectedValue);

            try
            {
                string query = @"
                    INSERT INTO Performance (Festival_name, Festival_start, Event_name, Stage_name, Participant_id) 
                    VALUES (@festName, @festStart, @eventName, @stageName, @partId)";

                SqlParameter[] p = {
                    new SqlParameter("@festName", festName),
                    new SqlParameter("@festStart", festStart),
                    new SqlParameter("@eventName", eventName),
                    new SqlParameter("@stageName", stageName),
                    new SqlParameter("@partId", participantId)
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
