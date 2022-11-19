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

namespace InfoDispositivoUSB
{
    public partial class frmMain : Form
    {
        static SerialPort serialPort;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            foreach (var device in USBDeviceInfo.GetUSBDevices())
            {
                ExibirInformacoesUSB(device);
            } 
        }

        private void ExibirInformacoesUSB(USBDeviceInfo porta)
        {
            rtbMonitor.AppendText($"****************************************************************\r\n");
            rtbMonitor.AppendText($"Nome: {porta.Name}\r\n");
            rtbMonitor.AppendText($"Fabricante: {porta.Manufacturer}\r\n");
            rtbMonitor.AppendText($"Porta: {porta.SerialPort}\r\n");
            rtbMonitor.AppendText($"****************************************************************\r\n");
            rtbMonitor.AppendText("\r\n");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rtbMonitor.Clear();
        }

        private void cmbPortaCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            USBDeviceInfo porta = USBDeviceInfo.GetDeviceInfo(cmbPortaCom.Text);
            ExibirInformacoesUSB(porta);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (var device in USBDeviceInfo.GetUSBDevices())
            {
                cmbPortaCom.Items.Add(device.SerialPort);
            }           
        }

        private void Destacar(RichTextBox rc, IEnumerable<string> palavras)
        {
            foreach (var palavra in palavras)
            {
                int posicao = 0;
                while (posicao > -1)
                {
                    posicao = rc.Text.IndexOf(palavra, posicao);
                    if (posicao > -1)
                    {
                        rc.Select(posicao, palavra.Length);
                        rc.SelectionBackColor = Color.GreenYellow;
                        rc.SelectionColor = Color.Red;
                        rc.Select(0, 0);
                        posicao += palavra.Length;
                    }
                }
            }
        }

        private void btnDestacar_Click(object sender, EventArgs e)
        {
            Destacar(rtbMonitor, txtDestacar.Text.Split(';'));
        }
    }
}
