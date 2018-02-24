using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace text_dosyasına_sıra_vedırme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("sehirler.txt");
            StreamWriter sw = new StreamWriter("temp.txt");
            while(!
            {

            }
            
        }
    }
}
