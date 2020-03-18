using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpSysPos
{
    public partial class Login : Form
    {
        Principal menu =new Principal();
        ConexionBD con = new ConexionBD();
        CurrentUser Cuser=new CurrentUser();
        public Login()
        {
            InitializeComponent();
         
        }
        private void Login_Load(object sender, EventArgs e)
        { 
        }

        private void Close_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 1;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user, pass;
            
            user = usertxt.Text;
            pass = passtxt.Text;
            
            try
            {

                con.open();
                string query = "Select * from users where user='"+user+"' and pass='"+pass+"'";
                OleDbCommand comando = new OleDbCommand(query, con.cn);
                OleDbDataReader lector = comando.ExecuteReader();   
                if (lector.Read())
                {
                    Cuser.Id = Convert.ToInt32(lector.GetValue(0));
                    Cuser.Name = lector.GetValue(1).ToString();
                    Cuser.Crear_u = lector.GetBoolean(4);
                    Cuser.Crear_p = lector.GetBoolean(5);
                    Cuser.edit_p = lector.GetBoolean(6);
                    Cuser.entrada_p = lector.GetBoolean(7);
                    Cuser.salida_p = lector.GetBoolean(8);
                    Cuser.Crear_r = lector.GetBoolean(9);
                    Cuser.R_s = lector.GetBoolean(10);
                    Cuser.R_E = lector.GetBoolean(11);
                    menu.cuser = Cuser;
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Revisa los Datos", "Error",0);
                }
                con.close();
                user = "";
                pass = "";
            }
            catch (Exception ex) { ex.GetType(); }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
