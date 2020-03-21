namespace ExpSysPos
{
    partial class Metododepago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelTot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tarjetabtn = new System.Windows.Forms.Button();
            this.cobrarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTot
            // 
            this.LabelTot.AutoSize = true;
            this.LabelTot.BackColor = System.Drawing.Color.Transparent;
            this.LabelTot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelTot.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTot.Location = new System.Drawing.Point(222, 97);
            this.LabelTot.Name = "LabelTot";
            this.LabelTot.Size = new System.Drawing.Size(89, 40);
            this.LabelTot.TabIndex = 11;
            this.LabelTot.Text = "        ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total:";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(179, 188);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(170, 62);
            this.cancelbtn.TabIndex = 9;
            this.cancelbtn.TabStop = false;
            this.cancelbtn.Text = "Cancelar - Esc";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selecciona un metodo de Pago";
            // 
            // tarjetabtn
            // 
            this.tarjetabtn.BackColor = System.Drawing.Color.AliceBlue;
            this.tarjetabtn.BackgroundImage = global::ExpSysPos.Properties.Resources.debit_card;
            this.tarjetabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tarjetabtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tarjetabtn.Enabled = false;
            this.tarjetabtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarjetabtn.Location = new System.Drawing.Point(350, 32);
            this.tarjetabtn.Name = "tarjetabtn";
            this.tarjetabtn.Size = new System.Drawing.Size(176, 132);
            this.tarjetabtn.TabIndex = 7;
            this.tarjetabtn.TabStop = false;
            this.tarjetabtn.Text = "Tarjeta - F1";
            this.tarjetabtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tarjetabtn.UseVisualStyleBackColor = false;
            this.tarjetabtn.Click += new System.EventHandler(this.tarjetabtn_Click);
            // 
            // cobrarbtn
            // 
            this.cobrarbtn.BackColor = System.Drawing.Color.AliceBlue;
            this.cobrarbtn.BackgroundImage = global::ExpSysPos.Properties.Resources.Efectivo;
            this.cobrarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cobrarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cobrarbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobrarbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cobrarbtn.Location = new System.Drawing.Point(1, 32);
            this.cobrarbtn.Name = "cobrarbtn";
            this.cobrarbtn.Size = new System.Drawing.Size(176, 132);
            this.cobrarbtn.TabIndex = 6;
            this.cobrarbtn.TabStop = false;
            this.cobrarbtn.Text = "Efectivo - F12";
            this.cobrarbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cobrarbtn.UseVisualStyleBackColor = false;
            this.cobrarbtn.Click += new System.EventHandler(this.cobrarbtn_Click);
            // 
            // Metododepago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExpSysPos.Properties.Resources.fondo_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 254);
            this.Controls.Add(this.LabelTot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tarjetabtn);
            this.Controls.Add(this.cobrarbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Metododepago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodo de pago";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Metododepago_FormClosing);
            this.Load += new System.EventHandler(this.Metododepago_Load);
            this.VisibleChanged += new System.EventHandler(this.Metododepago_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Metododepago_KeyDown);
            this.Leave += new System.EventHandler(this.Metododepago_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LabelTot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tarjetabtn;
        private System.Windows.Forms.Button cobrarbtn;
    }
}