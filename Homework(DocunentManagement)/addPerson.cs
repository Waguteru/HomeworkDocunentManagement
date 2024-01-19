using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_DocunentManagement_
{
    public partial class addPerson : Form
    {
        DataBase dataBase = new DataBase();
        private readonly checkUser _user;
        public addPerson(checkUser user)
        {
            InitializeComponent();
            _user = user;
        }



        private void addPerson_Load(object sender, EventArgs e)
        {
            label2.Text = $"{_user.Login}:{_user.Status}";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            FormPerson person = new FormPerson(_user);
            person.Show();
            Hide();
        }

        private void addPerson_btn_Click(object sender, EventArgs e)
        {
            dataBase.openconnection();

            var surname_person = textBox1.Text;
            var name = textBox2.Text;
            var middle_name = textBox4.Text;
            var date_of_birth = textBox3.Text;
            var passport = textBox5.Text;
            var place_of_residence = textBox6.Text;
            var email = textBox7.Text;
            var phone = textBox8.Text;
            var post = textBox9.Text;
            var place_of_work = textBox10.Text;

            string querystring = $"insert into physical_person (surname,name_person,middle_name,date_of_birth,passport_sn,place_of_residence,email,phone_number,post_person,place_of_work) values ('{surname_person}', '{name}', '{middle_name}', '{date_of_birth}', '{passport}', '{place_of_residence}', '{email}', '{phone}', '{post}', '{place_of_work}')";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(querystring, dataBase.GetConnection());
            npgsqlCommand.ExecuteNonQuery();

            MessageBox.Show("данные успешно добавлены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataBase.closedConnection();

            FormPerson person = new FormPerson(_user);
            person.Show();
            Hide();
        }
    }
}
