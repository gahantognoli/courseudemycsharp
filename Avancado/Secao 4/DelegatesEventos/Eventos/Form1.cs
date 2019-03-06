using Eventos.Lib;
using Eventos.Lib.Mensageiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnVideoEncode.Click += EventoClick;
        }

        private void btnVideoEncode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnVideoEncode_Click");
        }

        public void EventoClick(object sender, EventArgs e)
        {
            Video video = new Video() { Nome = "video.mp4" };

            VideoEncode videoEncode = new VideoEncode();
            videoEncode.Encoded += new SMS().EnviarMensagem;
            videoEncode.Encoded += new Email().EnviarMensagem;
            videoEncode.Encode(video);
        }

    }
}
