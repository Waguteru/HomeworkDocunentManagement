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
    public partial class PasswordReset : Form
    {
        DataBase dataBase = new DataBase();
        public PasswordReset()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dropPass();
            MessageBox.Show("Пароль изменен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void dropPass()
        {
            var login = login_TB.Text;
            var password = password_TB.Text;

            dataBase.openconnection();

            var changeQuery = $"update roles_tbl set password_roles = '{password}' where login_roles = '{login}'";

            var command = new NpgsqlCommand(changeQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();

            dataBase.closedConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
