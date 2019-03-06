using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;

namespace Task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnFazerDownload_Click(object sender, EventArgs e)
        {
            string endereco = txtSite.Text;

            WebClient web = new WebClient(); //com essa classe é possível realizar download
            //string html = web.DownloadString(endereco);
            string html = await web.DownloadStringTaskAsync(new Uri(endereco));

            txtResultado.Text = html;

        }
    }
}
