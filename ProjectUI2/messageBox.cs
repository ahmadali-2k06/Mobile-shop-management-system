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

namespace ProjectUI2
{
    public partial class messageBox : Form
    {
        public enum MessageType
        {
            Success,
            Warning,
            Error,
            Info
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private Timer fadeTimer;

        public messageBox()
        {
            InitializeComponent();

            // Drag support
            paneltop.MouseDown += MessageBox_MouseDown;
            this.MouseDown += MessageBox_MouseDown;

            // Fade animation
            this.Opacity = 0;
            fadeTimer = new Timer();
            fadeTimer.Interval = 10;
            fadeTimer.Tick += FadeIn;
            this.Load += messageBox_Load;
        }

        public messageBox(string message, string title = "Message", MessageType type = MessageType.Info) : this()
        {
            labelhead.Text = title;
            labelMessage.Text = message;
            ApplyMessageType(type);
        }

        private void messageBox_Load(object sender, EventArgs e)
        {
            fadeTimer.Start();
        }

        private void FadeIn(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
            else
                fadeTimer.Stop();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void ApplyMessageType(MessageType type)
        {
            switch (type)
            {
                case MessageType.Success:
                    pictureBoxIcon.Image = Properties.Resources.icons8_exclamation_mark_96;  
                    System.Media.SystemSounds.Asterisk.Play();
                    break;
                case MessageType.Warning:
                    pictureBoxIcon.Image = Properties.Resources.icons8_warning_100;
                    System.Media.SystemSounds.Exclamation.Play();
                    break;
                case MessageType.Error:
                    pictureBoxIcon.Image = Properties.Resources.icons8_error_100;
                    System.Media.SystemSounds.Hand.Play();
                    break;
                case MessageType.Info:
                default:
                    pictureBoxIcon.Image = Properties.Resources.icons8_info_100;
                    System.Media.SystemSounds.Asterisk.Play();
                    break;
            }
        }
    }
    }

