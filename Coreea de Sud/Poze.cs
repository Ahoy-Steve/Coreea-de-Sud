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
    public partial class Poze : Form
    {
        string[] listaPoze;
        int crt, NrPoze;
        public Poze()
        {
            InitializeComponent();
            listaPoze = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\korea_photo\");
            NrPoze = listaPoze.Length;
            crt = 0;
            Poza.Load(listaPoze[crt]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (crt > 0) crt--;
            else crt = NrPoze - 1;
            Poza.Load(listaPoze[crt]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (crt < NrPoze - 1) crt++;
            else crt = 0;
            Poza.Load(listaPoze[crt]);
        }
    }
}
