
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
            this.btnCarregar = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // zed
            // 
            this.zed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zed.Location = new System.Drawing.Point(0, 125);
            this.zed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zed.Name = "zed";
            this.zed.ScrollGrace = 0D;
            this.zed.ScrollMaxX = 0D;
            this.zed.ScrollMaxY = 0D;
            this.zed.ScrollMaxY2 = 0D;
            this.zed.ScrollMinX = 0D;
            this.zed.ScrollMinY = 0D;
            this.zed.ScrollMinY2 = 0D;
            this.zed.Size = new System.Drawing.Size(967, 452);
            this.zed.TabIndex = 0;
            this.zed.UseExtendedPrintDialog = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(967, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(190, 54);
            this.btnCarregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(99, 29);
            this.btnCarregar.TabIndex = 3;
            this.btnCarregar.Text = "Iniciar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM6";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(967, 577);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.zed);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circuito RC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnCarregar;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

