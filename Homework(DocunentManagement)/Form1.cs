using Npgsql;
using System.Data;




namespace Homework_DocunentManagement_
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        public Form1()
        {
            InitializeComponent();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openconnection();

            var login = login_TB.Text;
            var password = password_TB.Text;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();

            var query = $"select id_user, login_roles, password_roles, id_role from roles_tbl where login_roles = '{login}' and password_roles = '{password}'";


            NpgsqlCommand comm = new NpgsqlCommand(query, dataBase.GetConnection());

            adapter.SelectCommand = comm;
            adapter.Fill(table);


            if (table.Rows.Count == 1)
            {
                var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));

                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Guide guide = new Guide(user);
                this.Hide();
                guide.ShowDialog();

            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            dataBase.closedConnection();
        }


        private void passAgainBut_Click_1(object sender, EventArgs e)
        {
            PasswordReset passwordReset = new PasswordReset();
            passwordReset.Show();
            Hide();
        }
    }
}
