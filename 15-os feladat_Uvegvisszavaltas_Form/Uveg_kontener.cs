using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_os_feladat_Uvegvisszavaltas_Form
{
    class Uveg_kontener
    {
        List<Uvegek> kontener = new List<Uvegek>();

        public void hozzaad(Uvegek uveg)
        {
            kontener.Add(uveg);
        }
        public Uvegek this[int index]
        {
            get
            {
                return kontener[index];
            }
            set
            {
                kontener[index] = value;
            }
        }

        public int uvegfajtak_szama()
        {
            int s = 0;
            foreach (Uvegek u in kontener)
            {
                s++;
            }
            return s;
        }

        public int fizetendo(int[] uvegek_darab)
        {
            int i = 0;
            int kifizetendo = 0;
            foreach (Uvegek k in kontener)
            {
                kifizetendo += uvegek_darab[i] * k.Uvegar;
                i++;
            }
            return kifizetendo;
        }
    }
}
