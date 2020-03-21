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
using Microsoft.VisualBasic;
using System.Data.OleDb;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;

namespace ExpSysPos
{
    public partial class Principal : Form
    {
        public CurrentUser cuser;
        SerialPort mySerialPort = new SerialPort("COM7");
        string indata = "00.00";
        int cant = 1;
        decimal peso;
        ConexionBD con = new ConexionBD();
        public Decimal Total,Dinero,Cambio;
        bool bascula = true;
        Efectivo Ef = new Efectivo();
        public string fecha, hora, folio;
        public string  descp, refT;
        int tamText;


        Microsoft.Office.Interop.Word.Application WordEfectivo;
        Microsoft.Office.Interop.Word.Document TicketEfectivo;

        Microsoft.Office.Interop.Word.Application Wordtarjeta;

        Microsoft.Office.Interop.Word.Document TicketTarjeta;

        object missing = Missing.Value;
        object readOnly = false;
        object isVisible = false;
        public Principal()
        {

            InitializeComponent();
            hideSubMenu();
            con.open();
            cargabalanza();
            

        }
        public void cargabalanza()
        {
            try
            {
                mySerialPort.BaudRate = 9600;
                mySerialPort.Parity = Parity.None;
                mySerialPort.StopBits = StopBits.One;
                mySerialPort.DataBits = 8;
                mySerialPort.Handshake = Handshake.None;
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                mySerialPort.Open();
                timer1.Enabled = true;
                bascula = true;
            }
            catch {
                String error;                
                error =MessageBox.Show("la bascula no esta conectada"+(char)13+"Deseas reconectarla?", "Error Bascula",MessageBoxButtons.RetryCancel, MessageBoxIcon.Error).ToString();
                if (error == "Retry") {
                    cargabalanza();
                } 
                timer1.Enabled = false;
                bascula = false;
            }
        }
        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            indata = sp.ReadExisting();
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
            Productos pro = new Productos();
            pro.Show();
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
            CodBox.Focus();
            Proveedores pv = new Proveedores();
            pv.Show();
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departamntos dp = new Departamntos();
            dp.Show();
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
            mySerialPort.WriteLine("P");
            mySerialPort.WriteLine("/r");
            BasBox.Text = indata;
        }

        private void Principal_VisibleChanged(object sender, EventArgs e)
        {
            //LabelName.Text = cuser.Name;
           // CodBox.Focus();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Revisarp();
            CodBox.Focus();
        }
        public void Revisarp()
        {

            try
            {


                string query = "Select * from productos where Codigo='" + CodBox.Text+"'";              
                OleDbCommand comando = new OleDbCommand(query, con.cn);
                OleDbDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    if (lector.GetBoolean(4)) {
                        Addinlistpeso(lector.GetString(2), lector.GetDecimal(5), lector.GetString(0), lector.GetDecimal(8));
                    }
                    else
                    {
                        Addinlist(lector.GetString(2), lector.GetDecimal(5), lector.GetString(0), lector.GetDecimal(8));
                    }
                }
                else
                {
                    MessageBox.Show("Revisa los Datos", "Error", 0);
                }

            }
            catch (Exception ex)
            {
                ex.GetType();
                con.close();
                con.open();
              
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                cant = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Insertar la cantidad", "Varios", "1"));

            }
            catch (Exception ex)
            {
                ex.GetType();
                cant = 1;

            }
            CantBox.Text = cant.ToString();
            CodBox.Focus();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            CodBox.Text = "";
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
            try {Lista.Rows.RemoveAt(Lista.SelectedRows[0].Index); GetTotal(); } catch{ }
            
