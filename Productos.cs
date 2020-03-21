using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpSysPos
{
    public partial class Productos : Form
    {
        ConexionBD con = new ConexionBD();
        public Productos()
        {
            InitializeComponent();
            LLenarT();
            Combos();
        }
        public void LLenarT()
        {
            string strSql = "SELECT Productos.Codigo as Codigo, Productos.Nombre as Nombre, Proveedores.Nombre as Proveedor, Departamentos.Nombre as Departamento, Productos.VentaXPeso, Productos.Precio_Proveedor, Productos.Precio_Venta, Productos.Existencia FROM Departamentos INNER JOIN(Proveedores INNER JOIN Productos ON Proveedores.ID_Proveedor = Productos.ID_Proveedor) ON Departamentos.Id = Productos.ID_Departamento;";
            con.open();
            OleDbCommand cmd = new OleDbCommand(strSql, con.cn);
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);
            dataGridView1.DataSource = scores;
            con.close();

        }
        public void Combos()
        {
            con.open();
            string strSql = "Select nombre from proveedores";
            OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, con.cn));
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            ComboProveedor.DataSource = ds.Tables[0];
            ComboProveedor.DisplayMember = "nombre";
            ComboProveedor.ValueMember = "nombre";

            strSql = "Select nombre from Departamentos";
            adapter = new OleDbDataAdapter(new OleDbCommand(strSql, con.cn));
            ds = new DataSet();
            adapter.Fill(ds);
            ComboDepartamento.DataSource = ds.Tables[0];
            ComboDepartamento.DisplayMember = "nombre";
            ComboDepartamento.ValueMember = "nombre";


            con.close();
        }
    }
}
