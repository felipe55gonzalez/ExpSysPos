using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpSysPos
{
    public partial class Principal : Form
    {
        public CurrentUser cuser;
        SerialPort mySerialPort = new SerialPort("COM8");
        string indata="00.00";
        
        public Principal()
        {
            
            InitializeComponent();
            hideSubMenu();
            


            //mySerialPort.BaudRate = 9600;
            //mySerialPort.Parity = Parity.None;
            //mySerialPort.StopBits = StopBits.One;
            //mySerialPort.DataBits = 8;
            //mySerialPort.Handshake = Handshake.None;

            //mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            //mySerialPort.Open();

        }
        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            indata = sp.ReadExisting();
            Console.WriteLine(indata);

        }
        public void peso() {
            
        }
        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
            CodBox.Focus();
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
           // openChildForm(new Form2());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
            CodBox.Focus();
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
            CodBox.Focus();
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
          //  openChildForm(new Form3());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
            CodBox.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            table.Controls.Add(childForm);
            table.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //mySerialPort.WriteLine("$");
            //mySerialPort.WriteLine("/r");
            //BasBox.Text = indata;
        }

        private void Principal_VisibleChanged(object sender, EventArgs e)
        {
            LabelName.Text = cuser.Name;
            CodBox.Focus();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Revisarp();
            CodBox.Focus();
        }
        public void Revisarp()
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            CodBox.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CodBox.Text="";
            CodBox.Focus();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CodBox.Focus();
        }

        private void BasBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BasBox_Click(object sender, EventArgs e)
        {
            CodBox.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            CodBox.Focus();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            CodBox.Focus();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CodBox.Focus();
        }

        private void TotalBox_Click(object sender, EventArgs e)
        {
            CodBox.Focus();
        }

        private void CodBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CodBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine(CodBox.Text);
                CodBox.Text = "";
            }
        }
    }
}
