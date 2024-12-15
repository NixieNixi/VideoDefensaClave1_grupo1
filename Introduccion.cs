using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoDefensaClave1_grupo1
{
    public partial class Introduccion : Form
    {
        public Introduccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObjetivoGeneral objetivoGeneral = new ObjetivoGeneral();
            this.Hide();
            objetivoGeneral.ShowDialog();
        }
    }
}
