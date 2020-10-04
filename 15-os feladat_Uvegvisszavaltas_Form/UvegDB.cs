using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_os_feladat_Uvegvisszavaltas_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("Arlista.txt");
            Uveg_kontener kontener = new Uveg_kontener();

            while (!file.EndOfStream)
            {
                string sor = file.ReadLine();
                string[] adat = sor.Split(';');

                Uvegek uj = new Uvegek((Uvegfajtak)Enum.Parse(typeof(Uvegfajtak), adat[0]), int.Parse(adat[1]));
                kontener.hozzaad(uj);
            }

            int[] darabszamok = new int[6]
            {int.Parse(textBox1.Text),
            int.Parse(textBox2.Text),
            int.Parse(textBox3.Text),
            int.Parse(textBox4.Text),
            int.Parse(textBox5.Text),
            int.Parse(textBox6.Text)};

            label8.Text = string.Format(kontener.fizetendo(darabszamok).ToString());
        }

        private void betűtípusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog betutipusvalaszto = new FontDialog();


            betutipusvalaszto.Font = label8.Font;

            if (betutipusvalaszto.ShowDialog() == DialogResult.OK)
            {
                label8.Font = betutipusvalaszto.Font;
            }
        }

        private void betűszínToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog szinvalaszto = new ColorDialog();

            szinvalaszto.Color = label8.ForeColor;

            if (szinvalaszto.ShowDialog() == DialogResult.OK)
            {
                label8.ForeColor = szinvalaszto.Color;
            }

        }

        private void háttérszíneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog hatterszinvalaszto = new ColorDialog();

            hatterszinvalaszto.Color = label8.ForeColor;

            if (hatterszinvalaszto.ShowDialog() == DialogResult.OK)
            {
                label8.BackColor = hatterszinvalaszto.Color;
            }
        }
    }
}
