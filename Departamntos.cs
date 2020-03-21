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
    public partial class Departamntos : Form
    {
        ConexionBD con = new ConexionBD();
        String id;
        public Departamntos()
        {
            InitializeComponent();
            LLenarT();
        }

        private void Departamntos_Load(object sender, EventArgs e)
        {

        }
        public void LLenarT()
        {
            string strSql = "Select ID,Nombre From Departamentos";
            con.open();
            OleDbCommand cmd = new OleDbCommand(strSql, con.cn);
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);
            dataGridView1.DataSource = scores;
            con.close();

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (editbtn.Text == "Editar")
            {
                Namebox.Enabled = true;
                Nubtn.Enabled = false;
                editbtn.Text = "Guardar";
            }
            else
            {
                Namebox.Enabled = false;             
                Nubtn.Enabled = true;
                _Update();
                editbtn.Text = "Editar";
            }
        }

        private void Nubtn_Click(object sender, EventArgs e)
        {
            if (Nubtn.Text == "Nuevo")
            {
                Namebox.Enabled = true;                
                editbtn.Enabled = false;
                Nubtn.Text = "Guardar";               
                Namebox.Text = "";
               
            }
            else
            {
                Namebox.Enabled = false;           
                editbtn.Enabled = true;
                _save();
                Nubtn.Text = "Nuevo";
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            id = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            Namebox.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
        }
        public void _Update()
        {
            //update
            con.open();
            OleDbCommand CmdSql = new OleDbCommand("Update Departamentos set Nombre='" + Namebox.Text + "' where id=" + id, con.cn);
            CmdSql.ExecuteNonQuery();
            con.close();
            MessageBox.Show("Departamento Editado", "Correcto", 0);
            LLenarT();
        }
        public void _save()
        {
            con.open();
            OleDbCommand CmdSql = new OleDbCommand("insert into Departamentos (nombre)values ('"+Namebox.Text+"')", con.cn);
            CmdSql.ExecuteNonQuery();
            con.close();
            LLenarT();
            MessageBox.Show("proveedor Agregado", "Correcto", 0);
        }
    }
}
