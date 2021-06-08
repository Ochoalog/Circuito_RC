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
using System.IO.Ports;
using ZedGraph;

namespace ProjetoGráfico
{
    public partial class Form1 : Form
    {
        double[] x = new double[100000];
        double[] y = new double[100000];
        int j;
        double i;

        public void Create(ZedGraphControl zgc, string titulo, string nomeX, string nomeY)
        {
            // get a reference to the GraphPane

            GraphPane myPane = zgc.GraphPane;

            // Seta os títulos

            myPane.Title.Text = titulo;
            myPane.XAxis.Title.Text = nomeX;
            myPane.YAxis.Title.Text = nomeY;

        }
        public Form1()
        {
            InitializeComponent();
            timer.Start();
            Create(zed, "Tensão no capacitor em função do tempo", "Tempo (ms)", "Tensão no capacitor(V)");
        }


        private void btnCarregar_Click(object sender, EventArgs e)
        {

            if (serialPort.IsOpen == false)
            {
                try
                {
                    serialPort.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort.Open();

                }
                catch
                {
                    return;

                }
                if (serialPort.IsOpen)
                {
                    btnCarregar.Text = "Desconectar";
                    comboBox1.Enabled = false;

                }
            }
            else
            {

                try
                {
                    serialPort.Close();
                    comboBox1.Enabled = true;
                    btnCarregar.Text = "Conectar";
                }
                catch
                {
                    return;
                }

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();

            if (serialPort.IsOpen)
            {               
                serialPort.Write("a");
                String[] DadosColetados = serialPort.ReadLine().Split('*');
                if (DadosColetados.Length == 4)
                {
                    double TensaoVc = double.Parse(DadosColetados[1], CultureInfo.InvariantCulture);
                    int Tempo = int.Parse(DadosColetados[2], CultureInfo.InvariantCulture);


                    x[j] = i;
                    y[j] = TensaoVc;
                    j++;
                    i += 0.1;
                }                                
            }
            zed.GraphPane.CurveList.Clear();
            zed.GraphPane.AddCurve("Capacitor", x, y, Color.Black);
            zed.RestoreScale(zed.GraphPane);
            zed.Refresh();
        }

        private void atualizaListaCOMs()
        {
            int i = 0;
            bool quantDiferente = false;    //flag para sinalizar que a quantidade de portas mudou
                        

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }
    }
}

