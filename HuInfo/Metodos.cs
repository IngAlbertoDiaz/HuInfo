using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HuInfo
{
    class Metodos
    {
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private string cmesDatabase = "Server=192.168.82.14\\COFICABMINPRO;Database=CMES;Integrated Security=False;User ID=SA;Password=DBACoficab";

        public DataTable GetHU(string hu)
        {
            DataTable dtResultado = new DataTable();
            Connection.ConnectionString = cmesDatabase;
            Connection.Open();
            SqlDataAdapter ResultadoQuery = new SqlDataAdapter(
                @"SELECT rne.handling_unit, rne.Reel_Number, cpe.CodeArt, rne.Length_Total 
                  FROM CMES.dbo.Reel_Number_Ext AS rne JOIN CMES.dbo.Controle_Production_Ext AS cpe ON rne.Reel_Number = cpe.Reel_Number
                  WHERE rne.handling_unit = '"+ hu +"'", Connection);
            ResultadoQuery.Fill(dtResultado);
            return dtResultado;
        }
    }
}