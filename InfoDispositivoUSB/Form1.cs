using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
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

        private void cmbPortaCom_DropDown(object sender, EventArgs e)
        {
            cmbPortaCom.Items.Clear();
            foreach (var device in USBDeviceInfo.GetUSBDevices())
            {
                cmbPortaCom.Items.Add(device.SerialPort);
            }
        }

        void CutAction(object sender, EventArgs e)
        {
            rtbMonitor.Cut();
        }

        void CopyAction(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Rtf, rtbMonitor.SelectedRtf);
        }

        void PasteAction(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                rtbMonitor.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
            else
            {
                rtbMonitor.AppendText(Clipboard.GetData(DataFormats.UnicodeText).ToString());
            }
        }

        void OpenAction(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.rtf";
            ofd.Filter = "RTF Files|*.rtf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtbMonitor.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);

            }


        }


        private void rtbMonitor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu contextMenu = new ContextMenu();
                MenuItem menuItem;

                menuItem = new MenuItem("Abrir rtf");
                menuItem.Click += new EventHandler(OpenAction);
                contextMenu.MenuItems.Add(menuItem);

                menuItem = new MenuItem("Recortar");
                menuItem.Click += new EventHandler(CutAction);
                contextMenu.MenuItems.Add(menuItem);

                menuItem = new MenuItem("Copiar");
                menuItem.Click += new EventHandler(CopyAction);
                contextMenu.MenuItems.Add(menuItem);

                menuItem = new MenuItem("Colar");
                menuItem.Click += new EventHandler(PasteAction);
                contextMenu.MenuItems.Add(menuItem);

                rtbMonitor.ContextMenu = contextMenu;
            }
        }

    }
}
