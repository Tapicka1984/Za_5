using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_2
{
    enum Specializace_Enum
    {
        Kouzelník,
        Berserker,
        Inženýr,
        Cizák
    }

    enum obličej
    {
        Velký_nos,
        ušoplesk,
        make_up
    }

    enum vlasy
    {
        drdol,
        culík,
        pleška
    }

    enum barva_vlasu
    {
        kaštanová, 
        blond,
        červená
    }

    class Hrac : Herni_postava
    {
        string specializace = "";
        string obličej = "";
        string barva_vlasu = "";
        string vlasy = "";
        int lvl = 1;
        int XP = 0;

        public Hrac(string jmeno, string specializace, string oblicej, string vlasy, string barva_vlasu) : base(jmeno)
        {
            if ((specializace == "Kouzelník") || (specializace == "Berserker") || (specializace == "Inženýr") || (specializace == "Cizík"))
            {
                this.specializace = specializace;
            }
            else
            {
                MessageBox.Show("nepodporovaná specializace");
            }
            
            if ((oblicej == "Velký_nos") || (oblicej == "Ušoplesk") || (oblicej == "Make_up"))
            {
                obličej = oblicej;
            }
            else
            {
                MessageBox.Show("nepodporovaný obličej");
            }

            if ((vlasy == "Drdol") || (vlasy == "Culík") || (vlasy == "Pleška"))
            {
                this.vlasy = vlasy;
            }
            else
            {
                MessageBox.Show("nepodporované vlasy");
            }

            if ((barva_vlasu == "Kaštanová") || (barva_vlasu == "Blond") || (barva_vlasu == "Červená"))
            {
                this.barva_vlasu = barva_vlasu;
            }
            else
            {
                MessageBox.Show("nepodporovaná barva");
            }
        }

        public void pridej_XP(int xp)
        {
            while(xp > (lvl*100))
            {
                xp -= (lvl * 100);
                lvl++;
            }
        }

        public override string ToString()
        {
            return string.Format("\n specializace je: {0}\n Typ obličeje je: {1}\n Typ vlasů je: {2}\n Typ barvy vlasů je: {3}\n LVL jednotky je: {4}", specializace, obličej, vlasy, barva_vlasu, XP);
        }
    }
}
