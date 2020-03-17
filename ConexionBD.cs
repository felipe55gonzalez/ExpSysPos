using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpSysPos
{
    class ConexionBD
    {
        public string conec = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "//MainDb.accdb;";
        public OleDbConnection cn = new OleDbConnection();

        public void open()
        {
            cn.ConnectionString = conec;
            cn.Open();
        }
        public void close()
        {
            cn.Close();
        }

    }
}
