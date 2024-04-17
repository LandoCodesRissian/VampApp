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
    public partial class vPage1 : Form
    {
        public static string VaClan;
        public vPage1()
        {
            InitializeComponent();
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            vPage2 vPage2 = new vPage2();
            vPage2.Owner = this;
            vPage2.Show();
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            vPage3 vPage3 = new vPage3();
            vPage3.Owner = this;
            vPage3.Show();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            vPage4 vPage4 = new vPage4();
            vPage4.Owner = this;
            vPage4.Show();
        }
        public void vStam_LostFocus(object sender, System.EventArgs e)
        {
            double Stamina = double.Parse(vStam.Text);
            vHealth.Text = (Stamina + 3).ToString();
        }

        public void vCompWits_LostFocus(object sender, System.EventArgs e)
        {
            double Composure = double.Parse(vComp.Text);
            double Resolve = double.Parse(vResolve.Text);

            vWillpower.Text = (Composure + Resolve).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path
                
            }
        }
        public void Load_DIS(object sender, System.EventArgs e)
        {

            VaClan = vClans.Text;
            if (VaClan.ToString() == "Banu Haqim")
            {
                vMainDis1.Text = "";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "";
                vMainDis3.Enabled = false;
            }
            else if (VaClan.ToString() == "Brujah")
            {
                vMainDis1.Text = "Celerity";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Potence";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Presence";
                vMainDis3.Enabled = false;
            }
            else if (VaClan.ToString() == "Gangrel")
            {
                vMainDis1.Text = "Animalism";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Fortitude";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Protean";
                vMainDis3.Enabled = false;
            }
            else if (VaClan.ToString() == "Hecata")
            {
                vMainDis1.Text = "Necromancy";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Fortitude";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Potence";
                vMainDis3.Enabled = false;
            }
            else if (VaClan.ToString() == "Lasombra")
            {
                vMainDis1.Text = "Dominate";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Oblivion";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Potence";
                vMainDis3.Enabled = false;
            }
            else if (VaClan.ToString() == "Malkavian")
            {
                vMainDis1.Text = "Auspex";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Dominate";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Obfuscate";
                vMainDis3.Enabled = false;
            }
            else if (VaClan.ToString() == "The Ministry")
            {
                vMainDis1.Text = "Serpentis";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Obfuscate";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Presence";
                vMainDis3.Enabled = false;
            }
            else if (VaClan.ToString() == "Nosferatu")
            {
                vMainDis1.Text = "Animalism";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Obfuscate";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Potence";
                vMainDis3.Enabled = false;
            }
            else if (VaClan.ToString() == "Ravnos")
            {
                vMainDis1.Text = "Animalism";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Chimerstry";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Fortitude";
                vMainDis3.Enabled = false;
            }
            else if (VaClan.ToString() == "Toreador")
            {
                vMainDis1.Text = "Auspex";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Celerity";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Presence";
                vMainDis3.Enabled = false;
            }
            else if (VaClan.ToString() == "Tremere")
            {
                vMainDis1.Text = "Auspex";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Dominate";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Fortitude";
                vMainDis3.Enabled = false;
            }
            else if (VaClan.ToString() == "Tzimisce")
            {
                vMainDis1.Text = "Animalism";
                vMainDis1.Enabled = false;
                vMainDis2.Text = "Auspex";
                vMainDis2.Enabled = false;
                vMainDis3.Text = "Vicissitude";
                vMainDis3.Enabled = false;
            }
            else if (VaClan.ToString() == "Ventrue")
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
