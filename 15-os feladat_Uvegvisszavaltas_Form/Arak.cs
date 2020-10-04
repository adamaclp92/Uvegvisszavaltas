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

namespace _15_os_feladat_Uvegvisszavaltas_Form
{
    public partial class Arak : Form
    {
        Form opener;

        public Arak(Form parentform)
        {
            InitializeComponent();
            opener = parentform;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("Arlista.txt");
            Uveg_kontener kontener = new Uveg_kontener();

            while (!file.EndOfStream)
            {
                string sor = file.ReadLine();
                string[] adat = sor.Split(';');
                              
                Uvegek uj = new Uvegek ((Uvegfajtak)Enum.Parse(typeof(Uvegfajtak), adat[0]), int.Parse(adat[1]));
                kontener.hozzaad(uj);
            }

            for (int i = 0; i < kontener.uvegfajtak_szama(); i++)
            {
                string Uvegtar = string.Format("{0}: {1} Ft", kontener[i].Uvegfajta, kontener[i].Uvegar);
                listBox1.Items.Add(Uvegtar);
            }
        }

    }

}
