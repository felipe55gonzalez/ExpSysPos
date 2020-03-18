using System;
using System.Data.OleDb;
using System.IO;

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
    public class CurrentUser
    {
        public String Name { get; set; }
        public int Id { get; set; }
        public Boolean Crear_u { get; set; }
        public Boolean Crear_p { get; set; }
        public Boolean edit_p { get; set; }
        public Boolean entrada_p { get; set; }
        public Boolean salida_p { get; set; }
        public Boolean Crear_r { get; set; }
        public Boolean R_s { get; set; }
        public Boolean R_E { get; set; }
        //public CurrentUser(String _Name,int _Id, Boolean _Crear_u, Boolean _Crear_p, Boolean _edit_p, Boolean _entrada_p, Boolean _salida_p, Boolean _Crear_r, Boolean _R_s, Boolean _R_E)
        //{
        //    Name = _Name;
        //    Id = _Id;
        //    Crear_u = _Crear_u;
        //    Crear_p = _Crear_p;
        //    edit_p = _edit_p;
        //    entrada_p = _entrada_p;
        //    salida_p = _salida_p;
        //    Crear_r = Crear_r;
        //    R_s = _R_s;
        //    R_E = _R_E;

        //}
    }
}
