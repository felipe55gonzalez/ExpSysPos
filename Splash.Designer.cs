namespace ExpSysPos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.progreso = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Facebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punto de venta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // progreso
            // 
            this.progreso.animated = true;
            this.progreso.animationIterval = 2;
            this.progreso.animationSpeed = 10;
            this.progreso.BackColor = System.Drawing.Color.Transparent;
            this.progreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progreso.BackgroundImage")));
            this.progreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progreso.ForeColor = System.Drawing.Color.SeaGreen;
            this.progreso.LabelVisible = true;
            this.progreso.LineProgressThickness = 12;
            this.progreso.LineThickness = 7;
            this.progreso.Location = new System.Drawing.Point(132, 291);
            this.progreso.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progreso.MaxValue = 100;
            this.progreso.Name = "progreso";
            this.progreso.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progreso.ProgressColor = System.Drawing.Color.SeaGreen;
            this.progreso.Size = new System.Drawing.Size(116, 116);
            this.progreso.TabIndex = 1;
            this.progreso.Value = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desarollador: Ing. Felipe Gonzalez";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soporte: Felipe.Bernardo.gonzalez@Gmail.com";
            // 
            // Facebtn
            // 
            this.Facebtn.Activecolor = System.Drawing.Color.LimeGreen;
            this.Facebtn.BackColor = System.Drawing.Color.LimeGreen;
            this.Facebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Facebtn.BorderRadius = 0;
            this.Facebtn.ButtonText = "Visita Nuesto Facebook";
            this.Facebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Facebtn.DisabledColor = System.Drawing.Color.Gray;
            this.Facebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Facebtn.Iconimage = global::ExpSysPos.Properties.Resources.Face;
            this.Facebtn.Iconimage_right = null;
            this.Facebtn.Iconimage_right_Selected = null;
            this.Facebtn.Iconimage_Selected = null;
            this.Facebtn.IconMarginLeft = 0;
            this.Facebtn.IconMarginRight = 0;
            this.Facebtn.IconRightVisible = true;
            this.Facebtn.IconRightZoom = 0D;
            this.Facebtn.IconVisible = true;
            this.Facebtn.IconZoom = 150D;
            this.Facebtn.IsTab = false;
            this.Facebtn.Location = new System.Drawing.Point(105, 475);
            this.Facebtn.Name = "Facebtn";
            this.Facebtn.Normalcolor = System.Drawing.Color.LimeGreen;
            this.Facebtn.OnHovercolor = System.Drawing.Color.Green;
            this.Facebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.Facebtn.selected = false;
            this.Facebtn.Size = new System.Drawing.Size(167, 63);
            this.Facebtn.TabIndex = 4;
            this.Facebtn.Text = "Visita Nuesto Facebook";
            this.Facebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Facebtn.Textcolor = System.Drawing.Color.White;
            this.Facebtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::ExpSysPos.Properties.Resources.Splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 571);
            this.Controls.Add(this.Facebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaptionText;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton Facebtn;
        private System.Windows.Forms.Timer timer1;
    }
}

