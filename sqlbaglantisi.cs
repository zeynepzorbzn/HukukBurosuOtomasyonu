using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HukukBurosuOtomasyon
{
    public class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-HELPE1K\\SQLEXPRESS;Initial Catalog=HukukBurosuOtomasyon;Integrated Security=True;");
            baglan.Open();
            return baglan;

        }
    }
}
