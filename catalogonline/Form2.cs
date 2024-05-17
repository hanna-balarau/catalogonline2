using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace catalogonline
{
    public partial class Form2 : Form
    {
        string path = @"C:\Users\elev\source\repos\hanna-balarau\catalogonline2\catalogonline\";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form1();
            form2.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader p = new StreamReader(path + "TextFile1.txt");
            string x = p.ReadToEnd();
            label2.Text = x;
            p.Close();
        }
    }
}
