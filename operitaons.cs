using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    internal static class operitaons
    {
        private static string connectionString = "Server=localhost;Database=radyo_db;User=root;Password=";
        private static MySqlConnection connection = new MySqlConnection(connectionString);

        public static List<Radyo> getRadyoURL()
        {
            List<Radyo> list = new List<Radyo>();
            string query = "select * FROM  radyolar";
            connection.Open();
            MySqlCommand command =  new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            connection.Close();
            while (reader.Read())
            {
                Radyo radyo = new Radyo();
                radyo.Id = reader.GetInt32("id");
                radyo.RadyoAdi = reader.GetString("radyo_adi");
                radyo.RadyoUrl = reader.GetString("radyo_url");
                list.Add(radyo);
            }
            return list;
        }






    }


}
