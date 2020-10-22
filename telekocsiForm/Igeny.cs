using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telekocsiForm
{
    class Igeny
    {
        public string Azon { get; private set; }
        public string Indulas { get; private set; }
        public string Cel { get; private set; }
        public int Szemelyek { get; private set; }
        public string Utvonal { get; private set; }

        public Igeny(string n)
        {
            string[] sor = n.Split(';');
            Azon = sor[0];
            Indulas = sor[1];
            Cel = sor[2];
            Szemelyek = int.Parse(sor[3]);
            Utvonal = Indulas + "-" + Cel;
        }

        public int VanAuto(List<Auto> autok)
        {
            int i = 0;
            while (i < autok.Count && !(Utvonal == autok[i].Utvonal && Szemelyek <= autok[i].Ferohely))
            {
                i++;
            }
            if (i < autok.Count)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
    }
}
