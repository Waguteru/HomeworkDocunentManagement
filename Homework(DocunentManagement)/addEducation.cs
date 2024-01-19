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
    public partial class addEducation : Form
    {
        DataBase dataBase = new DataBase();
        private readonly checkUser _user;
        public addEducation(checkUser user)
        {
            _user = user;
            InitializeComponent();
           
        }


        private void addEducation_Load(object sender, EventArgs e)
        {
            label2.Text = $"{_user.Login}:{_user.Status}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEducation formEducation = new FormEducation(_user);
            formEducation.Show();
            Hide();
        }

        private void addPerson_btn_Click(object sender, EventArgs e)
        {
            dataBase.openconnection();

            var title = textBox1.Text;
            var srok_obychenia = textBox2.Text;
            var qualification = textBox3.Text;
            var tuition_feel = textBox4.Text;

            string querystring = $"insert into education_program (title,srok_obychenia,qualification,tuition_feel) values ('{title}','{srok_obychenia}','{qualification}','{tuition_feel}')";
           
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(querystring, dataBase.GetConnection());
            npgsqlCommand.ExecuteNonQuery();

            MessageBox.Show("данные успешно добавлены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataBase.closedConnection();

            FormEducation formEducation = new FormEducation(_user);
            formEducation.Show();
            Hide();
        }
    }
}
