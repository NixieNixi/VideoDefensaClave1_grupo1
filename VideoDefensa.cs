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
    public partial class VideoDefensa : Form
    {
        public VideoDefensa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Introduccion introduccion = new Introduccion();
            this.Hide();
            introduccion.ShowDialog();
        }
    }
}
