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
    public partial class CoreeadeSud : Form
    {
        public CoreeadeSud()
        {
            InitializeComponent();
        }

        private void buton_Istorie_Click(object sender, EventArgs e)
        {
            Istorie i = new Istorie();
            this.Hide();
            i.ShowDialog();
            i.Dispose();
            this.Show();
        }

        private void buton_Geografie_Click(object sender, EventArgs e)
        {
            Geografie g = new Geografie();
            this.Hide();
            g.ShowDialog();
            g.Dispose();
            this.Show();
        }

        private void buton_Economie_Click(object sender, EventArgs e)
        {
            Economie ec = new Economie();
            this.Hide();
            ec.ShowDialog();
            ec.Dispose();
            this.Show();
        }

        private void buton_Demografie_Click(object sender, EventArgs e)
        {
            Demografie d = new Demografie();
            this.Hide();
            d.ShowDialog();
            d.Dispose();
            this.Show();
        }

        private void buton_Cultura_Click(object sender, EventArgs e)
        {
            Cultura c = new Cultura();
            this.Hide();
            c.ShowDialog();
            c.Dispose();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Video_foto vf = new Video_foto();
            this.Hide();
            vf.ShowDialog();
            vf.Dispose();
            this.Show();
        }
    }
}
