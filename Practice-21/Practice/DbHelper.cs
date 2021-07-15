using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Practice
{
    class DbHelper
    {
        public static MySqlConnection GetConn()
        {
            MySqlConnectionStringBuilder db = new MySqlConnectionStringBuilder();

            db.Server = "pgsha.ru"; // хостинг БД
            db.Database = "soft0092_practice"; // Имя БД
            db.UserID = "soft0092"; // Имя пользователя БД
            db.Password = "xtrEC4Gl"; // Пароль пользователя БД
            db.Port = 35006;
            db.CharacterSet = "utf8"; // Кодировка Базы Данных

            MySqlConnection conn = new MySqlConnection(db.ConnectionString);

            return conn;
        }
    }
}
