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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Homework_DocunentManagement_
{

    public partial class RegisterForm : Form
    {

        DataBase dataBase = new DataBase();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var login = login_TB.Text;
            var password = password_TB.Text;

            string querystring = $"insert into roles_tbl (login_roles, password_roles, id_role) values ('{login}','{password}', 3)";

            NpgsqlCommand command = new NpgsqlCommand(querystring, dataBase.GetConnection());

            dataBase.openconnection();



            if (checkuser())
                return;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Аккаунт создать не удалось!");
            }
            dataBase.closedConnection();
        }

        private Boolean checkuser()
        {
            var login = login_TB.Text;
            var password = password_TB.Text;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, id_role, login_roles, password_roles from roles_tbl where login_roles = '{login}' and password_roles = '{password}'";

            NpgsqlCommand command = new NpgsqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }


        bool IsNumber(TextBox text)
        {
            foreach (var item in text.Text.Reverse())
                if (char.IsNumber(item)) { return true; }
            return false;
        }

        bool IsSymbol(TextBox text)
        {
            foreach (var item in text.Text.Reverse())
                if (char.IsSymbol(item)) { return true; }
            return false;
        }


        private void password_TB_TextChanged(object sender, EventArgs e)
        {
            if (IsSymbol(password_TB))
            {
                label4.ForeColor = Color.FromArgb(0, 189, 83);
            }
            else
            {
                label4.ForeColor = Color.FromArgb(182, 53, 40);
            }

            if (IsNumber(password_TB))
            {
                label4.ForeColor = Color.FromArgb(0, 189, 83);
            }
            else
            {
                label4.ForeColor = Color.FromArgb(182, 53, 40);
            }
        }
    }

}