            CodBox.Focus();
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Lista.Rows.Clear();
            CodBox.Focus();
            GetTotal();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CodBox.Focus();
            Metododepago met = new Metododepago();
            met.p = this;
            met.LabelTot.Text ="$" +Total.ToString();
            met.Show();
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
                if (CodBox.Text != "")
                {
                    Revisarp();
                    CodBox.Text = "";
                }
            }
            if (e.KeyCode == Keys.F1)
            {
                cobrarbtn.PerformClick(); 
            }
            if (e.KeyCode == Keys.F2)
            {
                button14.PerformClick();
            }
            if (e.KeyCode == Keys.Delete)
            {
                button11.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                buscarbtn.PerformClick();
            }
            if (e.KeyCode == Keys.F7)
            {
               eliminarbtn.PerformClick();
            }
            if (e.KeyCode == Keys.F8)
            {
                eliminarallbtn.PerformClick();
            }
            if (e.KeyCode == Keys.F12)
            {
                cobrarbtn.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                cargabalanza();
            }

        }

        private void Principal_KeyDown(object sender, KeyEventArgs e)
        {

        }
        public void Addinlist(String Name, Decimal Price,String id,decimal inv)
        {
           
            Boolean find = false;
            foreach (DataGridViewRow row in Lista.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(id))
                {
                    row.Cells[2].Value = Convert.ToInt32(row.Cells[2].Value) + cant;
                    row.Cells[4].Value = Convert.ToDecimal(row.Cells[3].Value) * Convert.ToInt32(row.Cells[2].Value);
                    find = true;
                    break;
                }
            }
            if (find == false)
            {
                this.Lista.Rows.Add(id, Name, cant, Price,cant*Price,inv);
            }
            cant = 1;
            CantBox.Text = cant.ToString() ;
            GetTotal();

        }
        public void Addinlistpeso(String Name, Decimal Price, String id, decimal inv)
        {
            if (bascula)
            {
               string numberOnly = Regex.Replace(BasBox.Text, "[^0-9.]", "");
                peso = Convert.ToDecimal(numberOnly);
                Console.WriteLine(peso);
            }
            else {
                try
                {
                    peso = Convert.ToDecimal(Microsoft.VisualBasic.Interaction.InputBox("Insertar el peso en Kilos", "Varios", "1"));
                }
                catch {
                    MessageBox.Show("se introdujo un peso Invalido", "Error Bascula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; }
            }
            Boolean find = false;
            foreach (DataGridViewRow row in Lista.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(id))
                {
                    row.Cells[2].Value = Convert.ToDecimal(row.Cells[2].Value) + peso;
                    row.Cells[4].Value = (Convert.ToDecimal(row.Cells[3].Value) * Convert.ToDecimal(row.Cells[2].Value)).ToString("###.##");
                    find = true;
                    break;
                }
            }
            if (find == false)
            {
                this.Lista.Rows.Add(id, Name, peso, Price, (peso * Price).ToString("######.##"), inv);
            }
            cant = 1;
            CantBox.Text = cant.ToString();
            GetTotal();

        }
        public void GetTotal()
        {
            Total = 0;
            foreach (DataGridViewRow row in Lista.Rows)
            {
                Total = Total + Convert.ToDecimal(row.Cells[4].Value);
            }
            TotalBox.Text = "$" + Total.ToString();
            if (Total != 0)
            {
                cobrarbtn.Enabled = true;
            }
            else
            {
                cobrarbtn.Enabled = false;
            }

        }

        private void Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodBox.Focus();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            ReopenWordEfectivo();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            if (Switch.Value == true)
            {
                k1.Visible = true;
                k2.Visible = true;
                k3.Visible = true;
                k4.Visible = true;
                k5.Visible = true;
                k6.Visible = true;
                k7.Visible = true;
                k8.Visible = true;
                Properties.Settings.Default.keys = true;
                Console.WriteLine(Properties.Settings.Default.keys);
             
            }
            else
            {
                k1.Visible = false;
                k2.Visible = false;
                k3.Visible = false;
                k4.Visible = false;
                k5.Visible = false;
                k6.Visible = false;
                k7.Visible = false;
                k8.Visible = false;
                Properties.Settings.Default.keys = false;
            }
            Properties.Settings.Default.Save();
            CodBox.Focus();
        }

        private void Switch_Load(object sender, EventArgs e)
        {
            Switch.Value = Properties.Settings.Default.keys;
            if (Properties.Settings.Default.keys == true)
            {
                k1.Visible = true;
                k2.Visible = true;
                k3.Visible = true;
                k4.Visible = true;
                k5.Visible = true;
                k6.Visible = true;
                k7.Visible = true;
                k8.Visible = true;
               

            }
            else
            {
                k1.Visible = false;
                k2.Visible = false;
                k3.Visible = false;
                k4.Visible = false;
                k5.Visible = false;
                k6.Visible = false;
                k7.Visible = false;
                k8.Visible = false;
                Switch.Value = false;
            }
            
        }
        public void cobar_efectivo()
        {
            Ef.p = this;
            Ef.Efectivobox.Focus();
            Ef.Total = Total;
            Ef.Totalbox.Text = Total.ToString();
            Ef.Show();
        }
        public void r_cobro()
        {
            
            int articulos = Lista.RowCount;
            try
            {
                fecha = DateTime.Today.ToString("dd/MMM/yyyy");
                String min = DateTime.Now.Minute.ToString();
                if (min.Length == 1)
                {
                    min = "0" + min;
                }
                hora = (DateTime.Now.Hour + ":" + min);
                OleDbCommand CmdSql = new OleDbCommand("insert into ventas (cant_p,user_ID,fecha,hora,total,efectivo) values ("+articulos+"," + cuser.Id + ",'" + fecha + "','" + hora + "'," + Total + "," + Dinero+")" , con.cn);
                CmdSql.ExecuteNonQuery();
                CmdSql = new OleDbCommand("Select @@Identity", con.cn);
                folio = Convert.ToInt32(CmdSql.ExecuteScalar()).ToString();
                CodBox.Focus();
                CreateWordDocument();
                Limpiar();
                ReopenWordEfectivo();
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                con.close();
                con.open();

            }
        }

        private void table_Resize(object sender, EventArgs e)
        {

        }

        private void Principal_Resize(object sender, EventArgs e)
        {

        }

        private void CodBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateWordDocument()
        {
            this.FindAndReplace(WordEfectivo, "<Folio>", folio);
            this.FindAndReplace(WordEfectivo, "<Date>", fecha);
            this.FindAndReplace(WordEfectivo, "<Hora>", hora);
            this.FindAndReplace(WordEfectivo, "<User>", cuser.Name);
            this.FindAndReplace(WordEfectivo, "<Tot>", "$" + Total);
            this.FindAndReplace(WordEfectivo, "<Efect>", "$" + Dinero);
            this.FindAndReplace(WordEfectivo, "<Camb>", "$" + Cambio);
            TicketEfectivo.Bookmarks["lista"].Select();

            foreach (DataGridViewRow row in Lista.Rows)
            {
                descp = row.Cells[1].Value.ToString();
                tamText = descp.Length;
                if (tamText < 19)
                {
                    while (tamText <= 22)
                    {
                        descp = descp + " ";
                        tamText++;
                    }
                }
                WordEfectivo.Selection.InsertAfter(descp);
                WordEfectivo.Selection.InsertAfter("\t");
                WordEfectivo.Selection.InsertAfter(row.Cells[0].Value.ToString());
                WordEfectivo.Selection.InsertAfter("\t");
                WordEfectivo.Selection.InsertAfter("$" + row.Cells[3].Value.ToString());
                WordEfectivo.Selection.InsertParagraphAfter();

            }

            // WordEfectivo.ActivePrinter = "POS-58";
            WordEfectivo.PrintOut();
           //WordEfectivo.Visible = true;
           WordEfectivo.Quit(isVisible);
            foreach (DataGridViewRow row in Lista.Rows)
            {
                InsertarProducto(Convert.ToInt32(row.Cells[0].Value), Convert.ToDecimal(row.Cells[2].Value), Convert.ToInt32(row.Cells[4].Value));
            }

        }
        public void ReopenWordEfectivo()
        {
            WordEfectivo = new Microsoft.Office.Interop.Word.Application();
            TicketEfectivo = WordEfectivo.Documents.Open(Directory.GetCurrentDirectory() + "//Ticket.docx", ref missing, ref readOnly,
                                     ref missing, ref missing, ref missing,
                                     ref missing, ref missing, ref missing,
                                     ref missing, ref missing, ref missing,
                                     ref missing, ref missing, ref missing, ref missing);
            WordEfectivo.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone;
            WordEfectivo.Options.PrintBackground = false;
        }
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;

            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }
        public void InsertarProducto(int prod, decimal cant, decimal total)
        {
            Console.WriteLine(cant);
            fecha = DateTime.Today.ToString("dd/MMM/yyyy");
            OleDbCommand CmdSql = new OleDbCommand("insert into Detalle_Ventas (Ref_venta,Codigo_p,cant,importe,fecha,id_user)values(" + folio + "," + prod + "," + cant + "," + total + ",'" + fecha + "'," + cuser.Id + ")", con.cn);
            CmdSql.ExecuteNonQuery();


        }
        public void Limpiar()
        {
           eliminarallbtn.PerformClick();
            Dinero = 0;
            Cambio = 0;

        }
    }

}
