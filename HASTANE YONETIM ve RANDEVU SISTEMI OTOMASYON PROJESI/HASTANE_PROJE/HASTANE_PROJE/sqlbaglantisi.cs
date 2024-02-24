using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HASTANE_PROJE
{
    internal class sqlbaglantisi 
    {
        public SqlConnection baglanti() 
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0AM9SUH\\SQLEXPRESS;Initial Catalog=HASTANEPROJE;Integrated Security=True"); // bağlantı adresi           
            baglan.Open();
            return baglan;
        }
    }
}
