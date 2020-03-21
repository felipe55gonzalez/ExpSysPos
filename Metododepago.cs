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
    public partial class Metododepago : Form
    {
        public Principal p;
        public Metododepago()
        {
            InitializeComponent();
            this.LostFocus += new EventHandler(Form_LostFocus);
            this.Focus();
            
        }
        void Form_LostFocus(object sender, EventArgs e)
        {
            if (ActiveForm != this)
            { 
            this.Close();
            }
        }
        private void Metododepago_FormClosing(object sender, FormClosingEventArgs e)
        {
       
        }

        private void Metododepago_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void Metododepago_Leave(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Metododepago_Load(object sender, EventArgs e)
        {

        }

        private void Metododepago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                cobrarbtn.PerformClick();
            }
            if (e.KeyCode == Keys.F1)
            {
                tarjetabtn.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void tarjetabtn_Click(object sender, EventArgs e)
        {

        }

        private void cobrarbtn_Click(object sender, EventArgs e)
        {
            p.cobar_efectivo();
            this.Close();
        }
    }
}
