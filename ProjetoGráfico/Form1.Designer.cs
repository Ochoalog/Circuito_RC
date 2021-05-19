
namespace ProjetoGráfico
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zed = new ZedGraph.ZedGraphControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtResistencia = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtCapacitor = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFonte = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // zed
            // 
            this.zed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zed.Location = new System.Drawing.Point(394, 88);
            this.zed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zed.Name = "zed";
            this.zed.ScrollGrace = 0D;
            this.zed.ScrollMaxX = 0D;
            this.zed.ScrollMaxY = 0D;
            this.zed.ScrollMaxY2 = 0D;
            this.zed.ScrollMinX = 0D;
            this.zed.ScrollMinY = 0D;
            this.zed.ScrollMinY2 = 0D;
            this.zed.Size = new System.Drawing.Size(571, 472);
            this.zed.TabIndex = 0;
            this.zed.UseExtendedPrintDialog = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(967, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // txtResistencia
            // 
            this.txtResistencia.Location = new System.Drawing.Point(157, 239);
            this.txtResistencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResistencia.Name = "txtResistencia";
            this.txtResistencia.Size = new System.Drawing.Size(53, 25);
            this.txtResistencia.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(14, 466);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 34);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Iniciar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtCapacitor
            // 
            this.txtCapacitor.Location = new System.Drawing.Point(218, 335);
            this.txtCapacitor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCapacitor.Name = "txtCapacitor";
            this.txtCapacitor.Size = new System.Drawing.Size(37, 25);
            this.txtCapacitor.TabIndex = 6;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(11, 57);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(631, 18);
            this.lblTexto.TabIndex = 7;
            this.lblTexto.Text = "Digite a resistência e a capacitância para ver a tensão no capacitor em função do" +
    " tempo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 11);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ohm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 11);
            this.label2.TabIndex = 9;
            this.label2.Text = "F";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tempo máximo (s):";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(147, 118);
            this.txtTempo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(39, 25);
            this.txtTempo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tensão inicial no capacitor:";
            // 
            // txtVc
            // 
            this.txtVc.Location = new System.Drawing.Point(210, 155);
            this.txtVc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVc.Name = "txtVc";
            this.txtVc.Size = new System.Drawing.Size(44, 25);
            this.txtVc.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tensão no capacitor em função do tempo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tempo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoGráfico.Properties.Resources.TensaoCapacitor;
            this.pictureBox2.Location = new System.Drawing.Point(403, 248);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 124);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoGráfico.Properties.Resources.circuito_RC;
            this.pictureBox1.Location = new System.Drawing.Point(16, 230);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtFonte
            // 
            this.txtFonte.Location = new System.Drawing.Point(25, 344);
            this.txtFonte.Name = "txtFonte";
            this.txtFonte.Size = new System.Drawing.Size(42, 25);
            this.txtFonte.TabIndex = 17;
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM3";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 577);
            this.Controls.Add(this.txtFonte);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtCapacitor);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtResistencia);
            this.Controls.Add(this.zed);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circuito RC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.TextBox txtResistencia;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCapacitor;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtFonte;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer;
    }
}

