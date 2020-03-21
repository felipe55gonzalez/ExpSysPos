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
    public partial class Proveedores : Form
    {
        ConexionBD con = new ConexionBD();
        String id;
        public Proveedores()
        {
            InitializeComponent();
            LLenarT();
            
        }
        public void LLenarT()
        {
            string strSql = "Select ID_Proveedor,RFC,Nombre,Telefono,Dirreccion,Correo From Proveedores";
            con.open();
            OleDbCommand cmd = new OleDbCommand(strSql, con.cn);
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);
            dataGridView1.DataSource = scores;
            con.close();

        }

        private void Namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            rfcbox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            Namebox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            telbox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            dirbox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
            telbox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            correobox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Nubtn.Text == "Nuevo")
            {
                rfcbox.Enabled = true;
                Namebox.Enabled = true;
                telbox.Enabled = true;
                dirbox.Enabled = true;
                correobox.Enabled = true;
                editbtn.Enabled = false;

                Nubtn.Text = "Guardar";
                rfcbox.Text = "";
                Namebox.Text = "";
                telbox.Text = "";
                dirbox.Text = "";
                correobox.Text = "";
            }
            else
            {
                rfcbox.Enabled = false;
                Namebox.Enabled = false;
                telbox.Enabled = false;
                dirbox.Enabled = false;
                correobox.Enabled = false;
                editbtn.Enabled = true;
                _save();
                Nubtn.Text = "Nuevo";
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (editbtn.Text == "Editar")
            {
                rfcbox.Enabled = true;
                Namebox.Enabled = true;
                telbox.Enabled = true;
                dirbox.Enabled = true;
                correobox.Enabled = true;
                Nubtn.Enabled = false;
                editbtn.Text = "Guardar";
            }
            else
            {
                rfcbox.Enabled = false;
                Namebox.Enabled = false;
                telbox.Enabled = false;
                dirbox.Enabled = false;
                correobox.Enabled = false;
                Nubtn.Enabled = true;
                _Update();
                editbtn.Text = "Editar";
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            id = telbox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            rfcbox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            Namebox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            telbox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            dirbox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
            telbox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
            correobox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
        }
        public void _Update()
        {
            //update
            con.open();
            Console.WriteLine("Update proveedores set rfc = '" + rfcbox.Text + "', nombre = '" + Namebox.Text + "', Telefono = '" + telbox.Text + "', Dirreccion = '" + dirbox.Text + "', correo = '"+correobox.Text+"' where id_proveedor = " + id);
            OleDbCommand CmdSql = new OleDbCommand("Update proveedores set rfc='" + rfcbox.Text + "',nombre='" + Namebox.Text + "',Telefono='" + telbox.Text + "',Dirreccion='" + dirbox.Text + "',correo='"+correobox.Text+"' where id_proveedor=" + id, con.cn);
            CmdSql.ExecuteNonQuery();
            con.close();
            MessageBox.Show("Proveedor Editado", "Correcto", 0);
            LLenarT();
        }
        public void _save()
        {
            con.open();
            OleDbCommand CmdSql = new OleDbCommand("insert into proveedores (rfc,Nombre,telefono,Dirreccion,correo)values ('" + rfcbox.Text+ "','" + Namebox.Text + "','" + telbox.Text + "','" + dirbox.Text + "','"+correobox.Text+"')", con.cn);
            CmdSql.ExecuteNonQuery();
            con.close();
            LLenarT();
            MessageBox.Show("proveedor Agregado", "Correcto", 0);
        }
    }
}
