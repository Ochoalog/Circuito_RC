using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProjetoGráfico
{
    public partial class Form1 : Form
    {
        static int tempo = 0;
        double[] x = new double[tempo];
        double[] y = new double[tempo];


        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                btnOk.Text = "Iniciar";

            } else
            {
                btnOk.Text = "Finalizar";
                serialPort.Open();                
            }
            int tensaoVc;

            if (tempo < 0 || txtTempo.Text == "")
            {
                MessageBox.Show("Valor de tempo inválido.");
                txtTempo.Focus();
                return;
            }


            tempo = int.Parse(txtTempo.Text);
            double[] x = new double[tempo];
            double[] y = new double[tempo];

            if (txtResistencia.Text == "")
            {
                MessageBox.Show("Digite valores para Resistência.");
                txtResistencia.Focus();
                return;
            }
            if(txtCapacitor.Text == "")
            {
                MessageBox.Show("Digite valores para Capacitância.");
                txtCapacitor.Focus();
                return;
            }
            if(tempo < 0)
            {
                MessageBox.Show("Valor de tempo inválido.");
                txtTempo.Focus();
                return;
            }

            double resistor = double.Parse(txtResistencia.Text, CultureInfo.InvariantCulture);
            double capacitor = double.Parse(txtCapacitor.Text, CultureInfo.InvariantCulture);
            if(txtVc.Text == "")
            {
                tensaoVc = 0;
            } else
            {
                tensaoVc = int.Parse(txtVc.Text);
            }
            
            
            double tensaoFonte = double.Parse(txtFonte.Text);
            string EDO = $"{tensaoFonte} + ({tensaoVc} - {tensaoFonte}) . e^ t/({resistor} . {capacitor})";

            GRAFICO_RC dadosGrafico = new GRAFICO_RC();
            dadosGrafico.VALOR_CAPACITOR = capacitor.ToString();
            dadosGrafico.VALOR_RESISTOR = resistor.ToString();
            dadosGrafico.TEMPO = tempo.ToString();
            dadosGrafico.Vc_INICIAL = tensaoVc.ToString();
            dadosGrafico.V_FONTE = tensaoFonte.ToString();
            dadosGrafico.EDO = EDO;

            using (dbAUTOGEMINIEntities5 dados = new dbAUTOGEMINIEntities5())
            {
                dados.GRAFICO_RC.Add(dadosGrafico);
                dados.SaveChanges();
            }

            for (int t = 0; t < tempo; t++)
            {
                x[t] = t;
                y[t] = (tensaoFonte + (tensaoVc - tensaoFonte) * Math.Exp(-(t/resistor*capacitor)));
            }

            zed.GraphPane.CurveList.Clear();
            zed.GraphPane.AddCurve("curva", x, y, Color.Black);
            zed.RestoreScale(zed.GraphPane);
            zed.Refresh();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
