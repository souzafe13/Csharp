﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MariaVaiComAsOutras
{
    class Conexao
    {
        private static string conn = "Server=localhost;Port=3306;Database=dbViagens;Uid=vendedor;Pwd=123456";



        private static MySqlConnection con = null;



        public static MySqlConnection obterConexao()
        {
            con = new MySqlConnection(conn);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                con = null;
            }
            return con;
        }
        public static void fecharConexao()
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
}
