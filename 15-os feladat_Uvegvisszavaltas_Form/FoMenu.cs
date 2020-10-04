using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_os_feladat_Uvegvisszavaltas_Form
{
    public partial class FoMenu : Form
    {
        public FoMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arak arlista = new Arak(this);
            arlista.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 uveglista = new Form1();
            uveglista.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
