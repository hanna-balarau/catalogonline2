using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace catalogonline
{
    public partial class Form1 : Form
    {
        int cnt = 0;
       date []elevi= new date[10];
        string path = @"C:\Users\elev\source\repos\catalogonline\catalogonline\";


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            //StreamWriter w = new StreamWriter(path + "TextFile1.txt");
            elevi[cnt] = new date();
            elevi[cnt].setNume(textBoxnume.Text.ToString());
            elevi[cnt].setPren(textBoxpren.Text.ToString());
            elevi[cnt].setMama(textBoxmama.Text.ToString());
            elevi[cnt].setTata(textBoxtata.Text.ToString());
            elevi[cnt].setcnp(textBoxcnp.Text.ToString());
            elevi[cnt].setClasa(comboBoxclasa.Text.ToString());
            elevi[cnt].setlitera(comboBoxlitera.Text.ToString());
            elevi[cnt].setTel(Convert.ToInt32(textBoxtelefon.Text.ToString()));
            elevi[cnt].setMail(textBoxemail.Text.ToString());
            MessageBox.Show("Ai introdus corect!");
           // w.WriteLine(cnt.ToString() + "|" + elevi[cnt].getNume() + "|" + elevi[cnt].getPren() + "|" + elevi[cnt].getMama() + "|" + elevi[cnt].getTata() + "|" + elevi[cnt].getcnp() + "|" + elevi[cnt].getClasa() + "|" + elevi[cnt].getlitera() + "|" + elevi[cnt].getTel() + "|" + elevi[cnt].getMail());
            
            //w.Close();
            File.AppendAllText(path + "TextFile1.txt", cnt.ToString() + "|" + elevi[cnt].getNume() + "|" + elevi[cnt].getPren() + "|" + elevi[cnt].getMama() + "|" + elevi[cnt].getTata() + "|" + elevi[cnt].getcnp() + "|" + elevi[cnt].getClasa() + "|" + elevi[cnt].getlitera() + "|" + elevi[cnt].getTel() + "|" + elevi[cnt].getMail()+'\n');
             cnt++;



        }

        private void zi_TextChanged(object sender, EventArgs e)
        {

        }

        private void luna_TextChanged(object sender, EventArgs e)
        {

        }

        private void an_TextChanged(object sender, EventArgs e)
        {

        }

        private void gen_TextChanged(object sender, EventArgs e)
        {

        }

        private void Verificare_Click(object sender, EventArgs e)
        {
            string s = textBoxcnp.Text.ToString();
            char[] chars = s.ToCharArray();
            int[] y = { 2, 7, 9, 1, 4, 6, 3, 5, 8, 2, 7, 9 };
            int x = 0;
            for(int i=0;i<12;i++)
            {
                x += (Convert.ToInt32(chars[i]) - '0') + y[i];

            }
            int cif_control = x % 11;
            if (cif_control == 10)
                cif_control = 1;
            if (cif_control == Convert.ToInt32(chars[12]) - '0')
                textBoxcnp.ForeColor = Color.Green;
            else
                textBoxcnp.ForeColor = Color.Red;
            if (chars[0] == '5')
                gen.Text = "Masculin";
            if (chars[0]=='6')
                gen.Text = "Feminin";
        }
    }
}
