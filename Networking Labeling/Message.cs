using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Networking_Labeling
{
    public partial class Message : Form
    {
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_LBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void Message_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_LBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Message()
        {
            InitializeComponent();
        }

        //Datos almacenados
        public string message;
        public string icon;

        private void Message_Load(object sender, EventArgs e)
        {
            //Location
            this.StartPosition = FormStartPosition.CenterParent;

            //Muestra el mensaje
            lblMessage.Text = message;

            switch (icon)
            {
                case "info":
                    //pBoxImage.Image = Properties.Resources.icons8_información_240;
                    break;
                case "error":
                    //pBoxImage.Image = Properties.Resources.icons8_error_96;
                    break;
                case "scan":
                    //pBoxImage.Image = Properties.Resources.icons8_escáner_de_código_de_barras_2_filled_96;
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Cierra la ventana
            this.Close();
        }
    }
}