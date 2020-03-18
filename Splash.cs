using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpSysPos
{
    public partial class Splash : Form
    {
        
        int cont = 0;
        public Splash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cont < 100)
            {
                cont++;
                progreso.Value = cont;
            }
            else
            {
                Console.Write("Cargado");
                timer1.Enabled = false;
                Login p = new Login();
                p.Show();
                this.Hide();
            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

    }
}
