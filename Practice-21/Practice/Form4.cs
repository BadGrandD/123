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
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace Practice
{
    public partial class Form4 : Form
    {
        MySqlConnection conn = DbHelper.GetConn();
        int idUser;
        string secFull;
        string theme;
        string groupName;
        DateTime date;


        public Form4(int _idUser)
        {
            InitializeComponent();
            idUser = _idUser;
            getStudentInfoFromBase();
            printStudentInfo();
        }

        private void getStudentInfoFromBase()
        {
            try
            {
                string select = "SELECT * FROM `users` WHERE user_id = @id";
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(select, conn); ;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idUser;
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                secFull = reader.GetString("firstName") + " " + reader.GetString("middleName") + " " + reader.GetString("lastName");
                groupName = reader.GetString("groupName");
                date = reader.GetDateTime("dateValue");
                if (date < dateTimePicker1.MinDate) date = dateTimePicker1.MinDate;
                if (date > dateTimePicker1.MaxDate) date = dateTimePicker1.MaxDate;
                theme = reader.GetString("Theme");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void getStudentInfoFromUser()
        {
            this.groupName = txtGroup.Text;
            this.date = DateTime.Now;
            this.theme = txtTheme1.Text;
        }

        private void printStudentInfo()
        {
            txtFio.Text = secFull;
            txtGroup.Text = groupName;
            dateTimePicker1.Text = date.ToString("D");
            txtTheme1.Text = theme;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveIntoBase()
        {
            this.getStudentInfoFromUser();
            try
            {
                conn.Open();
                const string update = "UPDATE `users` SET `groupName` = @gn, dateValue = @dv, Theme = @th WHERE `user_id` = @id";
                MySqlCommand cmd = new MySqlCommand(update, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idUser;
                cmd.Parameters.Add("@dv", MySqlDbType.Date).Value = date;
                cmd.Parameters.Add("@th", MySqlDbType.VarChar).Value = theme;
                cmd.Parameters.Add("@gn", MySqlDbType.VarChar).Value = groupName;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Сохранено в базу успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSaveIntoBase_Click(object sender, EventArgs e)
        {
            this.saveIntoBase();
        }

        private void btnSaveIntoWord_Click(object sender, EventArgs e)
        {
            this.getStudentInfoFromUser();
            Dictionary<string, string> items = new Dictionary<string, string>
            {
                { "<FIO>", secFull },
                { "<GR>", groupName },
                { "<DT>", date.ToString("D") },
                { "<TH>", theme },
            };

            string docxTemplatePath = Application.StartupPath + @"\docxTemplates\";
            string docxTemplateName = "template.docx";
            string docxBuildPath = Application.StartupPath + @"\docxBuild\";
            string docxBuildExtension = ".docx";
            Word.Application app = new Word.Application();
            if (!Directory.Exists(docxTemplatePath))
            {
                MessageBox.Show("Ошибка! Отсутствует папка с шаблонами!");
                return;
            }
            else if (!File.Exists(docxTemplatePath + docxTemplateName))
            {
                MessageBox.Show("Ошибка! Отсутствует файл-шаблон!");
                return;
            }

            try
            {
                app.Documents.Open(docxTemplatePath + docxTemplateName);
                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;
                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: Type.Missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: Word.WdFindWrap.wdFindContinue,
                        Format: false,
                        ReplaceWith: Type.Missing,
                        Replace: Word.WdReplace.wdReplaceAll
                        );

                }
                if (!Directory.Exists(docxBuildPath)) Directory.CreateDirectory(docxBuildPath);
                string outFileNameFull = docxBuildPath + secFull + " - заявление на тему ВКР" + docxBuildExtension;
                app.ActiveDocument.SaveAs2(outFileNameFull);
                MessageBox.Show("Документ сохранен успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                app.ActiveDocument.Close();
                app.Quit();
            }

        }
    }
}
