using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_os_feladat_Uvegvisszavaltas_Form
{
    class NegativNumberException : Exception
    { 
        public override string Message
        {
            get 
            {
                return string.Format("Negatív db számot adott meg!");
            }
        }
    }
}
