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
    public partial class FormEducation : Form
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
        public FormEducation(checkUser user)
        {
            _user = user;
            InitializeComponent();
        }

        private void FormEducation_Load(object sender, EventArgs e)
        {
            loginLabel.Text = $"{_user.Login}:{_user.Status}";
            CreateColumns();
            RefreshDataGrid(dataGridView1);

        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("title", "название"); //0
            dataGridView1.Columns.Add("srok_obychenia", "срок обучения"); //1
            dataGridView1.Columns.Add("qualification", "квалификация"); //2
            dataGridView1.Columns.Add("tuition_feel", "стоимость обучения"); //3
            dataGridView1.Columns.Add("id_program", "ID программы"); //4

        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from education_program";

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
            dgw.Rows.Add(record.GetString(0), record.GetInt32(1), record.GetString(2), record.GetInt64(3), record.GetInt32(4), RowState.ModfiedNew);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addEducation addeducation = new addEducation(_user);
            addeducation.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide(_user);
            guide.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
