using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    internal static class Operations
    {
        private static string connectionString = "Server=localhost;Database=radio_db;User=root;Password=";
        private static MySqlConnection connection = new MySqlConnection(connectionString);

        public static List<Radyo> getRadyoURL()
        {
            List<Radyo> list = new List<Radyo>();
            try
            {
                string query = "select * FROM radyolar";
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Radyo radyo = new Radyo();
                    radyo.Id = reader.GetInt32("id");
                    radyo.RadyoAdi = reader.GetString("radyo_adi");
                    radyo.RadyoUrl = reader.GetString("radyo_url");
                    list.Add(radyo);
                }
                connection.Close();
            }
            catch (Exception)
            {

            }
            

            return list;
        }




        public static string kayarYazi = "Yollar bitmez, yürekte hasret dinmez. Giden gitmiştir, kalan sağolsun. Sevda yürekte biter, lafta değil. Gözyaşım denize karışsa, deniz taşar. Hayat be kardeşim, nereye baksam senden bir iz var. Gittiğin yolları unutmadım, unuttum deseler de inanma. Her şeyi affettim, kendimi hariç. Yalnızlık yol arkadaşımdır, hatıralar hep yoldaş. Gönül kıran, yolu bulamaz. Kalpten giden, geri dönemez. Aşk biter, yollar kalır, bir de hatıralar. Unutuldum deme, unutulmadın ki, sadece adı anılmayan bir hatırasın artık. Gönül yoluna pusula gerekmez, seni seven orada bekler. Bir sigara daha yakarım, içimdeki yangına su olur belki. Sen yoksun diye dünya dönmeyi bırakmaz ama benim dünyam durdu bir kere. Acılar sahipsiz kalır, yürek hep yetim. Yolda kalan değil, yolda unutan kaybeder aslında. Bir şarkı çalar, anılar canlanır, ama sen yoksun işte. Hüzünlü bakışlar, yarım kalmış cümleler, hepsi senin eserin. Hayat akıp gidiyor, ama ben hala aynı yerdeyim, senin bıraktığın yerde. Beklemekten yoruldum, belki de beklemekten vazgeçtim, ama unutmaktan asla. Herkes kendi yolunda gider, biz ise bir yerde kaldık, ne ileri ne geri. Üzgünüm, bu yolun sonu yok, ama yine de yürüyorum, belki bir gün sen çıkarsın karşıma. Gönül bu, ne tarafa yönelse orada kalır, ama senin yolun bambaşka. Belki de bu yollar, yalnızlığa çıkıyor; belki de seninle dolu anılara. Hayat böyle be, kimse kimseyi beklemez, ama gönül bekler, unutma.";

    }


}
