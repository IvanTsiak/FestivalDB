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
    public partial class FriendshipEditForm : Form
    {
        public FriendshipEditForm()
        {
            InitializeComponent();
            this.Text = "Додати дружбу";
            LoadParticipants();
        }

        private void LoadParticipants()
        {
            string query = "SELECT ID, Name FROM Participants";
            DataTable dt = DbHelper.ExecuteQuery(query);

            DataTable dt2 = dt.Copy();

            cmbParticipant1.DataSource = dt;
            cmbParticipant1.DisplayMember = "Name";
            cmbParticipant1.ValueMember = "ID";

            cmbParticipant2.DataSource = dt2;
            cmbParticipant2.DisplayMember = "Name";
            cmbParticipant2.ValueMember = "ID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbParticipant1.SelectedValue == null || cmbParticipant2.SelectedValue == null)
            {
                MessageBox.Show("Оберіть обох учасників!");
                return;
            }

            int p1Id = Convert.ToInt32(cmbParticipant1.SelectedValue);
            int p2Id = Convert.ToInt32(cmbParticipant2.SelectedValue);

            if (p1Id == p2Id)
            {
                MessageBox.Show("Учасник не може бути другом самому собі! Оберіть різних виконавців.");
                return;
            }

            try
            {
                string query = "INSERT INTO Friendships (Participant1_id, Participant2_id) VALUES (@p1, @p2)";
                SqlParameter[] p = {
                    new SqlParameter("@p1", p1Id),
                    new SqlParameter("@p2", p2Id)
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
