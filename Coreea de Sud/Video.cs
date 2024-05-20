using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Coreea_de_Sud
{
    
    public partial class Video : Form
    {
        string[] f;
        public Video()
        {
            InitializeComponent();
            cautaFisier.InitialDirectory = Directory.GetCurrentDirectory();
            if (cautaFisier.ShowDialog() == DialogResult.OK)
            {
                f = Directory.GetFiles(Path.GetDirectoryName(cautaFisier.FileName));
                for (int i = 0; i < f.Length; i++)
                    ListaFilme.Items.Add(f[i]);
            }
        }

        private void cautaFisier_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ListaFilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmp.URL = (string)ListaFilme.SelectedItem;
        }

        private void Video_FormClosing(object sender, FormClosingEventArgs e)
        {
            wmp.Ctlcontrols.stop();
        }
    }
}
