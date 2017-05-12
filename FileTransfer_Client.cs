using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTransfer_Client
{
    public partial class FileTransfer_Client : Form
    {
        public bool btnOK_status = false;
        public FileTransfer_Client()
        {
            InitializeComponent();
        }

        private void FileTransfer_Client_Load(object sender, EventArgs e)
        {
            maskedTextBox_IPconnection.ValidatingType = typeof(System.Net.IPAddress);
            maskedTextBox_IPconnection.TypeValidationCompleted += new TypeValidationEventHandler(IPAdress_TypeValidationCompleted);
        }

        private void pb_UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "both files|*.mp3;*.pdf|pdf files (*.pdf)|*.pdf|mp3 files (*.mp3)|*.mp3";
            ofd.InitialDirectory = @"C:\";
            ofd.Title = "Selecione o arquivo mp3 ou pdf para transferir ao servidor.";
            if (ofd.ShowDialog() == DialogResult.OK && maskedTextBox_IPconnection.Text != "   .   .   .")
            {
                string path = ofd.FileName;

                Stream fileStream = File.OpenRead(path);
                // Alocate memory space for the file
                byte[] fileBuffer = new byte[fileStream.Length];
                fileStream.Read(fileBuffer, 0, (int)fileStream.Length);
                // Open a TCP/IP Connection and send the data
                string ip = maskedTextBox_IPconnection.Text;
                ip = ip.Replace(@",", @".");
                ip = ip.Replace(@" ", @"0");
                TcpClient clientSocket = new TcpClient(ip, 8080);
                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Write(fileBuffer, 0, fileBuffer.GetLength(0));
                networkStream.Close();

            }
            else
            {
                MessageBox.Show("Certifique-se que o IP do servidor está informado.");
            }
        }

        private void pb_UploadButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            int VisibleTime = 1000;
            tp.Show("Selecione o arquivo para enviar ao servidor.", pb_UploadButton, 0, 63, VisibleTime);
        }

        private void pb_InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trabalho III - Mini-servidor de arquivos - Socket TCP (Client)");
        }

        private void pb_InfoButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            int VisibleTime = 1000;
            tp.Show("Sobre...", pb_UploadButton, 170, 60, VisibleTime);
        }

        private void pb_ShutdownButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pb_ShutdownButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            int VisibleTime = 1000;
            tp.Show("Sair", pb_UploadButton, 190, -60, VisibleTime);
        }

        private void btn_IPConnectionOk_Click(object sender, EventArgs e)
        {
            Control_btn_IPConnectionOK();
        }

        private void Control_btn_IPConnectionOK ()
        {
            if (btnOK_status == false)
            {
                btnOK_status = true;
                maskedTextBox_IPconnection.Enabled = false;
                btn_IPConnectionOk.Text = "Cancel";
                btn_IPConnectionOk.Size = new Size(68,23);
            }
            else
            {
                btnOK_status = false;
                maskedTextBox_IPconnection.Enabled = true;
                btn_IPConnectionOk.Text = "OK";
                btn_IPConnectionOk.Size = new Size(34, 23);
            }
        }

        void IPAdress_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            string ip = maskedTextBox_IPconnection.Text;
            ip = ip.Replace(@",", @".");
            ip = ip.Replace(@" ", @"0");
            maskedTextBox_IPconnection.Text = ip;
        }
    }
}
