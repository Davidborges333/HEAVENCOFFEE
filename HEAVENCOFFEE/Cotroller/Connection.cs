using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HEAVENCOFFEE.Cotroller
{
    internal class Connection
    {
        private SqlConnection con;
        private string DataBase = "HEAVENCOFFEE";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string password = "aluno";

        public Connection()
        {
            string stringConnection =
                @"Data Source = " + Server
                + "; INITAL Catalog = " + DataBase
                + "; User Id =" + password
                + "; password = " + password
                + "; Encrypt = false";
            con = new SqlConnection(stringConnection);
            con.Open();
        }
        public void CloseConnetion()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
           
        } 

        private void ReturnConnection()
        {
            throw new NotImplementedException();
        }
    }
    }

