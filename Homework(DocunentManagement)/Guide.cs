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
    public partial class Guide : Form
    {
        DataBase dataBase = new DataBase();
        private readonly checkUser _user;
        public Guide(checkUser user)
        {
            _user = user;
            InitializeComponent();
        }

        private void IsAdmin()
        {
            addBut.Enabled = _user.IsAdmin;
        }

        private void Guide_Load(object sender, EventArgs e)
        {
            IsAdmin();
            loginLabel.Text = $"{_user.Login}:{_user.Status}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPerson formPerson = new FormPerson(_user);
            formPerson.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEducation formEducation = new FormEducation(_user);
            formEducation.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
