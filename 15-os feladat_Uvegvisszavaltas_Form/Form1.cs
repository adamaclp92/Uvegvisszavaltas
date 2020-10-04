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
          

            try
            {
                int[] darabszamok = new int[6]
                {
                        String.IsNullOrWhiteSpace(textBox1.Text)? 0: int.Parse(textBox1.Text),
                        String.IsNullOrWhiteSpace(textBox2.Text)? 0: int.Parse(textBox2.Text),
                        String.IsNullOrWhiteSpace(textBox3.Text)? 0: int.Parse(textBox3.Text),
                        String.IsNullOrWhiteSpace(textBox4.Text)? 0: int.Parse(textBox4.Text),
                        String.IsNullOrWhiteSpace(textBox5.Text)? 0: int.Parse(textBox5.Text),
                        String.IsNullOrWhiteSpace(textBox6.Text)? 0: int.Parse(textBox6.Text)
                };
                for (int i = 0; i < darabszamok.Length; i++)
                {
                    if (darabszamok[i] < 0)
                        throw new NegativNumberException();
                }

                label8.Text = string.Format(kontener.fizetendo(darabszamok).ToString() + " Ft");
            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NegativNumberException f)
            {
                MessageBox.Show(f.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
