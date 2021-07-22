using Polymoorphism.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymoorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //insan sınıfından bir nesne yapalım 
            İnsan insan = new İnsan();
            insan.NefesAl();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hayvan hayvan = new Hayvan();
            hayvan.NefesAl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitki bitki = new Bitki();
            bitki.NefesAl();
        }
    }
}
