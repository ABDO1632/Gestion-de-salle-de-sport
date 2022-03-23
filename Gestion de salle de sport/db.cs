using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
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
            cn = new SqlConnection(cryptage.DecryptSym(System.Convert.FromBase64String(cs), cryptage.cle, cryptage.iv));

            cn.Open();


        }
        public static void close(SqlDataReader dr)
        {
            dr.Close();
            dr = null;
            com = null;
            cn.Close();

        }
        public static SqlDataReader remplir(string req)
        {
            Ouvreconnexion();
            //com.Connection = cn;
            //com.CommandText= req;
            com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();

            return dr;



            //dr.Close();
            //dr = null;
            //com = null;
            //cn.Close();
            //cn = null;
        }
    }
}
