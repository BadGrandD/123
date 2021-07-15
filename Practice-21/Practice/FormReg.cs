using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Practice
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /* 
             * чтобы было правильно
             * нужно сначала проверить отсутствие такого логина и пароля
             * SELECT
             */
            var conn = DbHelper.GetConn();

            string query = "INSERT INTO `users` " +
                "(`user_id`, `lastName`,`firstName`,`middleName`, `groupName`, `Theme`, `dateValue`, `login`,`password`) " +
                "VALUES(@id, @ln, @fn, @mn, @gn, @th, @dv, @log, @pas)";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                Random rnd = new Random();
                int id = rnd.Next();
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@ln", MySqlDbType.VarChar).Value = txtName1.Text;
                cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = txtName2.Text;
                cmd.Parameters.Add("@mn", MySqlDbType.VarChar).Value = txtName3.Text;
                cmd.Parameters.Add("@gn", MySqlDbType.VarChar).Value = txtGroupName.Text;
                cmd.Parameters.Add("@th", MySqlDbType.VarChar).Value = "";
                cmd.Parameters.Add("@dv", MySqlDbType.Date).Value = DateTime.MinValue;
                cmd.Parameters.Add("@log", MySqlDbType.VarChar).Value = txtLogin.Text;
                cmd.Parameters.Add("@pas", MySqlDbType.VarChar).Value = GenHash.CalculateMD5Hash(txtPassword.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Пользователь зарегистрирован");

                this.Hide();
                Form4 formFill = new Form4(id);
                formFill.Show();
                formFill.FormClosed += this.FormReg_FormClosed;

            }
            catch (Exception ex)
            {   
                MessageBox.Show("Нет соединения с БД\n\r" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void FormReg_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FormReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void FormReg_Load(object sender, EventArgs e)
        {

        }
    }
}
