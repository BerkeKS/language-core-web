using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;
using System.ComponentModel;

namespace LanguageCoreDB
{
    public abstract class OracleConnectionManager
    {
        private OracleConnection oracleConnection = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public void connect()
        {
            oracleConnection.Open();
        }

        public void disconnect()
        {
            oracleConnection.Close();
        }
    }
}
