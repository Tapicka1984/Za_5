using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_2
{
    class Herni_postava
    {
        string jmeno;
        int x = 0;
        int y = 0;
        public Herni_postava(string jmeno)
        {
            Jmeno = jmeno;
        }

        public string Jmeno
        {
            get => jmeno;
            set
            {
                if (value.Length < 11)
                {
                    jmeno = value;
                }
                else
                {
                    MessageBox.Show("Moc dlouhe");
                }
            }
        }

        public void zmena_pozice(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format("Jmeno postavy je: {0}\n Pozice X je: {1}\n Pozice Y je: {2}", Jmeno, x, y);
        }
    }
}
