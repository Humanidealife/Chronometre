using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronometre
{
    public partial class Form1 : Form
    {
        int compteur = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = !Timer1.Enabled;
            Button1.Text = Timer1.Enabled ? "Arrêter" : "Commencer";

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            compteur++;
            label1.Text = compteur.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            compteur = 0;
            label1.Text = compteur.ToString();
        }
    }
}
