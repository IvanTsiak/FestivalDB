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
    public partial class SceneEditForm : Form
    {
        private bool _isEditMode = false;
        private string _originalName;

        public SceneEditForm()
        {
            InitializeComponent();
            this.Text = "Додати сцену та паспорт";
        }

        public SceneEditForm(string name, string capacity, string type,
                             string doc, string area, string height, string load)
        {
            InitializeComponent();
            this.Text = "Редагувати сцену";
            _isEditMode = true;
            _originalName = name;

            txtName.Text = name;
            txtCapacity.Text = capacity;
            txtType.Text = type;

            txtDocNumber.Text = doc;
            txtArea.Text = area;
            txtHeight.Text = height;
            txtLoad.Text = load;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDocNumber.Text))
            {
                MessageBox.Show("Назва сцени та номер паспорта обов'язкові!");
                return;
            }

            try
            {
                if (_isEditMode)
                {
                    string queryUpdate = @"
                        UPDATE Scenes 
                        SET Name = @newName, Capacity = @cap, Type = @type 
                        WHERE Name = @oldName;
                        
                        -- 2. Оновлюємо Паспорт. Шукаємо вже за @newName (бо каскад вже спрацював рядок вище)
                        -- IF EXISTS потрібен, якщо раптом сцени є, а паспорта до неї ще не було
                        IF EXISTS (SELECT 1 FROM Technical_data_sheets WHERE Stage_name = @newName)
                            UPDATE Technical_data_sheets 
                            SET Document_number = @doc, Stage_area = @area, Stage_height = @height, Maximum_load = @load 
                            WHERE Stage_name = @newName;
                        ELSE
                            INSERT INTO Technical_data_sheets (Document_number, Stage_area, Stage_height, Maximum_load, Stage_name)
                            VALUES (@doc, @area, @height, @load, @newName);
                    ";

                    SqlParameter[] p = {
                        new SqlParameter("@newName", txtName.Text),
                        new SqlParameter("@cap", Convert.ToInt32(txtCapacity.Text)),
                        new SqlParameter("@type", string.IsNullOrWhiteSpace(txtType.Text) ? DBNull.Value : txtType.Text),

                        new SqlParameter("@doc", txtDocNumber.Text),
                        new SqlParameter("@area", Convert.ToDecimal(txtArea.Text)),
                        new SqlParameter("@height", Convert.ToDecimal(txtHeight.Text)),
                        new SqlParameter("@load", Convert.ToDecimal(txtLoad.Text)),

                        new SqlParameter("@oldName", _originalName)
                    };
                    DbHelper.ExecuteNonQuery(queryUpdate, p);
                }
                else
                {
                    string queryInsert = @"
                        INSERT INTO Scenes (Name, Capacity, Type) 
                        VALUES (@name, @cap, @type);

                        INSERT INTO Technical_data_sheets (Document_number, Stage_area, Stage_height, Maximum_load, Stage_name) 
                        VALUES (@doc, @area, @height, @load, @name);
                    ";

                    SqlParameter[] p = {
                        new SqlParameter("@name", txtName.Text),
                        new SqlParameter("@cap", Convert.ToInt32(txtCapacity.Text)),
                        new SqlParameter("@type", string.IsNullOrWhiteSpace(txtType.Text) ? DBNull.Value : txtType.Text),

                        new SqlParameter("@doc", txtDocNumber.Text),
                        new SqlParameter("@area", Convert.ToDecimal(txtArea.Text)),
                        new SqlParameter("@height", Convert.ToDecimal(txtHeight.Text)),
                        new SqlParameter("@load", Convert.ToDecimal(txtLoad.Text))
                    };
                    DbHelper.ExecuteNonQuery(queryInsert, p);
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
