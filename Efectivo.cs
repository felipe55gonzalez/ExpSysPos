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
    public partial class Efectivo : Form
    {
     
        public decimal Total, Dinero, Cambio;
        public Principal p;
        public Efectivo()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Efectivobox.Focus();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarEfectivo("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertarEfectivo("2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertarEfectivo("3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InsertarEfectivo("4");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InsertarEfectivo("5");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InsertarEfectivo("6");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InsertarEfectivo("7");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InsertarEfectivo("8");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InsertarEfectivo("9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            InsertarEfectivo(".");
        }

        private void Efectivo_VisibleChanged(object sender, EventArgs e)
        {
            Efectivobox.Text = "";
            CambioBox.Text = "";
            Dinero = 0;
            Cambio = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Efectivobox.Focus();
            Efectivobox.Text = "";
            CambioBox.Text = "";
            Dinero = 0;
            Cambio = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Efectivobox.Focus();
            if (Dinero == 0)
                { Dinero = Total; }
            p.Dinero = Dinero;
            p.Cambio = Cambio;
            p.r_cobro();

            
    }

        private void Efectivo_Leave(object sender, EventArgs e)
        {
             
        }

        private void Efectivo_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            InsertarEfectivo("0");
        }

        private void Efectivobox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
             (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) ||
                    e.KeyCode == Keys.Decimal)
            {
                // Edit mode
            }
            else if (e.KeyCode == Keys.Back) { }
            else if (e.KeyCode == Keys.Escape) { button12.PerformClick(); }
            else if (e.KeyCode == Keys.Delete) { button14.PerformClick(); }
            else if (e.KeyCode == Keys.F12) { button13.PerformClick(); }
            else if (e.KeyCode == Keys.Enter) { button13.PerformClick(); }
            else { e.SuppressKeyPress = true; }

        }

        private void Efectivobox_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void Efectivobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Efectivobox_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void Efectivo_Load(object sender, EventArgs e)
        {

        }

        public void InsertarEfectivo(String Dato){
            Efectivobox.Focus();
            Efectivobox.Select(0, 0);
            Efectivobox.Text = Efectivobox.Text + Dato;
            CalcularCambio();
            }
        public void CalcularCambio()
        {
            try { 
            Dinero = decimal.Parse(Efectivobox.Text);
            Cambio = Dinero - Total;
            if (Cambio > 0)
            {
                CambioBox.Text = Cambio.ToString();
            }
            }
            catch
            {
                if (Efectivobox.Text != "")
                {

                }
            }
        }
    }
}
