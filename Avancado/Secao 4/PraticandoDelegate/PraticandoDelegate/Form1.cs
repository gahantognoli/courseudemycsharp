using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraticandoDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnBotao.Click += Metodo1;
            btnBotao.Click += Metodo2;
        }

        public static void Metodo1(object sender, EventArgs e)
        {
            MessageBox.Show("Delegate 1");
        }

        public static void Metodo2(object sender, EventArgs e)
        {
            MessageBox.Show("Delegate 2");
        }

    }
}
