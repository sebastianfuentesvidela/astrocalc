using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using SD = System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AstroCalc;

namespace AstroTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            float longi = 70.43f, latit = 33.27f;
            this.txNombre.Text = "";
            this.nAno.Value = DateTime.Now.Year;
            this.nMes.Value = DateTime.Now.Month;
            this.nDia.Value = DateTime.Now.Day;
            this.nHora.Value = DateTime.Now.Hour;
            this.nMinu.Value = DateTime.Now.Minute;
            this.nTzone.Value = 4;
            this.mLong.Text = longi.ToString("###.##");
            this.ckOeste.Checked = false;
            this.mLati.Text = latit.ToString("###.##");
            this.ckSur.Checked = true;

        }

        private void boton_Click(object sender, EventArgs e)
        {
            float longi = float.Parse(this.mLong.Text.Replace('°',',').Replace('\'', '0'));
            if (this.ckOeste.Checked) longi = -1 * longi;
            float latit = float.Parse(this.mLati.Text.Replace('°',',').Replace('\'', '0'));
            if (this.ckSur.Checked) latit = -1 * latit;
            txOut.Text = "";
            AstroCalc.AstroCalc astro = new AstroCalc.AstroCalc(this.txNombre.Text,
                (float)this.nDia.Value, (float)this.nMes.Value, (float)this.nAno.Value, (float)this.nHora.Value,
                (float)this.nMinu.Value, "", (float)this.nTzone.Value, longi, latit);
            astro.CalculaPosiciones();

            foreach (string kp in astro.astralSet.Planets.Keys)
            {
                Planet pla = astro.astralSet.Planets[kp];
                txOut.Text = txOut.Text + pla.see + '\t' + pla.sh + '\t' + pla.sg + '\t' + pla.h  + '\t' + pla.who  + '\t' + pla.p  + '\t' + pla.plt  + '\t' + pla.plx + "\r\n";
            }
 
            foreach (string kp in astro.astralSet.Houses.Keys)
            {
                House ha = astro.astralSet.Houses[kp];
                txOut.Text = txOut.Text + kp + '.' + ha.ha  + '\t' + ha.romqi   + '\t' + ha.sg + '\t' + ha.sh + '\t' + ha.so   + '\t' + ha.romla+ '\t' + ha.sg0 + "\r\n";
            }
 
            foreach (string kp in astro.astralSet.Aspects.Keys)
            {
                Aspect ape = astro.astralSet.Aspects[kp];
                txOut.Text = txOut.Text + ape.see + '\t' + ape.kind + '\t' + ape.dev + '\t' + ape.sKey + '\t' + ape.planet1 + '\t' + ape.planet2 + "\r\n";
            }

            SD.Bitmap pinta = astro.MakeGraph("uno", pictureBox1.Width, pictureBox1.Height, "papel11.GIF");

            pictureBox1.Image = pinta;
        }

    }
}
