using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VamAPP
{
    public partial class vPage2 : Form
    {
        public vPage2()
        {
            InitializeComponent();
            Load_DIS();
        }
        public void Load_DIS()
        {
            

            if(vPage1.VaClan.ToString() == "Banu Haqim")
            {
                vMainDis1.Text = "";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "";
                vMainDis3.Enabled = false;
            }
            else if (vPage1.VaClan.ToString() == "Brujah")
            {
                vMainDis1.Text = "Celerity";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Potence";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Presence";
                vMainDis3.Enabled = false;
            }
            else if (vPage1.VaClan.ToString() == "Gangrel")
            {
                vMainDis1.Text = "Animalism";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Fortitude";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Protean";
                vMainDis3.Enabled = false;
            }
            else if (vPage1.VaClan.ToString() == "Hecata")
            {
                vMainDis1.Text = "Necromancy";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Fortitude";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Potence";
                vMainDis3.Enabled = false;
            }
            else if (vPage1.VaClan.ToString() == "Lasombra")
            {
                vMainDis1.Text = "Dominate";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Oblivion";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Potence";
                vMainDis3.Enabled = false;
            }
            else if (vPage1.VaClan.ToString() == "Malkavian")
            {
                vMainDis1.Text = "Auspex";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Dominate";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Obfuscate";
                vMainDis3.Enabled = false;
            }
            else if (vPage1.VaClan.ToString() == "The Ministry")
            {
                vMainDis1.Text = "Serpentis";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Obfuscate";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Presence";
                vMainDis3.Enabled = false;
            }
            else if (vPage1.VaClan.ToString() == "Nosferatu")
            {
                vMainDis1.Text = "Animalism";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Obfuscate";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Potence";
                vMainDis3.Enabled = false;
            }
            else if (vPage1.VaClan.ToString() == "Ravnos")
            {
                vMainDis1.Text = "Animalism";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Chimerstry";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Fortitude";
                vMainDis3.Enabled = false;
            }
            else if (vPage1.VaClan.ToString() == "Toreador")
            {
                vMainDis1.Text = "Auspex";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Celerity";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Presence";
                vMainDis3.Enabled = false;
            }
            else if (vPage1.VaClan.ToString() == "Tremere")
            {
                vMainDis1.Text = "Auspex";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Dominate";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Fortitude";
                vMainDis3.Enabled = false;
            }
            else if (vPage1.VaClan.ToString() == "Tzimisce")
            {
                vMainDis1.Text = "Animalism";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Auspex";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Vicissitude";
                vMainDis3.Enabled = false;
            }
            else if (vPage1.VaClan.ToString() == "Ventrue")
            {
                vMainDis1.Text = "Dominate";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Fortitude";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Presence";
                vMainDis3.Enabled = false;
            }
        }

    }
}
