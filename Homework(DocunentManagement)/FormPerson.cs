using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Homework_DocunentManagement_
{
    public partial class FormPerson : Form
    {
        DataBase dataBase = new DataBase();
        private readonly checkUser _user;
        enum RowState
        {
            Exited,
            New,
            Modfied,
            ModfiedNew,
            Deleted
        }
        public FormPerson(checkUser user)
        {
            InitializeComponent();
            _user = user;
        }

        private void IsAdmin()
        {
            button2.Enabled = _user.IsAdmin;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("surname", "фамилия");
            dataGridView1.Columns.Add("name_person", "Имя");
            dataGridView1.Columns.Add("middle_name", "отчество");
            dataGridView1.Columns.Add("date_of_birth", "дата рождения");
            dataGridView1.Columns.Add("passport_sn", "паспорт");
            dataGridView1.Columns.Add("place_of_residence", "место проживания");
            dataGridView1.Columns.Add("email", "почта");
            dataGridView1.Columns.Add("phone_number", "номер телефона");
            dataGridView1.Columns.Add("post_person", "должность");
            dataGridView1.Columns.Add("place_of_work", "место работы");
            dataGridView1.Columns.Add("id_user", "ID пользователя");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from physical_person";

            NpgsqlCommand command = new NpgsqlCommand(queryString, dataBase.GetConnection());

            dataBase.openconnection();

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetInt64(7), record.GetString(8), record.GetString(9), record.GetInt32(10), RowState.ModfiedNew);
        }

        private void FormPerson_Load(object sender, EventArgs e)
        {

            loginLabel.Text = $"{_user.Login}:{_user.Status}";
            IsAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addPerson addPerson = new addPerson(_user);
            addPerson.Show();
            Hide();
        }


        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[10].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[10].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[10].Value = RowState.Deleted;
        }

        private void Update()
        {
            dataBase.openconnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[11].Value;

                if (rowState == RowState.Exited)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[10].Value);
                    var deleteQuery = $"DELETE FROM physical_person WHERE id_user = {id}";

                    NpgsqlCommand command = new NpgsqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();

                }
            }
            dataBase.closedConnection();
        }



        private void button2_Click(object sender, EventArgs e)
        {


            deleteRow();

            //dataBase.openconnection();

            //var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            //var id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[10].Value);
            //var deleteQuery = $"DELETE FROM physical_person WHERE id_user = {id}";

            //NpgsqlCommand command = new NpgsqlCommand(deleteQuery, dataBase.GetConnection());
            //command.ExecuteNonQuery();

            //MessageBox.Show("Запись успешно удалена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //dataBase.closedConnection();

            //RefreshDataGrid(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide(_user);
            guide.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
