using System.Configuration;
using System.Data.SqlClient;
namespace Gestion_de_salle_de_sport
{


    class db
    {
        public static SqlConnection cn;
        public static SqlCommand cm = new SqlCommand();
        public static SqlCommand com;

        public static void Ouvreconnexion()
        {
            string cs = ConfigurationManager.ConnectionStrings["Gestion_de_salle_de_sport"].ConnectionString.ToString();
            // cn = new SqlConnection(cryptage.DecryptSym(System.Convert.FromBase64String(cs), cryptage.cle, cryptage.iv));
            cn = new SqlConnection(cs);
            cn.Open();


        }
        public static void close(SqlDataReader dr)
        {
            dr.Close();
            dr = null;
            com = null;
            cn.Close();

        }
        public static void Excute(string req)
        {
            Ouvreconnexion();
            com = new SqlCommand(req, cn);
            com.ExecuteNonQuery();

        }
        public static string ExcuteScalare(string req)
        {
            Ouvreconnexion();
            com = new SqlCommand(req, cn);
            string c = com.ExecuteScalar().ToString();
            return c;

        }
        public static SqlDataReader remplir(string req)
        {
            Ouvreconnexion();
            com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
    }
}
