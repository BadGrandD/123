using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Practice
{
    public partial class FormAutho : Form
    {
        public FormAutho()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAutho_Click(object sender, EventArgs e)
        {
            var conn = DbHelper.GetConn();
            string query = "SELECT user_id FROM `users` WHERE login = @lg AND password = @pas";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.Add("@lg", MySqlDbType.VarChar).Value = txtLogin.Text;
                cmd.Parameters.Add("@pas", MySqlDbType.VarChar).Value = GenHash.CalculateMD5Hash(txtPassword.Text);

                cmd.ExecuteNonQuery();
                int id = -1;
                id = Convert.ToInt32(cmd.ExecuteScalar());
                if (id == -1)
                {
                    MessageBox.Show("Неверны введенные данные");
                    this.Close();
                    return;
                }

                this.Hide();
                Form4 formFill = new Form4(id);
                formFill.Show();
                formFill.FormClosed += this.FormAutho_FormClosed;

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

        private void FormAutho_Load(object sender, EventArgs e)   
        {

       
        }

        private void FormAutho_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
