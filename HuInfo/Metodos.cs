﻿using System.Data;
using System.Data.SqlClient;

namespace HuInfo
{
    class Metodos
    {
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private string cmesDatabase = "";
        private string inforDatabase = "";

        public DataTable CmesHU(string hu)
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

        public DataTable InforHU(string hu, string compañia)
        {
            DataTable dtResultado = new DataTable();
            Connection.ConnectionString = inforDatabase;
            Connection.Open();
            SqlDataAdapter ResultadoQuery = new SqlDataAdapter("SELECT t_huid, t_clot,t_item,t_qhds FROM twhwmd530"+ compañia +" WHERE t_huid = '" + hu + "'", Connection);
            ResultadoQuery.Fill(dtResultado);
            return dtResultado;
        }
    }
}
