using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coreea_de_Sud
{
    public partial class Video_foto : Form
    {
        public Video_foto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Poze p = new Poze();
            this.Hide();
            p.ShowDialog();
            p.Dispose();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Video v = new Video();
            this.Hide();
            v.ShowDialog();
            v.Dispose();
            this.Show();
        }
    }
}
